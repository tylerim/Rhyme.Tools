namespace Rhyme.Tools.Services.LoginTool
{
	partial class frmViewTourney
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewTourney));
			this.dataGridViewTourney = new System.Windows.Forms.DataGridView();
			this.btnViewTourny = new System.Windows.Forms.Button();
			this.txtSql = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourney)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewTourney
			// 
			this.dataGridViewTourney.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewTourney.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTourney.Location = new System.Drawing.Point(12, 97);
			this.dataGridViewTourney.Name = "dataGridViewTourney";
			this.dataGridViewTourney.RowTemplate.Height = 23;
			this.dataGridViewTourney.Size = new System.Drawing.Size(260, 153);
			this.dataGridViewTourney.TabIndex = 0;
			// 
			// btnViewTourny
			// 
			this.btnViewTourny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnViewTourny.Location = new System.Drawing.Point(197, 12);
			this.btnViewTourny.Name = "btnViewTourny";
			this.btnViewTourny.Size = new System.Drawing.Size(75, 23);
			this.btnViewTourny.TabIndex = 1;
			this.btnViewTourny.Text = "View";
			this.btnViewTourny.UseVisualStyleBackColor = true;
			this.btnViewTourny.Click += new System.EventHandler(this.btnViewTourny_Click);
			// 
			// txtSql
			// 
			this.txtSql.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSql.Location = new System.Drawing.Point(12, 12);
			this.txtSql.Multiline = true;
			this.txtSql.Name = "txtSql";
			this.txtSql.Size = new System.Drawing.Size(260, 79);
			this.txtSql.TabIndex = 2;
			this.txtSql.Text = resources.GetString("txtSql.Text");
			// 
			// frmViewTourney
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btnViewTourny);
			this.Controls.Add(this.txtSql);
			this.Controls.Add(this.dataGridViewTourney);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "frmViewTourney";
			this.Text = "View Tourney";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTourney)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewTourney;
		private System.Windows.Forms.Button btnViewTourny;
		private System.Windows.Forms.TextBox txtSql;
	}
}