namespace SeoulHacks2020Application
{
    partial class VideoLearn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoLearn));
            this.urlText = new System.Windows.Forms.TextBox();
            this.urlLink = new System.Windows.Forms.Label();
            this.notePadVideo = new System.Windows.Forms.RichTextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.exitBox = new System.Windows.Forms.PictureBox();
            this.minimizeBox = new System.Windows.Forms.PictureBox();
            this.resetVideo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.informationButton = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(40, 28);
            this.urlText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(424, 20);
            this.urlText.TabIndex = 3;
            // 
            // urlLink
            // 
            this.urlLink.AutoSize = true;
            this.urlLink.ForeColor = System.Drawing.Color.Maroon;
            this.urlLink.Location = new System.Drawing.Point(8, 30);
            this.urlLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.urlLink.Name = "urlLink";
            this.urlLink.Size = new System.Drawing.Size(29, 13);
            this.urlLink.TabIndex = 4;
            this.urlLink.Text = "URL";
            // 
            // notePadVideo
            // 
            this.notePadVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(213)))), ((int)(((byte)(92)))));
            this.notePadVideo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notePadVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(48)))), ((int)(((byte)(6)))));
            this.notePadVideo.Location = new System.Drawing.Point(604, 28);
            this.notePadVideo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.notePadVideo.Name = "notePadVideo";
            this.notePadVideo.Size = new System.Drawing.Size(220, 387);
            this.notePadVideo.TabIndex = 5;
            this.notePadVideo.Text = "";
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(468, 28);
            this.goButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(30, 20);
            this.goButton.TabIndex = 6;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(21, 55);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(578, 351);
            this.axVLCPlugin21.TabIndex = 8;
            // 
            // exitBox
            // 
            this.exitBox.Image = ((System.Drawing.Image)(resources.GetObject("exitBox.Image")));
            this.exitBox.Location = new System.Drawing.Point(799, 1);
            this.exitBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitBox.Name = "exitBox";
            this.exitBox.Size = new System.Drawing.Size(25, 23);
            this.exitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBox.TabIndex = 12;
            this.exitBox.TabStop = false;
            this.exitBox.Click += new System.EventHandler(this.exitBox_Click);
            // 
            // minimizeBox
            // 
            this.minimizeBox.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBox.Image")));
            this.minimizeBox.Location = new System.Drawing.Point(770, 1);
            this.minimizeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.Size = new System.Drawing.Size(25, 23);
            this.minimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeBox.TabIndex = 13;
            this.minimizeBox.TabStop = false;
            this.minimizeBox.Click += new System.EventHandler(this.minimizeBox_Click);
            // 
            // resetVideo
            // 
            this.resetVideo.Location = new System.Drawing.Point(503, 28);
            this.resetVideo.Name = "resetVideo";
            this.resetVideo.Size = new System.Drawing.Size(46, 20);
            this.resetVideo.TabIndex = 14;
            this.resetVideo.Text = "Reset";
            this.resetVideo.UseVisualStyleBackColor = true;
            this.resetVideo.Click += new System.EventHandler(this.resetVideo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 21);
            this.button1.TabIndex = 15;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(619, 417);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(61, 25);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // informationButton
            // 
            this.informationButton.Image = ((System.Drawing.Image)(resources.GetObject("informationButton.Image")));
            this.informationButton.Location = new System.Drawing.Point(741, 1);
            this.informationButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.informationButton.Name = "informationButton";
            this.informationButton.Size = new System.Drawing.Size(25, 23);
            this.informationButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.informationButton.TabIndex = 17;
            this.informationButton.TabStop = false;
            this.informationButton.Click += new System.EventHandler(this.informationButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1, 1);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.panel1.Location = new System.Drawing.Point(288, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 23);
            this.panel1.TabIndex = 27;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // VideoLearn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(823, 443);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.informationButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resetVideo);
            this.Controls.Add(this.minimizeBox);
            this.Controls.Add(this.exitBox);
            this.Controls.Add(this.axVLCPlugin21);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.notePadVideo);
            this.Controls.Add(this.urlLink);
            this.Controls.Add(this.urlText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VideoLearn";
            this.Text = "VideoLearn";
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label urlLink;
        private System.Windows.Forms.RichTextBox notePadVideo;
        private System.Windows.Forms.Button goButton;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private System.Windows.Forms.PictureBox exitBox;
        private System.Windows.Forms.PictureBox minimizeBox;
        private System.Windows.Forms.Button resetVideo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox informationButton;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
    }
}