namespace Rhyme.Tools.Services.Tourney
{
	partial class TourneyForm
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
			this.components = new System.ComponentModel.Container();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDbConnectionString = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAutoMakeInterrval = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBufferTime = new System.Windows.Forms.TextBox();
			this.txtTourneyTemplateId = new System.Windows.Forms.TextBox();
			this.btnAutoMake = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnViewTourney = new System.Windows.Forms.Button();
			this.btnDbExecute = new System.Windows.Forms.Button();
			this.gbLog = new System.Windows.Forms.GroupBox();
			this.btnLogClear = new System.Windows.Forms.Button();
			this.lbLog = new System.Windows.Forms.ListBox();
			this.timerTourneyAutoMake = new System.Windows.Forms.Timer(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.gbLog.SuspendLayout();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Connection";
			// 
			// txtDbConnectionString
			// 
			this.txtDbConnectionString.Location = new System.Drawing.Point(82, 17);
			this.txtDbConnectionString.Name = "txtDbConnectionString";
			this.txtDbConnectionString.Size = new System.Drawing.Size(606, 20);
			this.txtDbConnectionString.TabIndex = 16;
			this.txtDbConnectionString.Text = "Data Source=LOCALHOST\\RICHBITCH;Initial Catalog=rb_crm_dev;Integrated Security=Tr" +
    "ue";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(114, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 25;
			this.label3.Text = "반복주기(초)";
			// 
			// txtAutoMakeInterrval
			// 
			this.txtAutoMakeInterrval.Location = new System.Drawing.Point(193, 75);
			this.txtAutoMakeInterrval.Name = "txtAutoMakeInterrval";
			this.txtAutoMakeInterrval.Size = new System.Drawing.Size(65, 20);
			this.txtAutoMakeInterrval.TabIndex = 24;
			this.txtAutoMakeInterrval.Text = "600";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(114, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 22;
			this.label2.Text = "여유시간(초)";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 13);
			this.label1.TabIndex = 23;
			this.label1.Text = "Id";
			// 
			// txtBufferTime
			// 
			this.txtBufferTime.Location = new System.Drawing.Point(193, 49);
			this.txtBufferTime.Name = "txtBufferTime";
			this.txtBufferTime.Size = new System.Drawing.Size(65, 20);
			this.txtBufferTime.TabIndex = 21;
			this.txtBufferTime.Text = "90";
			// 
			// txtTourneyTemplateId
			// 
			this.txtTourneyTemplateId.Location = new System.Drawing.Point(43, 49);
			this.txtTourneyTemplateId.Name = "txtTourneyTemplateId";
			this.txtTourneyTemplateId.Size = new System.Drawing.Size(65, 20);
			this.txtTourneyTemplateId.TabIndex = 20;
			this.txtTourneyTemplateId.Text = "7";
			// 
			// btnAutoMake
			// 
			this.btnAutoMake.Location = new System.Drawing.Point(299, 75);
			this.btnAutoMake.Name = "btnAutoMake";
			this.btnAutoMake.Size = new System.Drawing.Size(117, 23);
			this.btnAutoMake.TabIndex = 29;
			this.btnAutoMake.Text = "Auto Make Enable";
			this.btnAutoMake.UseVisualStyleBackColor = true;
			this.btnAutoMake.Click += new System.EventHandler(this.btnAutoMake_Click_1);
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(565, 50);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(90, 23);
			this.btnConnect.TabIndex = 28;
			this.btnConnect.Text = "Connect Test";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
			// 
			// btnViewTourney
			// 
			this.btnViewTourney.Location = new System.Drawing.Point(422, 49);
			this.btnViewTourney.Name = "btnViewTourney";
			this.btnViewTourney.Size = new System.Drawing.Size(137, 25);
			this.btnViewTourney.TabIndex = 27;
			this.btnViewTourney.Text = "View TourneyTemplates";
			this.btnViewTourney.UseVisualStyleBackColor = true;
			this.btnViewTourney.Click += new System.EventHandler(this.btnViewTourney_Click_1);
			// 
			// btnDbExecute
			// 
			this.btnDbExecute.Location = new System.Drawing.Point(299, 49);
			this.btnDbExecute.Name = "btnDbExecute";
			this.btnDbExecute.Size = new System.Drawing.Size(117, 25);
			this.btnDbExecute.TabIndex = 26;
			this.btnDbExecute.Text = "Make Tournament";
			this.btnDbExecute.UseVisualStyleBackColor = true;
			this.btnDbExecute.Click += new System.EventHandler(this.btnDbExecute_Click_1);
			// 
			// gbLog
			// 
			this.gbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbLog.Controls.Add(this.lbLog);
			this.gbLog.Location = new System.Drawing.Point(1, 237);
			this.gbLog.Name = "gbLog";
			this.gbLog.Size = new System.Drawing.Size(701, 209);
			this.gbLog.TabIndex = 30;
			this.gbLog.TabStop = false;
			this.gbLog.Text = "Log";
			// 
			// btnLogClear
			// 
			this.btnLogClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLogClear.Location = new System.Drawing.Point(654, 219);
			this.btnLogClear.Name = "btnLogClear";
			this.btnLogClear.Size = new System.Drawing.Size(45, 25);
			this.btnLogClear.TabIndex = 13;
			this.btnLogClear.Text = "Clear";
			this.btnLogClear.UseVisualStyleBackColor = true;
			this.btnLogClear.Click += new System.EventHandler(this.btnLogClear_Click);
			// 
			// lbLog
			// 
			this.lbLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbLog.Font = new System.Drawing.Font("Gulim", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLog.FormattingEnabled = true;
			this.lbLog.ItemHeight = 11;
			this.lbLog.Location = new System.Drawing.Point(3, 16);
			this.lbLog.Name = "lbLog";
			this.lbLog.ScrollAlwaysVisible = true;
			this.lbLog.Size = new System.Drawing.Size(695, 190);
			this.lbLog.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(21, 117);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 13);
			this.label5.TabIndex = 31;
			this.label5.Text = "AccountId";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(21, 143);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 13);
			this.label6.TabIndex = 32;
			this.label6.Text = "TicketTemplatedId";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(122, 114);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(66, 20);
			this.textBox1.TabIndex = 33;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(123, 140);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(65, 20);
			this.textBox2.TabIndex = 34;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(299, 114);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(117, 25);
			this.button1.TabIndex = 35;
			this.button1.Text = "Give Ticket";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// TourneyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(703, 451);
			this.Controls.Add(this.btnLogClear);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.gbLog);
			this.Controls.Add(this.btnAutoMake);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.btnViewTourney);
			this.Controls.Add(this.btnDbExecute);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtAutoMakeInterrval);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBufferTime);
			this.Controls.Add(this.txtTourneyTemplateId);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtDbConnectionString);
			this.Name = "TourneyForm";
			this.Text = "TourneyForm";
			this.gbLog.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDbConnectionString;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtAutoMakeInterrval;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBufferTime;
		private System.Windows.Forms.TextBox txtTourneyTemplateId;
		private System.Windows.Forms.Button btnAutoMake;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnViewTourney;
		private System.Windows.Forms.Button btnDbExecute;
		private System.Windows.Forms.GroupBox gbLog;
		private System.Windows.Forms.Button btnLogClear;
		private System.Windows.Forms.ListBox lbLog;
		private System.Windows.Forms.Timer timerTourneyAutoMake;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button button1;

	}
}