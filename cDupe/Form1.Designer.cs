namespace cDupe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeMirrorRegionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beginMirrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripResizeToScale = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripFollowMouse = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboBoxRefreshRate = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(651, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginMirrorToolStripMenuItem,
            this.refreshSpeedToolStripMenuItem,
            this.toolStripSeparator2,
            this.resizeMirrorRegionToolStripMenuItem,
            this.toolStripSeparator3,
            this.ToolStripResizeToScale,
            this.ToolStripFollowMouse,
            this.toolStripSeparator4,
            this.AboutToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // resizeMirrorRegionToolStripMenuItem
            // 
            this.resizeMirrorRegionToolStripMenuItem.Name = "resizeMirrorRegionToolStripMenuItem";
            this.resizeMirrorRegionToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.resizeMirrorRegionToolStripMenuItem.Text = "Resize Mirror Region";
            this.resizeMirrorRegionToolStripMenuItem.Click += new System.EventHandler(this.resizeMirrorRegionToolStripMenuItem_Click);
            // 
            // beginMirrorToolStripMenuItem
            // 
            this.beginMirrorToolStripMenuItem.Name = "beginMirrorToolStripMenuItem";
            this.beginMirrorToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.beginMirrorToolStripMenuItem.Text = "Start Mirror";
            this.beginMirrorToolStripMenuItem.Click += new System.EventHandler(this.beginMirrorToolStripMenuItem_Click);
            // 
            // ToolStripResizeToScale
            // 
            this.ToolStripResizeToScale.Checked = true;
            this.ToolStripResizeToScale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripResizeToScale.Name = "ToolStripResizeToScale";
            this.ToolStripResizeToScale.Size = new System.Drawing.Size(199, 22);
            this.ToolStripResizeToScale.Text = "Resize to Scale";
            this.ToolStripResizeToScale.Click += new System.EventHandler(this.ToolStripResizeToScale_Click);
            // 
            // ToolStripFollowMouse
            // 
            this.ToolStripFollowMouse.Name = "ToolStripFollowMouse";
            this.ToolStripFollowMouse.Size = new System.Drawing.Size(199, 22);
            this.ToolStripFollowMouse.Text = "Follow Mouse";
            this.ToolStripFollowMouse.Click += new System.EventHandler(this.ToolStripFollowMouse_Click);
            // 
            // refreshSpeedToolStripMenuItem
            // 
            this.refreshSpeedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComboBoxRefreshRate,
            this.toolStripSeparator1,
            this.toolStripMenuItem1});
            this.refreshSpeedToolStripMenuItem.Name = "refreshSpeedToolStripMenuItem";
            this.refreshSpeedToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.refreshSpeedToolStripMenuItem.Text = "Refresh Rate";
            // 
            // ComboBoxRefreshRate
            // 
            this.ComboBoxRefreshRate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ComboBoxRefreshRate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxRefreshRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxRefreshRate.Name = "ComboBoxRefreshRate";
            this.ComboBoxRefreshRate.Size = new System.Drawing.Size(121, 23);
            this.ComboBoxRefreshRate.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRefreshRate_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItem1.Text = "Refresh per second";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 493);
            this.panel1.TabIndex = 3;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(196, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(196, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(196, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(196, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "cDupe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem beginMirrorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshSpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripResizeToScale;
        private System.Windows.Forms.ToolStripMenuItem resizeMirrorRegionToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox ComboBoxRefreshRate;
        private System.Windows.Forms.ToolStripMenuItem ToolStripFollowMouse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

