namespace App.Forms
{
    partial class ConnectPeer
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
            this.peerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.addPeerPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // peerName
            // 
            this.peerName.Location = new System.Drawing.Point(161, 12);
            this.peerName.Name = "peerName";
            this.peerName.Size = new System.Drawing.Size(385, 20);
            this.peerName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(462, 38);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(84, 45);
            this.register.TabIndex = 5;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.RegisterClick);
            // 
            // addPeerPanel
            // 
            this.addPeerPanel.Location = new System.Drawing.Point(16, 85);
            this.addPeerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.addPeerPanel.Name = "addPeerPanel";
            this.addPeerPanel.Size = new System.Drawing.Size(530, 80);
            this.addPeerPanel.TabIndex = 6;
            // 
            // ConnectPeer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 177);
            this.Controls.Add(this.addPeerPanel);
            this.Controls.Add(this.register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.peerName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectPeer";
            this.Text = "Connect Peer";
            this.Load += new System.EventHandler(this.ConnectPeerLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox peerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Panel addPeerPanel;
    }
}