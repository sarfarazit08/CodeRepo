namespace WINTEXT2MP3
{
    partial class TEXT2MP3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TEXT2MP3));
            this.txtBoxLarge = new System.Windows.Forms.RichTextBox();
            this.openFileDialogControl = new System.Windows.Forms.OpenFileDialog();
            this.trackBarSpeechRate = new System.Windows.Forms.TrackBar();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.BtnResume = new System.Windows.Forms.Button();
            this.BtnPitch = new System.Windows.Forms.Button();
            this.BtnSound = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnPause = new System.Windows.Forms.Button();
            this.ComboBoxVoices = new System.Windows.Forms.ComboBox();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnVoices = new System.Windows.Forms.Button();
            this.lblSpeechStatus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBlogSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeechRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxLarge
            // 
            this.txtBoxLarge.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLarge.Location = new System.Drawing.Point(6, 27);
            this.txtBoxLarge.Name = "txtBoxLarge";
            this.txtBoxLarge.Size = new System.Drawing.Size(658, 204);
            this.txtBoxLarge.TabIndex = 5;
            this.txtBoxLarge.Text = "";
            // 
            // openFileDialogControl
            // 
            this.openFileDialogControl.FileName = "openFileDialog1";
            // 
            // trackBarSpeechRate
            // 
            this.trackBarSpeechRate.AutoSize = false;
            this.trackBarSpeechRate.LargeChange = 2;
            this.trackBarSpeechRate.Location = new System.Drawing.Point(468, 271);
            this.trackBarSpeechRate.Maximum = 5;
            this.trackBarSpeechRate.Minimum = -5;
            this.trackBarSpeechRate.Name = "trackBarSpeechRate";
            this.trackBarSpeechRate.Size = new System.Drawing.Size(195, 20);
            this.trackBarSpeechRate.TabIndex = 13;
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.AutoSize = false;
            this.trackBarVolume.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.trackBarVolume.LargeChange = 2;
            this.trackBarVolume.Location = new System.Drawing.Point(468, 239);
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(195, 20);
            this.trackBarVolume.TabIndex = 15;
            this.trackBarVolume.Value = 5;
            // 
            // BtnResume
            // 
            this.BtnResume.BackgroundImage = global::WINTEXT2MP3.Properties.Resources.Resume;
            this.BtnResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnResume.ForeColor = System.Drawing.Color.Transparent;
            this.BtnResume.Location = new System.Drawing.Point(78, 239);
            this.BtnResume.Name = "BtnResume";
            this.BtnResume.Size = new System.Drawing.Size(30, 30);
            this.BtnResume.TabIndex = 20;
            this.BtnResume.UseVisualStyleBackColor = true;
            this.BtnResume.Click += new System.EventHandler(this.BtnResume_Click);
            // 
            // BtnPitch
            // 
            this.BtnPitch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPitch.BackgroundImage = global::WINTEXT2MP3.Properties.Resources.Pitch;
            this.BtnPitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPitch.ForeColor = System.Drawing.Color.Transparent;
            this.BtnPitch.Location = new System.Drawing.Point(447, 271);
            this.BtnPitch.Name = "BtnPitch";
            this.BtnPitch.Size = new System.Drawing.Size(20, 20);
            this.BtnPitch.TabIndex = 19;
            this.BtnPitch.UseVisualStyleBackColor = false;
            // 
            // BtnSound
            // 
            this.BtnSound.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnSound.BackgroundImage = global::WINTEXT2MP3.Properties.Resources.Volume;
            this.BtnSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSound.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSound.Location = new System.Drawing.Point(447, 239);
            this.BtnSound.Name = "BtnSound";
            this.BtnSound.Size = new System.Drawing.Size(20, 20);
            this.BtnSound.TabIndex = 18;
            this.BtnSound.UseVisualStyleBackColor = false;
            // 
            // BtnStop
            // 
            this.BtnStop.BackgroundImage = global::WINTEXT2MP3.Properties.Resources.stop;
            this.BtnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStop.ForeColor = System.Drawing.Color.Transparent;
            this.BtnStop.Location = new System.Drawing.Point(114, 239);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(30, 30);
            this.BtnStop.TabIndex = 8;
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnPause
            // 
            this.BtnPause.BackgroundImage = global::WINTEXT2MP3.Properties.Resources.Pause;
            this.BtnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPause.ForeColor = System.Drawing.Color.Transparent;
            this.BtnPause.Location = new System.Drawing.Point(42, 239);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(30, 30);
            this.BtnPause.TabIndex = 7;
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // ComboBoxVoices
            // 
            this.ComboBoxVoices.FormattingEnabled = true;            
            this.ComboBoxVoices.Location = new System.Drawing.Point(500, 3);
            this.ComboBoxVoices.Name = "ComboBoxVoices";
            this.ComboBoxVoices.Size = new System.Drawing.Size(163, 21);
            this.ComboBoxVoices.TabIndex = 22;
            this.ComboBoxVoices.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVoices_SelectedIndexChanged);
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackgroundImage = global::WINTEXT2MP3.Properties.Resources.Play;
            this.BtnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlay.ForeColor = System.Drawing.Color.Transparent;
            this.BtnPlay.Location = new System.Drawing.Point(6, 239);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(30, 30);
            this.BtnPlay.TabIndex = 0;
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnVoices
            // 
            this.BtnVoices.BackgroundImage = global::WINTEXT2MP3.Properties.Resources.Voices;
            this.BtnVoices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVoices.Enabled = false;
            this.BtnVoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoices.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnVoices.Location = new System.Drawing.Point(468, 1);
            this.BtnVoices.Name = "BtnVoices";
            this.BtnVoices.Size = new System.Drawing.Size(25, 23);
            this.BtnVoices.TabIndex = 23;
            this.BtnVoices.UseVisualStyleBackColor = true;
            // 
            // lblSpeechStatus
            // 
            this.lblSpeechStatus.AutoSize = true;
            this.lblSpeechStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSpeechStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeechStatus.Location = new System.Drawing.Point(157, 244);
            this.lblSpeechStatus.Name = "lblSpeechStatus";
            this.lblSpeechStatus.Size = new System.Drawing.Size(0, 19);
            this.lblSpeechStatus.TabIndex = 24;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::WINTEXT2MP3.Properties.Resources.file;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::WINTEXT2MP3.Properties.Resources.save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::WINTEXT2MP3.Properties.Resources.Exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBlogSiteToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // viewBlogSiteToolStripMenuItem
            // 
            this.viewBlogSiteToolStripMenuItem.Image = global::WINTEXT2MP3.Properties.Resources.Website;
            this.viewBlogSiteToolStripMenuItem.Name = "viewBlogSiteToolStripMenuItem";
            this.viewBlogSiteToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.viewBlogSiteToolStripMenuItem.Text = "View Blog Site";
            this.viewBlogSiteToolStripMenuItem.Click += new System.EventHandler(this.viewBlogSiteToolStripMenuItem_Click);
            // 
            // TEXT2MP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(669, 313);
            this.Controls.Add(this.lblSpeechStatus);
            this.Controls.Add(this.BtnVoices);
            this.Controls.Add(this.ComboBoxVoices);
            this.Controls.Add(this.BtnResume);
            this.Controls.Add(this.BtnPitch);
            this.Controls.Add(this.BtnSound);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.trackBarSpeechRate);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.txtBoxLarge);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TEXT2MP3";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Reader";
            this.Load += new System.EventHandler(this.TEXT2MP3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeechRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.RichTextBox txtBoxLarge;
        private System.Windows.Forms.OpenFileDialog openFileDialogControl;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.TrackBar trackBarSpeechRate;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button BtnSound;
        private System.Windows.Forms.Button BtnPitch;
        private System.Windows.Forms.Button BtnResume;
        private System.Windows.Forms.ComboBox ComboBoxVoices;        
        private System.Windows.Forms.Button BtnVoices;
        private System.Windows.Forms.Label lblSpeechStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewBlogSiteToolStripMenuItem;
    }
}

