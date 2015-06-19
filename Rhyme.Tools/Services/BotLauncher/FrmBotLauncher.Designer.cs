namespace Rhyme.Tools.Services.BotLauncher
{
	partial class FrmBotLauncher
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
			this.btnStart = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.txtStartIndex = new System.Windows.Forms.TextBox();
			this.txtBotCount = new System.Windows.Forms.TextBox();
			this.cboBotType = new System.Windows.Forms.ComboBox();
			this.cboConnectType = new System.Windows.Forms.ComboBox();
			this.cboTableIndex = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(291, 170);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(70, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Path :";
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(109, 12);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(455, 20);
			this.txtPath.TabIndex = 2;
			this.txtPath.Text = "D:\\Rhyme\\dev\\src\\tools\\Rhyme.Bot\\Rhyme.Bot\\bin\\Debug\\Rhyme.Bot.exe";
			// 
			// txtIP
			// 
			this.txtIP.Enabled = false;
			this.txtIP.Location = new System.Drawing.Point(109, 92);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(100, 20);
			this.txtIP.TabIndex = 2;
			this.txtIP.Text = "127.0.0.1";
			// 
			// txtStartIndex
			// 
			this.txtStartIndex.Location = new System.Drawing.Point(109, 118);
			this.txtStartIndex.Name = "txtStartIndex";
			this.txtStartIndex.Size = new System.Drawing.Size(100, 20);
			this.txtStartIndex.TabIndex = 2;
			this.txtStartIndex.Text = "1";
			// 
			// txtBotCount
			// 
			this.txtBotCount.Location = new System.Drawing.Point(109, 144);
			this.txtBotCount.Name = "txtBotCount";
			this.txtBotCount.Size = new System.Drawing.Size(100, 20);
			this.txtBotCount.TabIndex = 2;
			this.txtBotCount.Text = "50";
			// 
			// cboBotType
			// 
			this.cboBotType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBotType.FormattingEnabled = true;
			this.cboBotType.Items.AddRange(new object[] {
            "TcpProxy",
            "Wcf",
            "Tcp"});
			this.cboBotType.Location = new System.Drawing.Point(109, 38);
			this.cboBotType.Name = "cboBotType";
			this.cboBotType.Size = new System.Drawing.Size(100, 21);
			this.cboBotType.TabIndex = 12;
			// 
			// cboConnectType
			// 
			this.cboConnectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboConnectType.FormattingEnabled = true;
			this.cboConnectType.Items.AddRange(new object[] {
            "Dev",
            "Test",
            "Uat"});
			this.cboConnectType.Location = new System.Drawing.Point(109, 65);
			this.cboConnectType.Name = "cboConnectType";
			this.cboConnectType.Size = new System.Drawing.Size(100, 21);
			this.cboConnectType.TabIndex = 13;
			// 
			// cboTableIndex
			// 
			this.cboTableIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTableIndex.FormattingEnabled = true;
			this.cboTableIndex.Items.AddRange(new object[] {
            "1, $0.01 / $0.02 | $0.50",
            "2, $0.02 / $0.05 | $1.50",
            "3, $0.05 / $0.10 | $5",
            "4, $0.10 / $0.25 | $15",
            "5, $0.25 / $0.50 | $40",
            "6, $0.50 / $1.00 | $80",
            "7, $1    / $2    | $160",
            "8, $2    / $4    | $320",
            "9, $3    / $6    | $500",
            "10, $5    / $10   | $800"});
			this.cboTableIndex.Location = new System.Drawing.Point(109, 170);
			this.cboTableIndex.Name = "cboTableIndex";
			this.cboTableIndex.Size = new System.Drawing.Size(176, 21);
			this.cboTableIndex.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(51, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Bot type :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Connect type :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(46, 95);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Target IP :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(14, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "Bot id start index :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(44, 147);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 13);
			this.label6.TabIndex = 19;
			this.label6.Text = "Bot count :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 173);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(93, 13);
			this.label7.TabIndex = 20;
			this.label7.Text = "Table blind index :";
			// 
			// FrmBotLauncher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(576, 207);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cboTableIndex);
			this.Controls.Add(this.cboConnectType);
			this.Controls.Add(this.cboBotType);
			this.Controls.Add(this.txtBotCount);
			this.Controls.Add(this.txtStartIndex);
			this.Controls.Add(this.txtIP);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnStart);
			this.Name = "FrmBotLauncher";
			this.Text = "FrmBotLauncher";
			this.Load += new System.EventHandler(this.FrmBotLauncher_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.TextBox txtIP;
		private System.Windows.Forms.TextBox txtStartIndex;
		private System.Windows.Forms.TextBox txtBotCount;
		private System.Windows.Forms.ComboBox cboBotType;
		private System.Windows.Forms.ComboBox cboConnectType;
		private System.Windows.Forms.ComboBox cboTableIndex;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}