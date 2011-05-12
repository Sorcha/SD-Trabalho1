namespace App
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
            this.peerAddress = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peerName
            // 
            this.peerName.Location = new System.Drawing.Point(161, 12);
            this.peerName.Name = "peerName";
            this.peerName.Size = new System.Drawing.Size(385, 20);
            this.peerName.TabIndex = 0;
            // 
            // peerAddress
            // 
            this.peerAddress.Location = new System.Drawing.Point(163, 94);
            this.peerAddress.Name = "peerAddress";
            this.peerAddress.Size = new System.Drawing.Size(385, 20);
            this.peerAddress.TabIndex = 1;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(464, 120);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(84, 45);
            this.connect.TabIndex = 2;
            this.connect.Text = "Connect BIATCH";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.ConnectClick);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Connect-to-Peer";
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
            // ConnectPeer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 177);
            this.Controls.Add(this.register);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.peerAddress);
            this.Controls.Add(this.peerName);
            this.Name = "ConnectPeer";
            this.Text = "Connect Peer";
            this.Load += new System.EventHandler(this.ConnectPeerLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox peerName;
        private System.Windows.Forms.TextBox peerAddress;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button register;
    }
}