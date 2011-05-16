namespace App.Forms
{
    partial class AddNewPeerForm
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
            this.addPeerPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // addPeerPanel
            // 
            this.addPeerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPeerPanel.Location = new System.Drawing.Point(0, 0);
            this.addPeerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.addPeerPanel.Name = "addPeerPanel";
            this.addPeerPanel.Size = new System.Drawing.Size(553, 105);
            this.addPeerPanel.TabIndex = 7;
            // 
            // AddNewPeerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 105);
            this.Controls.Add(this.addPeerPanel);
            this.Name = "AddNewPeerForm";
            this.Text = "AddNewPeerForm";
            this.Load += new System.EventHandler(this.AddNewPeerFormLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addPeerPanel;
    }
}