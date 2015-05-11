namespace Rhyme.Tools.Services.HandIdConverter
{
	partial class frmHandIdConverter
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
			this.label1 = new System.Windows.Forms.Label();
			this.CB_PlayType = new System.Windows.Forms.ComboBox();
			this.CB_GameType = new System.Windows.Forms.ComboBox();
			this.CB_ModeType = new System.Windows.Forms.ComboBox();
			this.TB_ClientHandID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TB_ServerHandID = new System.Windows.Forms.TextBox();
			this.BT_C2S = new System.Windows.Forms.Button();
			this.BT_S2C = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "Client :";
			// 
			// CB_PlayType
			// 
			this.CB_PlayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CB_PlayType.FormattingEnabled = true;
			this.CB_PlayType.Location = new System.Drawing.Point(12, 12);
			this.CB_PlayType.Name = "CB_PlayType";
			this.CB_PlayType.Size = new System.Drawing.Size(121, 20);
			this.CB_PlayType.TabIndex = 1;
			// 
			// CB_GameType
			// 
			this.CB_GameType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CB_GameType.FormattingEnabled = true;
			this.CB_GameType.Location = new System.Drawing.Point(139, 12);
			this.CB_GameType.Name = "CB_GameType";
			this.CB_GameType.Size = new System.Drawing.Size(121, 20);
			this.CB_GameType.TabIndex = 1;
			// 
			// CB_ModeType
			// 
			this.CB_ModeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CB_ModeType.FormattingEnabled = true;
			this.CB_ModeType.Location = new System.Drawing.Point(266, 12);
			this.CB_ModeType.Name = "CB_ModeType";
			this.CB_ModeType.Size = new System.Drawing.Size(121, 20);
			this.CB_ModeType.TabIndex = 1;
			// 
			// TB_ClientHandID
			// 
			this.TB_ClientHandID.Location = new System.Drawing.Point(60, 46);
			this.TB_ClientHandID.Name = "TB_ClientHandID";
			this.TB_ClientHandID.Size = new System.Drawing.Size(142, 21);
			this.TB_ClientHandID.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(214, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "Server :";
			// 
			// TB_ServerHandID
			// 
			this.TB_ServerHandID.Location = new System.Drawing.Point(268, 46);
			this.TB_ServerHandID.Name = "TB_ServerHandID";
			this.TB_ServerHandID.Size = new System.Drawing.Size(142, 21);
			this.TB_ServerHandID.TabIndex = 2;
			// 
			// BT_C2S
			// 
			this.BT_C2S.Location = new System.Drawing.Point(416, 12);
			this.BT_C2S.Name = "BT_C2S";
			this.BT_C2S.Size = new System.Drawing.Size(75, 23);
			this.BT_C2S.TabIndex = 3;
			this.BT_C2S.Text = "C -> S";
			this.BT_C2S.UseVisualStyleBackColor = true;
			this.BT_C2S.Click += new System.EventHandler(this.BT_C2S_Click);
			// 
			// BT_S2C
			// 
			this.BT_S2C.Location = new System.Drawing.Point(416, 45);
			this.BT_S2C.Name = "BT_S2C";
			this.BT_S2C.Size = new System.Drawing.Size(75, 23);
			this.BT_S2C.TabIndex = 3;
			this.BT_S2C.Text = "C <- S";
			this.BT_S2C.UseVisualStyleBackColor = true;
			this.BT_S2C.Click += new System.EventHandler(this.BT_S2C_Click);
			// 
			// frmHandIdConverter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 80);
			this.Controls.Add(this.BT_S2C);
			this.Controls.Add(this.BT_C2S);
			this.Controls.Add(this.TB_ServerHandID);
			this.Controls.Add(this.TB_ClientHandID);
			this.Controls.Add(this.CB_ModeType);
			this.Controls.Add(this.CB_GameType);
			this.Controls.Add(this.CB_PlayType);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmHandIdConverter";
			this.Text = "Hand ID Converter";
			this.Load += new System.EventHandler(this.frmHandIdConverter_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox CB_PlayType;
		private System.Windows.Forms.ComboBox CB_GameType;
		private System.Windows.Forms.ComboBox CB_ModeType;
		private System.Windows.Forms.TextBox TB_ClientHandID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TB_ServerHandID;
		private System.Windows.Forms.Button BT_C2S;
		private System.Windows.Forms.Button BT_S2C;
	}
}

