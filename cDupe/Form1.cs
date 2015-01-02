using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;

namespace cDupe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// False: not currently mirroring
        /// True: currently mirroring
        /// </summary>
        bool mirroring = false;

        /// <summary>
        /// width of duplication zone
        /// </summary>
        int x_size = 255;

        /// <summary>
        /// height of duplication zone
        /// </summary>
        int y_size = 230;


        /// <summary>
        /// x based point location of duplication zone
        /// </summary>
        int x_loc = 0;

        /// <summary>
        /// y based point location of duplication zone
        /// </summary>
        int y_loc = 0;

        /// <summary>
        /// bitmap of duplication zone
        /// </summary>
        Bitmap img = null;

        /// <summary>
        /// Graphics to be used to grab duplication zone
        /// </summary>
        Graphics graphics;

        /// <summary>
        /// form loading method
        /// grab settings from Properties.Settings.Default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //set resize toolstrip check to saved setting
            ToolStripResizeToScale.Checked = Properties.Settings.Default.resize_to_ratio;

            //get other settings
            x_size = Properties.Settings.Default.x_size;
            y_size = Properties.Settings.Default.y_size;
            x_loc = Properties.Settings.Default.x_loc;
            y_loc = Properties.Settings.Default.y_loc;

            //set combobox values to be from 1 to 120
            ComboBoxRefreshRate.Items.Clear();
            for (int i = 1; i != 251; i++)
            {
                ComboBoxRefreshRate.Items.Add(i);
            }
            //grab value from settings
            ComboBoxRefreshRate.Text = Properties.Settings.Default.refresh_rate.ToString();

            //if ratio is enforced, enforce it
            if (ToolStripResizeToScale.Checked)
            {
                scaleToDuplicationZoneRatio();
            }
        }

        /// <summary>
        /// called on every timer tick, to refresh the background image
        /// </summary>
        private void refreshImage()
        {
            //manual memory management
            if (this.BackgroundImage != null)
            {
                this.BackgroundImage.Dispose();
                this.BackgroundImage = null;
            }

            //hopefully unnecessary try-catch
            try
            {
                //creates image of duplication zone and sets it to be the background image
                img = new Bitmap(x_size, y_size);
                graphics = Graphics.FromImage(img as Image);
                graphics.CopyFromScreen(x_loc, y_loc, 0, 0, new Size(x_size, y_size));
                this.BackgroundImage = (Image)img;
            }
            catch (Exception ex)   //I can't think of a reason for exception, but we shall see
            {
                MessageBox.Show(ex.ToString()); ;
            }

            //force background to stay stretched
            this.BackgroundImageLayout = ImageLayout.Stretch;

            //manual memory management
            graphics.Dispose();

        }

        /// <summary>
        /// called on every timer tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            refreshImage();
        }

        /// <summary>
        /// exit menu item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// begin or stop mirroring of duplication zone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void beginMirrorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if we are not mirroring, begin mirroring
            if (!mirroring)
            {
                //if ratio is enforced, enforce it
                if (ToolStripResizeToScale.Checked)
                {
                    scaleToDuplicationZoneRatio();
                }

                timer1.Start();
                beginMirrorToolStripMenuItem.Text = "Stop Mirror";
                mirroring = true;
                panel1.Visible = false;
                menuStrip1.BackColor = Color.Transparent;
            }
            //if we are mirroring, stop mirroring and put a panel in front of the last frame to show it is done
            else
            {
                timer1.Stop();
                beginMirrorToolStripMenuItem.Text = "Start Mirror";
                mirroring = false;
                panel1.Visible = true;
                menuStrip1.BackColor = SystemColors.Control;
            }
        }

        /// <summary>
        /// ensures that the form only reszes to proper ratios
        /// that respect the ratio of the duplication zone
        /// </summary>
        private void scaleToDuplicationZoneRatio()
        {
            //use ratio to compute height
            double ratio = Convert.ToDouble(y_size) / Convert.ToDouble(x_size);
            int new_height = Convert.ToInt16(Convert.ToDouble(this.Width) * ratio);
            this.Height = new_height;
        }


        /// <summary>
        /// resize form to proper ratio on resize if needed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (ToolStripResizeToScale.Checked == true)
                scaleToDuplicationZoneRatio();
        }

        /// <summary>
        /// opens second form to setup duplication zone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resizeMirrorRegionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Location = new Point(Properties.Settings.Default.x_loc, Properties.Settings.Default.y_loc);
            f2.Size = new Size(Properties.Settings.Default.x_size, Properties.Settings.Default.y_size);
            f2.Show();

            //add event handler
            f2.FormClosing += new FormClosingEventHandler(F2_Closing);
        }


        /// <summary>
        /// When the setup form is closing, this is called
        /// it grabs location/size data from the form and saves it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void F2_Closing(object sender, FormClosingEventArgs e)
        {
            x_size = ((Form)sender).Width;
            y_size = ((Form)sender).Height;
            x_loc = ((Form)sender).Location.X;
            y_loc = ((Form)sender).Location.Y;

            //save settings to my.settings equivalent
            Properties.Settings.Default.x_size = x_size;
            Properties.Settings.Default.y_size = y_size;
            Properties.Settings.Default.x_loc = x_loc;
            Properties.Settings.Default.y_loc = y_loc;
            Properties.Settings.Default.Save();

            //if ratio is enforced, enforce it
            if (ToolStripResizeToScale.Checked)
            {
                scaleToDuplicationZoneRatio();
            }
        }


        /// <summary>
        /// called when user changes refresh rate
        /// must change value in settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxRefreshRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.refresh_rate = Convert.ToInt16(ComboBoxRefreshRate.Text.ToString());
            Properties.Settings.Default.Save();

            timer1.Interval = (1000) / Convert.ToInt16(ComboBoxRefreshRate.Text);

        }


        /// <summary>
        /// checkbox to signify if the main form should scale to the same ratio as the duplication zone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripResizeToScale_Click(object sender, EventArgs e)
        {
            //boolean flip
            ToolStripResizeToScale.Checked = !ToolStripResizeToScale.Checked;

            //apply setting now
            if (ToolStripResizeToScale.Checked)
            {
                scaleToDuplicationZoneRatio();
            }

            //write state to settings
            Properties.Settings.Default.resize_to_ratio = ToolStripResizeToScale.Checked;
            Properties.Settings.Default.Save();
        }


        /// <summary>
        /// About messagebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cDupe allows you to magnify a region of a screen. It was developed as a simple solution to enlarge the World of Tanks minimap onto a second monitor. Enjoy!", "MIT License - csm10495");
        }
    }
}
