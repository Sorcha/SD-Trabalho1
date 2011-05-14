namespace App
{
    partial class MusicWindow
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
            this.availablePeersList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.responsesTab = new System.Windows.Forms.TabControl();
            this.label3 = new System.Windows.Forms.Label();
            this.remoteRequests = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // availablePeersList
            // 
            this.availablePeersList.FormattingEnabled = true;
            this.availablePeersList.Location = new System.Drawing.Point(578, 59);
            this.availablePeersList.Name = "availablePeersList";
            this.availablePeersList.Size = new System.Drawing.Size(178, 225);
            this.availablePeersList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Peers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(483, 41);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 37);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(15, 50);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(462, 20);
            this.searchTB.TabIndex = 4;
            // 
            // responsesTab
            // 
            this.responsesTab.Location = new System.Drawing.Point(15, 84);
            this.responsesTab.Name = "responsesTab";
            this.responsesTab.SelectedIndex = 0;
            this.responsesTab.Size = new System.Drawing.Size(543, 200);
            this.responsesTab.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Remote Requests";
            // 
            // remoteRequests
            // 
            this.remoteRequests.FormattingEnabled = true;
            this.remoteRequests.Location = new System.Drawing.Point(15, 317);
            this.remoteRequests.Name = "remoteRequests";
            this.remoteRequests.Size = new System.Drawing.Size(741, 186);
            this.remoteRequests.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDatabaseToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewDatabaseToolStripMenuItem
            // 
            this.viewDatabaseToolStripMenuItem.Name = "viewDatabaseToolStripMenuItem";
            this.viewDatabaseToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.viewDatabaseToolStripMenuItem.Text = "View Database";
            this.viewDatabaseToolStripMenuItem.Click += new System.EventHandler(this.ViewDatabaseToolStripMenuItemClick);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItemClick);
            // 
            // MusicWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 515);
            this.Controls.Add(this.remoteRequests);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.responsesTab);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.availablePeersList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MusicWindow";
            this.Text = "Music Window";
            this.Load += new System.EventHandler(this.MusicWindowLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox availablePeersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.TabControl responsesTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox remoteRequests;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}