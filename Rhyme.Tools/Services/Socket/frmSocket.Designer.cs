namespace RhymeLoginTool.Z_Socket
{
	partial class frmSocket
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
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnSend = new System.Windows.Forms.Button();
			this.txtSend = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(158, 10);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 23);
			this.btnConnect.TabIndex = 0;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(118, 37);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 0;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// txtSend
			// 
			this.txtSend.Location = new System.Drawing.Point(12, 39);
			this.txtSend.Name = "txtSend";
			this.txtSend.Size = new System.Drawing.Size(100, 21);
			this.txtSend.TabIndex = 1;
			this.txtSend.Text = "test";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(12, 12);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(100, 21);
			this.txtAddress.TabIndex = 2;
			this.txtAddress.Text = "192.168.0.40";
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(118, 12);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(34, 21);
			this.txtPort.TabIndex = 3;
			this.txtPort.Text = "6125";
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(199, 39);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// frmSocket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtSend);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.btnConnect);
			this.Name = "frmSocket";
			this.Text = "frmSocket";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox txtSend;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Button btnClose;
	}
}