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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBotLauncher));
			this.btnStart = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.txtStartIndex = new System.Windows.Forms.TextBox();
			this.txtBotCount = new System.Windows.Forms.TextBox();
			this.cboBotType = new System.Windows.Forms.ComboBox();
			this.cboConnectType = new System.Windows.Forms.ComboBox();
			this.cboTableIndex = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtStartBotDelay = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtIPList = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.rbRegisterTourneyTrue = new System.Windows.Forms.RadioButton();
			this.rbRegisterTourneyFalse = new System.Windows.Forms.RadioButton();
			this.label11 = new System.Windows.Forms.Label();
			this.cboLoginPlatform = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtCommand = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(372, 250);
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
			this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPath.Location = new System.Drawing.Point(109, 12);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(434, 20);
			this.txtPath.TabIndex = 2;
			this.txtPath.Text = "D:\\Rhyme\\dev\\src\\tools\\Rhyme.Bot\\Rhyme.Bot\\bin\\Debug\\Rhyme.Bot.exe";
			// 
			// txtStartIndex
			// 
			this.txtStartIndex.Location = new System.Drawing.Point(109, 92);
			this.txtStartIndex.Name = "txtStartIndex";
			this.txtStartIndex.Size = new System.Drawing.Size(100, 20);
			this.txtStartIndex.TabIndex = 2;
			this.txtStartIndex.Text = "1";
			// 
			// txtBotCount
			// 
			this.txtBotCount.Location = new System.Drawing.Point(109, 118);
			this.txtBotCount.Name = "txtBotCount";
			this.txtBotCount.Size = new System.Drawing.Size(100, 20);
			this.txtBotCount.TabIndex = 2;
			this.txtBotCount.Text = "50";
			// 
			// cboBotType
			// 
			this.cboBotType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBotType.Enabled = false;
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
            "Uat",
            "UatNew",
            "Direct"});
			this.cboConnectType.Location = new System.Drawing.Point(109, 65);
			this.cboConnectType.Name = "cboConnectType";
			this.cboConnectType.Size = new System.Drawing.Size(100, 21);
			this.cboConnectType.TabIndex = 13;
			this.cboConnectType.SelectedIndexChanged += new System.EventHandler(this.cboConnectType_SelectedIndexChanged);
			// 
			// cboTableIndex
			// 
			this.cboTableIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTableIndex.FormattingEnabled = true;
			this.cboTableIndex.Items.AddRange(new object[] {
            "0, None",
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
			this.cboTableIndex.Location = new System.Drawing.Point(109, 144);
			this.cboTableIndex.Name = "cboTableIndex";
			this.cboTableIndex.Size = new System.Drawing.Size(257, 21);
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
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(14, 95);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "Bot id start index :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(44, 121);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 13);
			this.label6.TabIndex = 19;
			this.label6.Text = "Bot count :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 147);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(93, 13);
			this.label7.TabIndex = 20;
			this.label7.Text = "Table blind index :";
			// 
			// txtStartBotDelay
			// 
			this.txtStartBotDelay.Location = new System.Drawing.Point(109, 171);
			this.txtStartBotDelay.Name = "txtStartBotDelay";
			this.txtStartBotDelay.Size = new System.Drawing.Size(100, 20);
			this.txtStartBotDelay.TabIndex = 21;
			this.txtStartBotDelay.Text = "200";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(22, 174);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(81, 13);
			this.label8.TabIndex = 22;
			this.label8.Text = "Start bot delay :";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(27, 255);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(76, 13);
			this.label9.TabIndex = 24;
			this.label9.Text = "Target IP List :";
			// 
			// txtIPList
			// 
			this.txtIPList.Location = new System.Drawing.Point(109, 252);
			this.txtIPList.Name = "txtIPList";
			this.txtIPList.Size = new System.Drawing.Size(257, 20);
			this.txtIPList.TabIndex = 23;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(215, 174);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(63, 13);
			this.label10.TabIndex = 25;
			this.label10.Text = "milliseconds";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 201);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 13);
			this.label4.TabIndex = 26;
			this.label4.Text = "Start bot delay :";
			// 
			// rbRegisterTourneyTrue
			// 
			this.rbRegisterTourneyTrue.AutoSize = true;
			this.rbRegisterTourneyTrue.Location = new System.Drawing.Point(109, 197);
			this.rbRegisterTourneyTrue.Name = "rbRegisterTourneyTrue";
			this.rbRegisterTourneyTrue.Size = new System.Drawing.Size(103, 17);
			this.rbRegisterTourneyTrue.TabIndex = 27;
			this.rbRegisterTourneyTrue.Text = "토너 자동 등록";
			this.rbRegisterTourneyTrue.UseVisualStyleBackColor = true;
			// 
			// rbRegisterTourneyFalse
			// 
			this.rbRegisterTourneyFalse.AutoSize = true;
			this.rbRegisterTourneyFalse.Checked = true;
			this.rbRegisterTourneyFalse.Location = new System.Drawing.Point(218, 197);
			this.rbRegisterTourneyFalse.Name = "rbRegisterTourneyFalse";
			this.rbRegisterTourneyFalse.Size = new System.Drawing.Size(159, 17);
			this.rbRegisterTourneyFalse.TabIndex = 28;
			this.rbRegisterTourneyFalse.TabStop = true;
			this.rbRegisterTourneyFalse.Text = "Table blind index 게임 등록";
			this.rbRegisterTourneyFalse.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(23, 228);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 13);
			this.label11.TabIndex = 30;
			this.label11.Text = "Login Platform :";
			// 
			// cboLoginPlatform
			// 
			this.cboLoginPlatform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboLoginPlatform.FormattingEnabled = true;
			this.cboLoginPlatform.Items.AddRange(new object[] {
            "Vault",
            "GP",
            "MyPlatform"});
			this.cboLoginPlatform.Location = new System.Drawing.Point(109, 225);
			this.cboLoginPlatform.Name = "cboLoginPlatform";
			this.cboLoginPlatform.Size = new System.Drawing.Size(100, 21);
			this.cboLoginPlatform.TabIndex = 29;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(106, 275);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(259, 13);
			this.label12.TabIndex = 31;
			this.label12.Text = "(DEV 일때 IP List 를 넣지 않으면 Local IP 로 처리)";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(43, 316);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(60, 13);
			this.label13.TabIndex = 33;
			this.label13.Text = "Command :";
			// 
			// txtCommand
			// 
			this.txtCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCommand.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCommand.Location = new System.Drawing.Point(109, 313);
			this.txtCommand.Name = "txtCommand";
			this.txtCommand.ReadOnly = true;
			this.txtCommand.Size = new System.Drawing.Size(434, 20);
			this.txtCommand.TabIndex = 32;
			// 
			// FrmBotLauncher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 345);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtCommand);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.cboLoginPlatform);
			this.Controls.Add(this.rbRegisterTourneyFalse);
			this.Controls.Add(this.rbRegisterTourneyTrue);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtIPList);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtStartBotDelay);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cboTableIndex);
			this.Controls.Add(this.cboConnectType);
			this.Controls.Add(this.cboBotType);
			this.Controls.Add(this.txtBotCount);
			this.Controls.Add(this.txtStartIndex);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnStart);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
		private System.Windows.Forms.TextBox txtStartIndex;
		private System.Windows.Forms.TextBox txtBotCount;
		private System.Windows.Forms.ComboBox cboBotType;
		private System.Windows.Forms.ComboBox cboConnectType;
		private System.Windows.Forms.ComboBox cboTableIndex;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtStartBotDelay;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtIPList;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton rbRegisterTourneyTrue;
		private System.Windows.Forms.RadioButton rbRegisterTourneyFalse;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cboLoginPlatform;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtCommand;
	}
}