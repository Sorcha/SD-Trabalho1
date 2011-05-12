namespace App
{
    partial class MusicDatabaseViewer
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
            this.albunsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.albumViewer = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // albunsList
            // 
            this.albunsList.FormattingEnabled = true;
            this.albunsList.Location = new System.Drawing.Point(12, 42);
            this.albunsList.Name = "albunsList";
            this.albunsList.Size = new System.Drawing.Size(180, 264);
            this.albunsList.TabIndex = 0;
            this.albunsList.SelectedIndexChanged += new System.EventHandler(this.AlbunsListSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Albuns";
            // 
            // albumViewer
            // 
            this.albumViewer.Location = new System.Drawing.Point(214, 9);
            this.albumViewer.Name = "albumViewer";
            this.albumViewer.Size = new System.Drawing.Size(481, 297);
            this.albumViewer.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MusicDatabaseViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 323);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.albumViewer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.albunsList);
            this.Name = "MusicDatabaseViewer";
            this.Text = "MusicDatabaseViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox albunsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel albumViewer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}