namespace Rhyme.Tools.Services.Socket
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
			this.gbTest1 = new System.Windows.Forms.GroupBox();
			this.gbTest2 = new System.Windows.Forms.GroupBox();
			this.txtMultiThreadCount = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnStartMulti = new System.Windows.Forms.Button();
			this.btnStopMulti = new System.Windows.Forms.Button();
			this.txtMultiIp = new System.Windows.Forms.TextBox();
			this.txtMultiPort = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.gbTest1.SuspendLayout();
			this.gbTest2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(131, 17);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(64, 25);
			this.btnConnect.TabIndex = 0;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(97, 46);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(64, 25);
			this.btnSend.TabIndex = 0;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// txtSend
			// 
			this.txtSend.Location = new System.Drawing.Point(6, 48);
			this.txtSend.Name = "txtSend";
			this.txtSend.Size = new System.Drawing.Size(86, 20);
			this.txtSend.TabIndex = 1;
			this.txtSend.Text = "test";
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(6, 19);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(86, 20);
			this.txtAddress.TabIndex = 2;
			this.txtAddress.Text = "192.168.0.40";
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(97, 19);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(30, 20);
			this.txtPort.TabIndex = 3;
			this.txtPort.Text = "6125";
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(167, 48);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(64, 25);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// gbTest1
			// 
			this.gbTest1.Controls.Add(this.txtAddress);
			this.gbTest1.Controls.Add(this.btnConnect);
			this.gbTest1.Controls.Add(this.btnClose);
			this.gbTest1.Controls.Add(this.btnSend);
			this.gbTest1.Controls.Add(this.txtPort);
			this.gbTest1.Controls.Add(this.txtSend);
			this.gbTest1.Location = new System.Drawing.Point(12, 12);
			this.gbTest1.Name = "gbTest1";
			this.gbTest1.Size = new System.Drawing.Size(242, 85);
			this.gbTest1.TabIndex = 5;
			this.gbTest1.TabStop = false;
			this.gbTest1.Text = "Connect test";
			// 
			// gbTest2
			// 
			this.gbTest2.Controls.Add(this.label2);
			this.gbTest2.Controls.Add(this.txtMultiPort);
			this.gbTest2.Controls.Add(this.txtMultiIp);
			this.gbTest2.Controls.Add(this.btnStopMulti);
			this.gbTest2.Controls.Add(this.btnStartMulti);
			this.gbTest2.Controls.Add(this.label1);
			this.gbTest2.Controls.Add(this.txtMultiThreadCount);
			this.gbTest2.Location = new System.Drawing.Point(12, 103);
			this.gbTest2.Name = "gbTest2";
			this.gbTest2.Size = new System.Drawing.Size(335, 85);
			this.gbTest2.TabIndex = 6;
			this.gbTest2.TabStop = false;
			this.gbTest2.Text = "Connect / close test";
			// 
			// txtMultiThreadCount
			// 
			this.txtMultiThreadCount.Location = new System.Drawing.Point(106, 19);
			this.txtMultiThreadCount.Name = "txtMultiThreadCount";
			this.txtMultiThreadCount.Size = new System.Drawing.Size(136, 20);
			this.txtMultiThreadCount.TabIndex = 0;
			this.txtMultiThreadCount.Text = "10";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Thread count :";
			// 
			// btnStartMulti
			// 
			this.btnStartMulti.Location = new System.Drawing.Point(248, 19);
			this.btnStartMulti.Name = "btnStartMulti";
			this.btnStartMulti.Size = new System.Drawing.Size(75, 23);
			this.btnStartMulti.TabIndex = 2;
			this.btnStartMulti.Text = "Start";
			this.btnStartMulti.UseVisualStyleBackColor = true;
			this.btnStartMulti.Click += new System.EventHandler(this.btnStartMulti_Click);
			// 
			// btnStopMulti
			// 
			this.btnStopMulti.Location = new System.Drawing.Point(248, 48);
			this.btnStopMulti.Name = "btnStopMulti";
			this.btnStopMulti.Size = new System.Drawing.Size(75, 23);
			this.btnStopMulti.TabIndex = 3;
			this.btnStopMulti.Text = "Stop";
			this.btnStopMulti.UseVisualStyleBackColor = true;
			this.btnStopMulti.Click += new System.EventHandler(this.btnStopMulti_Click);
			// 
			// txtMultiIp
			// 
			this.txtMultiIp.Location = new System.Drawing.Point(106, 45);
			this.txtMultiIp.Name = "txtMultiIp";
			this.txtMultiIp.Size = new System.Drawing.Size(89, 20);
			this.txtMultiIp.TabIndex = 4;
			this.txtMultiIp.Text = "127.0.0.1";
			// 
			// txtMultiPort
			// 
			this.txtMultiPort.Location = new System.Drawing.Point(201, 45);
			this.txtMultiPort.Name = "txtMultiPort";
			this.txtMultiPort.Size = new System.Drawing.Size(41, 20);
			this.txtMultiPort.TabIndex = 5;
			this.txtMultiPort.Text = "1843";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(37, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Endpoint :";
			// 
			// frmSocket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 204);
			this.Controls.Add(this.gbTest2);
			this.Controls.Add(this.gbTest1);
			this.Name = "frmSocket";
			this.Text = "Socket Tester";
			this.gbTest1.ResumeLayout(false);
			this.gbTest1.PerformLayout();
			this.gbTest2.ResumeLayout(false);
			this.gbTest2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox txtSend;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.GroupBox gbTest1;
		private System.Windows.Forms.GroupBox gbTest2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMultiPort;
		private System.Windows.Forms.TextBox txtMultiIp;
		private System.Windows.Forms.Button btnStopMulti;
		private System.Windows.Forms.Button btnStartMulti;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMultiThreadCount;
	}
}