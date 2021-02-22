namespace SeoulHacks2020Application
{
    partial class Flashcard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flashcard));
            this.FlashcardDefinition = new System.Windows.Forms.RichTextBox();
            this.FlashcardTerm = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.term = new System.Windows.Forms.Label();
            this.definition = new System.Windows.Forms.Label();
            this.exitBox = new System.Windows.Forms.PictureBox();
            this.minimizeBox = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.informationButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationButton)).BeginInit();
            this.SuspendLayout();
            // 
            // FlashcardDefinition
            // 
            this.FlashcardDefinition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlashcardDefinition.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlashcardDefinition.Location = new System.Drawing.Point(236, 83);
            this.FlashcardDefinition.Name = "FlashcardDefinition";
            this.FlashcardDefinition.Size = new System.Drawing.Size(302, 258);
            this.FlashcardDefinition.TabIndex = 0;
            this.FlashcardDefinition.Text = "";
            // 
            // FlashcardTerm
            // 
            this.FlashcardTerm.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlashcardTerm.Location = new System.Drawing.Point(12, 168);
            this.FlashcardTerm.Name = "FlashcardTerm";
            this.FlashcardTerm.Size = new System.Drawing.Size(191, 26);
            this.FlashcardTerm.TabIndex = 1;
            this.FlashcardTerm.Text = "";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(236, 347);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // term
            // 
            this.term.AutoSize = true;
            this.term.Location = new System.Drawing.Point(78, 152);
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(62, 13);
            this.term.TabIndex = 3;
            this.term.Text = "KEY TERM";
            // 
            // definition
            // 
            this.definition.AutoSize = true;
            this.definition.Location = new System.Drawing.Point(339, 67);
            this.definition.Name = "definition";
            this.definition.Size = new System.Drawing.Size(68, 13);
            this.definition.TabIndex = 4;
            this.definition.Text = "DEFINITION";
            // 
            // exitBox
            // 
            this.exitBox.Image = ((System.Drawing.Image)(resources.GetObject("exitBox.Image")));
            this.exitBox.Location = new System.Drawing.Point(670, 0);
            this.exitBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitBox.Name = "exitBox";
            this.exitBox.Size = new System.Drawing.Size(25, 23);
            this.exitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBox.TabIndex = 13;
            this.exitBox.TabStop = false;
            this.exitBox.Click += new System.EventHandler(this.exitBox_Click);
            // 
            // minimizeBox
            // 
            this.minimizeBox.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBox.Image")));
            this.minimizeBox.Location = new System.Drawing.Point(641, 0);
            this.minimizeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.Size = new System.Drawing.Size(25, 23);
            this.minimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeBox.TabIndex = 14;
            this.minimizeBox.TabStop = false;
            this.minimizeBox.Click += new System.EventHandler(this.minimizeBox_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 21);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(218)))), ((int)(((byte)(91)))));
            this.panel1.Location = new System.Drawing.Point(223, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 23);
            this.panel1.TabIndex = 28;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // informationButton
            // 
            this.informationButton.Image = ((System.Drawing.Image)(resources.GetObject("informationButton.Image")));
            this.informationButton.Location = new System.Drawing.Point(612, 0);
            this.informationButton.Margin = new System.Windows.Forms.Padding(2);
            this.informationButton.Name = "informationButton";
            this.informationButton.Size = new System.Drawing.Size(25, 23);
            this.informationButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.informationButton.TabIndex = 18;
            this.informationButton.TabStop = false;
            this.informationButton.Click += new System.EventHandler(this.informationButton_Click);
            // 
            // Flashcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(218)))), ((int)(((byte)(91)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(695, 418);
            this.Controls.Add(this.informationButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.minimizeBox);
            this.Controls.Add(this.exitBox);
            this.Controls.Add(this.definition);
            this.Controls.Add(this.term);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.FlashcardTerm);
            this.Controls.Add(this.FlashcardDefinition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Flashcard";
            this.Text = "Flashcard";
            ((System.ComponentModel.ISupportInitialize)(this.exitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox FlashcardDefinition;
        private System.Windows.Forms.RichTextBox FlashcardTerm;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label term;
        private System.Windows.Forms.Label definition;
        private System.Windows.Forms.PictureBox exitBox;
        private System.Windows.Forms.PictureBox minimizeBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox informationButton;
    }
}