namespace Rhyme.Tools.Services.GuidGenerator
{
	partial class frmGuidGenerator
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
			this.CB_Prefix = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBogus = new System.Windows.Forms.TextBox();
			this.txtServiceLabel = new System.Windows.Forms.TextBox();
			this.txtSeqId = new System.Windows.Forms.TextBox();
			this.btGenerate = new System.Windows.Forms.Button();
			this.txtGeneratedText = new System.Windows.Forms.TextBox();
			this.btRegenerate = new System.Windows.Forms.Button();
			this.txtReGeneratedText = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// CB_Prefix
			// 
			this.CB_Prefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CB_Prefix.FormattingEnabled = true;
			this.CB_Prefix.Location = new System.Drawing.Point(96, 12);
			this.CB_Prefix.Name = "CB_Prefix";
			this.CB_Prefix.Size = new System.Drawing.Size(142, 20);
			this.CB_Prefix.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(53, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "Prefix";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "bogus";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 12);
			this.label3.TabIndex = 3;
			this.label3.Text = "ServiceLabel";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(53, 95);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 12);
			this.label4.TabIndex = 3;
			this.label4.Text = "SeqId";
			// 
			// txtBogus
			// 
			this.txtBogus.Location = new System.Drawing.Point(96, 38);
			this.txtBogus.Name = "txtBogus";
			this.txtBogus.Size = new System.Drawing.Size(142, 21);
			this.txtBogus.TabIndex = 4;
			this.txtBogus.Text = "0";
			// 
			// txtServiceLabel
			// 
			this.txtServiceLabel.Location = new System.Drawing.Point(96, 65);
			this.txtServiceLabel.Name = "txtServiceLabel";
			this.txtServiceLabel.Size = new System.Drawing.Size(142, 21);
			this.txtServiceLabel.TabIndex = 5;
			this.txtServiceLabel.Text = "0";
			// 
			// txtSeqId
			// 
			this.txtSeqId.Location = new System.Drawing.Point(96, 92);
			this.txtSeqId.Name = "txtSeqId";
			this.txtSeqId.Size = new System.Drawing.Size(142, 21);
			this.txtSeqId.TabIndex = 6;
			this.txtSeqId.Text = "0";
			// 
			// btGenerate
			// 
			this.btGenerate.Location = new System.Drawing.Point(244, 36);
			this.btGenerate.Name = "btGenerate";
			this.btGenerate.Size = new System.Drawing.Size(102, 23);
			this.btGenerate.TabIndex = 7;
			this.btGenerate.Text = "Generate ->";
			this.btGenerate.UseVisualStyleBackColor = true;
			this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
			// 
			// txtGeneratedText
			// 
			this.txtGeneratedText.Location = new System.Drawing.Point(352, 38);
			this.txtGeneratedText.Name = "txtGeneratedText";
			this.txtGeneratedText.Size = new System.Drawing.Size(233, 21);
			this.txtGeneratedText.TabIndex = 8;
			// 
			// btRegenerate
			// 
			this.btRegenerate.Location = new System.Drawing.Point(244, 65);
			this.btRegenerate.Name = "btRegenerate";
			this.btRegenerate.Size = new System.Drawing.Size(102, 23);
			this.btRegenerate.TabIndex = 9;
			this.btRegenerate.Text = "ReGenerate <-";
			this.btRegenerate.UseVisualStyleBackColor = true;
			this.btRegenerate.Click += new System.EventHandler(this.btRegenerate_Click);
			// 
			// txtReGeneratedText
			// 
			this.txtReGeneratedText.Location = new System.Drawing.Point(352, 65);
			this.txtReGeneratedText.Name = "txtReGeneratedText";
			this.txtReGeneratedText.Size = new System.Drawing.Size(233, 21);
			this.txtReGeneratedText.TabIndex = 10;
			// 
			// frmGuidGenerator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(629, 178);
			this.Controls.Add(this.txtReGeneratedText);
			this.Controls.Add(this.btRegenerate);
			this.Controls.Add(this.txtGeneratedText);
			this.Controls.Add(this.btGenerate);
			this.Controls.Add(this.txtSeqId);
			this.Controls.Add(this.txtServiceLabel);
			this.Controls.Add(this.txtBogus);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CB_Prefix);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frmGuidGenerator";
			this.Text = "Guid Generator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox CB_Prefix;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtBogus;
		private System.Windows.Forms.TextBox txtServiceLabel;
		private System.Windows.Forms.TextBox txtSeqId;
		private System.Windows.Forms.Button btGenerate;
		private System.Windows.Forms.TextBox txtGeneratedText;
		private System.Windows.Forms.Button btRegenerate;
		private System.Windows.Forms.TextBox txtReGeneratedText;
	}
}