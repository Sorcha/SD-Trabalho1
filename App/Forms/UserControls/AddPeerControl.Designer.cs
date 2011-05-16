namespace App.Forms.UserControls
{
    partial class AddPeerControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.peerAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Connect-to-Peer";
            // 
            // connect
            // 
            this.connect.Enabled = false;
            this.connect.Location = new System.Drawing.Point(453, 39);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(84, 45);
            this.connect.TabIndex = 6;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.ConnectClick);
            // 
            // peerAddress
            // 
            this.peerAddress.Location = new System.Drawing.Point(152, 13);
            this.peerAddress.Name = "peerAddress";
            this.peerAddress.Size = new System.Drawing.Size(385, 20);
            this.peerAddress.TabIndex = 5;
            // 
            // AddPeerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.peerAddress);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AddPeerControl";
            this.Size = new System.Drawing.Size(547, 94);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.TextBox peerAddress;

    }
}
