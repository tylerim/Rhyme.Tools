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
			this.rbRegisterTourneyTrueOnce = new System.Windows.Forms.RadioButton();
			this.gbRegisterTourney = new System.Windows.Forms.GroupBox();
			this.gbIsBotLoginIdPasswordSame = new System.Windows.Forms.GroupBox();
			this.rbBotIdPasswordSame = new System.Windows.Forms.RadioButton();
			this.rbBotIdPasswordDifferent = new System.Windows.Forms.RadioButton();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.txtPrefixBotLoginId = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.txtBotLoginPassword = new System.Windows.Forms.TextBox();
			this.gbRegisterTourney.SuspendLayout();
			this.gbIsBotLoginIdPasswordSame.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStart.Location = new System.Drawing.Point(634, 277);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 130;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(113, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Path :";
			// 
			// txtPath
			// 
			this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPath.Location = new System.Drawing.Point(154, 12);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(555, 20);
			this.txtPath.TabIndex = 10;
			this.txtPath.Text = "D:\\Rhyme\\dev\\src\\tools\\Rhyme.Bot\\Rhyme.Bot\\bin\\Debug\\Rhyme.Bot.exe";
			// 
			// txtStartIndex
			// 
			this.txtStartIndex.Location = new System.Drawing.Point(154, 65);
			this.txtStartIndex.Name = "txtStartIndex";
			this.txtStartIndex.Size = new System.Drawing.Size(100, 20);
			this.txtStartIndex.TabIndex = 40;
			this.txtStartIndex.Text = "1";
			// 
			// txtBotCount
			// 
			this.txtBotCount.Location = new System.Drawing.Point(472, 65);
			this.txtBotCount.Name = "txtBotCount";
			this.txtBotCount.Size = new System.Drawing.Size(100, 20);
			this.txtBotCount.TabIndex = 50;
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
			this.cboBotType.Location = new System.Drawing.Point(154, 38);
			this.cboBotType.Name = "cboBotType";
			this.cboBotType.Size = new System.Drawing.Size(100, 21);
			this.cboBotType.TabIndex = 20;
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
			this.cboConnectType.Location = new System.Drawing.Point(472, 38);
			this.cboConnectType.Name = "cboConnectType";
			this.cboConnectType.Size = new System.Drawing.Size(100, 21);
			this.cboConnectType.TabIndex = 30;
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
			this.cboTableIndex.Location = new System.Drawing.Point(154, 91);
			this.cboTableIndex.Name = "cboTableIndex";
			this.cboTableIndex.Size = new System.Drawing.Size(189, 21);
			this.cboTableIndex.TabIndex = 60;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(94, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Bot type :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(390, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Connect type :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(57, 68);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "Bot id start index :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(407, 68);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 13);
			this.label6.TabIndex = 19;
			this.label6.Text = "Bot count :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(55, 94);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(93, 13);
			this.label7.TabIndex = 20;
			this.label7.Text = "Table blind index :";
			// 
			// txtStartBotDelay
			// 
			this.txtStartBotDelay.Location = new System.Drawing.Point(472, 91);
			this.txtStartBotDelay.Name = "txtStartBotDelay";
			this.txtStartBotDelay.Size = new System.Drawing.Size(100, 20);
			this.txtStartBotDelay.TabIndex = 70;
			this.txtStartBotDelay.Text = "200";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(409, 94);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 13);
			this.label8.TabIndex = 22;
			this.label8.Text = "Bot delay :";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(345, 256);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(76, 13);
			this.label9.TabIndex = 24;
			this.label9.Text = "Target IP List :";
			// 
			// txtIPList
			// 
			this.txtIPList.Location = new System.Drawing.Point(427, 253);
			this.txtIPList.Name = "txtIPList";
			this.txtIPList.Size = new System.Drawing.Size(282, 20);
			this.txtIPList.TabIndex = 120;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(578, 94);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(63, 13);
			this.label10.TabIndex = 25;
			this.label10.Text = "milliseconds";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(54, 139);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 13);
			this.label4.TabIndex = 26;
			this.label4.Text = "Register Tourney :";
			// 
			// rbRegisterTourneyTrue
			// 
			this.rbRegisterTourneyTrue.AutoSize = true;
			this.rbRegisterTourneyTrue.Location = new System.Drawing.Point(6, 19);
			this.rbRegisterTourneyTrue.Name = "rbRegisterTourneyTrue";
			this.rbRegisterTourneyTrue.Size = new System.Drawing.Size(103, 17);
			this.rbRegisterTourneyTrue.TabIndex = 80;
			this.rbRegisterTourneyTrue.TabStop = true;
			this.rbRegisterTourneyTrue.Text = "토너 자동 등록";
			this.rbRegisterTourneyTrue.UseVisualStyleBackColor = true;
			// 
			// rbRegisterTourneyFalse
			// 
			this.rbRegisterTourneyFalse.AutoSize = true;
			this.rbRegisterTourneyFalse.Checked = true;
			this.rbRegisterTourneyFalse.Location = new System.Drawing.Point(269, 19);
			this.rbRegisterTourneyFalse.Name = "rbRegisterTourneyFalse";
			this.rbRegisterTourneyFalse.Size = new System.Drawing.Size(159, 17);
			this.rbRegisterTourneyFalse.TabIndex = 100;
			this.rbRegisterTourneyFalse.TabStop = true;
			this.rbRegisterTourneyFalse.Text = "Table blind index 게임 등록";
			this.rbRegisterTourneyFalse.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(68, 256);
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
            "MyPlatform",
            "TwoAce"});
			this.cboLoginPlatform.Location = new System.Drawing.Point(154, 253);
			this.cboLoginPlatform.Name = "cboLoginPlatform";
			this.cboLoginPlatform.Size = new System.Drawing.Size(100, 21);
			this.cboLoginPlatform.TabIndex = 110;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(345, 276);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(259, 13);
			this.label12.TabIndex = 31;
			this.label12.Text = "(DEV 일때 IP List 를 넣지 않으면 Local IP 로 처리)";
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(9, 307);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(60, 13);
			this.label13.TabIndex = 33;
			this.label13.Text = "Command :";
			// 
			// txtCommand
			// 
			this.txtCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCommand.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCommand.Location = new System.Drawing.Point(71, 306);
			this.txtCommand.Name = "txtCommand";
			this.txtCommand.ReadOnly = true;
			this.txtCommand.Size = new System.Drawing.Size(638, 20);
			this.txtCommand.TabIndex = 900;
			this.txtCommand.TabStop = false;
			// 
			// rbRegisterTourneyTrueOnce
			// 
			this.rbRegisterTourneyTrueOnce.AutoSize = true;
			this.rbRegisterTourneyTrueOnce.Location = new System.Drawing.Point(115, 19);
			this.rbRegisterTourneyTrueOnce.Name = "rbRegisterTourneyTrueOnce";
			this.rbRegisterTourneyTrueOnce.Size = new System.Drawing.Size(148, 17);
			this.rbRegisterTourneyTrueOnce.TabIndex = 90;
			this.rbRegisterTourneyTrueOnce.TabStop = true;
			this.rbRegisterTourneyTrueOnce.Text = "토너 자동 등록 (한번만)";
			this.rbRegisterTourneyTrueOnce.UseVisualStyleBackColor = true;
			// 
			// gbRegisterTourney
			// 
			this.gbRegisterTourney.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbRegisterTourney.Controls.Add(this.rbRegisterTourneyTrue);
			this.gbRegisterTourney.Controls.Add(this.rbRegisterTourneyFalse);
			this.gbRegisterTourney.Controls.Add(this.rbRegisterTourneyTrueOnce);
			this.gbRegisterTourney.Location = new System.Drawing.Point(154, 118);
			this.gbRegisterTourney.Name = "gbRegisterTourney";
			this.gbRegisterTourney.Size = new System.Drawing.Size(555, 50);
			this.gbRegisterTourney.TabIndex = 901;
			this.gbRegisterTourney.TabStop = false;
			// 
			// gbIsBotLoginIdPasswordSame
			// 
			this.gbIsBotLoginIdPasswordSame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbIsBotLoginIdPasswordSame.Controls.Add(this.label16);
			this.gbIsBotLoginIdPasswordSame.Controls.Add(this.txtBotLoginPassword);
			this.gbIsBotLoginIdPasswordSame.Controls.Add(this.label15);
			this.gbIsBotLoginIdPasswordSame.Controls.Add(this.txtPrefixBotLoginId);
			this.gbIsBotLoginIdPasswordSame.Controls.Add(this.label14);
			this.gbIsBotLoginIdPasswordSame.Controls.Add(this.rbBotIdPasswordSame);
			this.gbIsBotLoginIdPasswordSame.Controls.Add(this.rbBotIdPasswordDifferent);
			this.gbIsBotLoginIdPasswordSame.Location = new System.Drawing.Point(17, 174);
			this.gbIsBotLoginIdPasswordSame.Name = "gbIsBotLoginIdPasswordSame";
			this.gbIsBotLoginIdPasswordSame.Size = new System.Drawing.Size(692, 73);
			this.gbIsBotLoginIdPasswordSame.TabIndex = 902;
			this.gbIsBotLoginIdPasswordSame.TabStop = false;
			// 
			// rbBotIdPasswordSame
			// 
			this.rbBotIdPasswordSame.AutoSize = true;
			this.rbBotIdPasswordSame.Location = new System.Drawing.Point(455, 46);
			this.rbBotIdPasswordSame.Name = "rbBotIdPasswordSame";
			this.rbBotIdPasswordSame.Size = new System.Drawing.Size(49, 17);
			this.rbBotIdPasswordSame.TabIndex = 92;
			this.rbBotIdPasswordSame.TabStop = true;
			this.rbBotIdPasswordSame.Text = "True";
			this.rbBotIdPasswordSame.UseVisualStyleBackColor = true;
			// 
			// rbBotIdPasswordDifferent
			// 
			this.rbBotIdPasswordDifferent.AutoSize = true;
			this.rbBotIdPasswordDifferent.Checked = true;
			this.rbBotIdPasswordDifferent.Location = new System.Drawing.Point(510, 46);
			this.rbBotIdPasswordDifferent.Name = "rbBotIdPasswordDifferent";
			this.rbBotIdPasswordDifferent.Size = new System.Drawing.Size(115, 17);
			this.rbBotIdPasswordDifferent.TabIndex = 91;
			this.rbBotIdPasswordDifferent.Text = "False";
			this.rbBotIdPasswordDifferent.UseVisualStyleBackColor = true;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(339, 48);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(110, 13);
			this.label14.TabIndex = 903;
			this.label14.Text = "ID Password same ? :";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(31, 22);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 13);
			this.label15.TabIndex = 904;
			this.label15.Text = "Bot Login ID prefix :";
			// 
			// txtPrefixBotLoginId
			// 
			this.txtPrefixBotLoginId.Location = new System.Drawing.Point(137, 19);
			this.txtPrefixBotLoginId.Name = "txtPrefixBotLoginId";
			this.txtPrefixBotLoginId.Size = new System.Drawing.Size(100, 20);
			this.txtPrefixBotLoginId.TabIndex = 905;
			this.txtPrefixBotLoginId.Text = "t";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(24, 48);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(107, 13);
			this.label16.TabIndex = 906;
			this.label16.Text = "Bot Login Password :";
			// 
			// txtBotLoginPassword
			// 
			this.txtBotLoginPassword.Location = new System.Drawing.Point(137, 45);
			this.txtBotLoginPassword.Name = "txtBotLoginPassword";
			this.txtBotLoginPassword.Size = new System.Drawing.Size(100, 20);
			this.txtBotLoginPassword.TabIndex = 907;
			this.txtBotLoginPassword.Text = "1";
			// 
			// FrmBotLauncher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(721, 338);
			this.Controls.Add(this.gbIsBotLoginIdPasswordSame);
			this.Controls.Add(this.gbRegisterTourney);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtCommand);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.cboLoginPlatform);
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
			this.Text = "Rhyme.Bot";
			this.Load += new System.EventHandler(this.FrmBotLauncher_Load);
			this.gbRegisterTourney.ResumeLayout(false);
			this.gbRegisterTourney.PerformLayout();
			this.gbIsBotLoginIdPasswordSame.ResumeLayout(false);
			this.gbIsBotLoginIdPasswordSame.PerformLayout();
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
		private System.Windows.Forms.RadioButton rbRegisterTourneyTrueOnce;
		private System.Windows.Forms.GroupBox gbRegisterTourney;
		private System.Windows.Forms.GroupBox gbIsBotLoginIdPasswordSame;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtBotLoginPassword;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtPrefixBotLoginId;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.RadioButton rbBotIdPasswordSame;
		private System.Windows.Forms.RadioButton rbBotIdPasswordDifferent;
	}
}