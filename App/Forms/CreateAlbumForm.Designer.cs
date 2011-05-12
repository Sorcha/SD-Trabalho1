namespace App.Forms
{
    partial class CreateAlbumForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.albumName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.musicList = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // albumName
            // 
            this.albumName.Location = new System.Drawing.Point(10, 30);
            this.albumName.Name = "albumName";
            this.albumName.Size = new System.Drawing.Size(504, 20);
            this.albumName.TabIndex = 1;
            this.albumName.TextChanged += new System.EventHandler(this.albumName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Music";
            // 
            // musicList
            // 
            this.musicList.FormattingEnabled = true;
            this.musicList.Location = new System.Drawing.Point(13, 84);
            this.musicList.Name = "musicList";
            this.musicList.Size = new System.Drawing.Size(501, 160);
            this.musicList.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(461, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 256);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.musicList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.albumName);
            this.Controls.Add(this.label1);
            this.Name = "CreateAlbumForm";
            this.Text = "CreateAlbumForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox albumName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox musicList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}