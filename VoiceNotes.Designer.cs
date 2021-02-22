namespace SeoulHacks2020Application
{
    partial class VoiceNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoiceNotes));
            this.animatedMicrophone = new System.Windows.Forms.PictureBox();
            this.stillMicrophone = new System.Windows.Forms.PictureBox();
            this.outputtedText = new System.Windows.Forms.RichTextBox();
            this.saveNote = new System.Windows.Forms.Button();
            this.exitBox = new System.Windows.Forms.PictureBox();
            this.minimizeBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.informationButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.animatedMicrophone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stillMicrophone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationButton)).BeginInit();
            this.SuspendLayout();
            // 
            // animatedMicrophone
            // 
            this.animatedMicrophone.BackColor = System.Drawing.Color.Transparent;
            this.animatedMicrophone.Image = ((System.Drawing.Image)(resources.GetObject("animatedMicrophone.Image")));
            this.animatedMicrophone.Location = new System.Drawing.Point(1, 88);
            this.animatedMicrophone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.animatedMicrophone.Name = "animatedMicrophone";
            this.animatedMicrophone.Size = new System.Drawing.Size(291, 297);
            this.animatedMicrophone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.animatedMicrophone.TabIndex = 0;
            this.animatedMicrophone.TabStop = false;
            this.animatedMicrophone.Click += new System.EventHandler(this.animatedMicrophone_Click);
            // 
            // stillMicrophone
            // 
            this.stillMicrophone.BackColor = System.Drawing.Color.Transparent;
            this.stillMicrophone.Image = ((System.Drawing.Image)(resources.GetObject("stillMicrophone.Image")));
            this.stillMicrophone.Location = new System.Drawing.Point(1, 88);
            this.stillMicrophone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stillMicrophone.Name = "stillMicrophone";
            this.stillMicrophone.Size = new System.Drawing.Size(291, 297);
            this.stillMicrophone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.stillMicrophone.TabIndex = 1;
            this.stillMicrophone.TabStop = false;
            this.stillMicrophone.Click += new System.EventHandler(this.stillMicrophone_Click);
            // 
            // outputtedText
            // 
            this.outputtedText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(213)))), ((int)(((byte)(92)))));
            this.outputtedText.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputtedText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(48)))), ((int)(((byte)(6)))));
            this.outputtedText.Location = new System.Drawing.Point(383, 88);
            this.outputtedText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outputtedText.Name = "outputtedText";
            this.outputtedText.Size = new System.Drawing.Size(312, 298);
            this.outputtedText.TabIndex = 3;
            this.outputtedText.Text = "";
            // 
            // saveNote
            // 
            this.saveNote.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNote.Location = new System.Drawing.Point(295, 179);
            this.saveNote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveNote.Name = "saveNote";
            this.saveNote.Size = new System.Drawing.Size(84, 32);
            this.saveNote.TabIndex = 22;
            this.saveNote.Text = "Save Note";
            this.saveNote.UseVisualStyleBackColor = true;
            this.saveNote.Click += new System.EventHandler(this.saveNote_Click);
            // 
            // exitBox
            // 
            this.exitBox.Image = ((System.Drawing.Image)(resources.GetObject("exitBox.Image")));
            this.exitBox.Location = new System.Drawing.Point(669, 1);
            this.exitBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitBox.Name = "exitBox";
            this.exitBox.Size = new System.Drawing.Size(25, 23);
            this.exitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBox.TabIndex = 24;
            this.exitBox.TabStop = false;
            this.exitBox.Click += new System.EventHandler(this.exitBox_Click);
            // 
            // minimizeBox
            // 
            this.minimizeBox.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBox.Image")));
            this.minimizeBox.Location = new System.Drawing.Point(639, 1);
            this.minimizeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.Size = new System.Drawing.Size(25, 23);
            this.minimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeBox.TabIndex = 25;
            this.minimizeBox.TabStop = false;
            this.minimizeBox.Click += new System.EventHandler(this.minimizeBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(127)))), ((int)(((byte)(45)))));
            this.panel1.Location = new System.Drawing.Point(237, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 23);
            this.panel1.TabIndex = 26;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1, 1);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // informationButton
            // 
            this.informationButton.Image = ((System.Drawing.Image)(resources.GetObject("informationButton.Image")));
            this.informationButton.Location = new System.Drawing.Point(610, 1);
            this.informationButton.Margin = new System.Windows.Forms.Padding(2);
            this.informationButton.Name = "informationButton";
            this.informationButton.Size = new System.Drawing.Size(25, 23);
            this.informationButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.informationButton.TabIndex = 27;
            this.informationButton.TabStop = false;
            this.informationButton.Click += new System.EventHandler(this.informationButton_Click);
            // 
            // VoiceNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(127)))), ((int)(((byte)(45)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(695, 418);
            this.Controls.Add(this.informationButton);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.minimizeBox);
            this.Controls.Add(this.exitBox);
            this.Controls.Add(this.saveNote);
            this.Controls.Add(this.outputtedText);
            this.Controls.Add(this.stillMicrophone);
            this.Controls.Add(this.animatedMicrophone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VoiceNotes";
            this.Text = "VideoNotes";
            ((System.ComponentModel.ISupportInitialize)(this.animatedMicrophone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stillMicrophone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox animatedMicrophone;
        private System.Windows.Forms.PictureBox stillMicrophone;
        private System.Windows.Forms.RichTextBox outputtedText;
        private System.Windows.Forms.Button saveNote;
        private System.Windows.Forms.PictureBox exitBox;
        private System.Windows.Forms.PictureBox minimizeBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox informationButton;
    }
}