namespace App
{
    partial class AlbumViewer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.musicList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.musicViewer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.albumName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // musicList
            // 
            this.musicList.FormattingEnabled = true;
            this.musicList.Location = new System.Drawing.Point(3, 68);
            this.musicList.Name = "musicList";
            this.musicList.Size = new System.Drawing.Size(149, 238);
            this.musicList.TabIndex = 0;
            this.musicList.SelectedIndexChanged += new System.EventHandler(this.musicList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Músicas";
            // 
            // musicViewer
            // 
            this.musicViewer.Location = new System.Drawing.Point(158, 13);
            this.musicViewer.Name = "musicViewer";
            this.musicViewer.Size = new System.Drawing.Size(227, 293);
            this.musicViewer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // albumName
            // 
            this.albumName.AutoSize = true;
            this.albumName.Location = new System.Drawing.Point(6, 26);
            this.albumName.Name = "albumName";
            this.albumName.Size = new System.Drawing.Size(47, 13);
            this.albumName.TabIndex = 4;
            this.albumName.Text = "Unkown";
            // 
            // AlbumViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.albumName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.musicViewer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.musicList);
            this.Name = "AlbumViewer";
            this.Size = new System.Drawing.Size(388, 306);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox musicList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel musicViewer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label albumName;
    }
}
