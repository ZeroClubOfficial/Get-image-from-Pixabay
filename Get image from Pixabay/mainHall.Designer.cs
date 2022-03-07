namespace Get_image_from_Pixabay
{
    partial class mainHall
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
            this.word = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // word
            // 
            this.word.Location = new System.Drawing.Point(12, 483);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(466, 20);
            this.word.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(484, 481);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(75, 23);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "Get";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // picture
            // 
            this.picture.ImageLocation = "";
            this.picture.Location = new System.Drawing.Point(12, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(547, 400);
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 418);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(547, 57);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "You can use your own key API in this link bellow\nhttps://pixabay.com/api/docs/";
            // 
            // mainHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 516);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.word);
            this.Name = "mainHall";
            this.ShowIcon = false;
            this.Text = "Pixabay Picture";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox word;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

