﻿namespace App
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
            this.button1 = new System.Windows.Forms.Button();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.responsesTab = new System.Windows.Forms.TabControl();
            this.label3 = new System.Windows.Forms.Label();
            this.remoteRequests = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // availablePeersList
            // 
            this.availablePeersList.FormattingEnabled = true;
            this.availablePeersList.Location = new System.Drawing.Point(578, 38);
            this.availablePeersList.Name = "availablePeersList";
            this.availablePeersList.Size = new System.Drawing.Size(178, 225);
            this.availablePeersList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Peers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "SEARCH BITCH";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // searchTB
            // 
            this.searchTB.Location = new System.Drawing.Point(15, 29);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(462, 20);
            this.searchTB.TabIndex = 4;
            // 
            // responsesTab
            // 
            this.responsesTab.Location = new System.Drawing.Point(15, 63);
            this.responsesTab.Name = "responsesTab";
            this.responsesTab.SelectedIndex = 0;
            this.responsesTab.Size = new System.Drawing.Size(543, 200);
            this.responsesTab.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Remote Requests";
            // 
            // remoteRequests
            // 
            this.remoteRequests.FormattingEnabled = true;
            this.remoteRequests.Location = new System.Drawing.Point(15, 296);
            this.remoteRequests.Name = "remoteRequests";
            this.remoteRequests.Size = new System.Drawing.Size(741, 186);
            this.remoteRequests.TabIndex = 8;
            // 
            // MusicWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 492);
            this.Controls.Add(this.remoteRequests);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.responsesTab);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.availablePeersList);
            this.Name = "MusicWindow";
            this.Text = "Music Window";
            this.Load += new System.EventHandler(this.MusicWindowLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox availablePeersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.TabControl responsesTab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox remoteRequests;
    }
}