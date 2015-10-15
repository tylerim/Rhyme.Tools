namespace Rhyme.Tools.Services.Tourney
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
			this.btnViewTourney = new System.Windows.Forms.Button();
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
			this.dataGridViewTourney.Location = new System.Drawing.Point(10, 105);
			this.dataGridViewTourney.Name = "dataGridViewTourney";
			this.dataGridViewTourney.RowTemplate.Height = 23;
			this.dataGridViewTourney.Size = new System.Drawing.Size(1565, 166);
			this.dataGridViewTourney.TabIndex = 0;
			// 
			// btnViewTourney
			// 
			this.btnViewTourney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnViewTourney.Location = new System.Drawing.Point(1511, 13);
			this.btnViewTourney.Name = "btnViewTourny";
			this.btnViewTourney.Size = new System.Drawing.Size(64, 25);
			this.btnViewTourney.TabIndex = 1;
			this.btnViewTourney.Text = "View";
			this.btnViewTourney.UseVisualStyleBackColor = true;
			this.btnViewTourney.Click += new System.EventHandler(this.btnViewTourny_Click);
			// 
			// txtSql
			// 
			this.txtSql.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSql.Location = new System.Drawing.Point(10, 13);
			this.txtSql.Multiline = true;
			this.txtSql.Name = "txtSql";
			this.txtSql.Size = new System.Drawing.Size(1565, 85);
			this.txtSql.TabIndex = 2;
			this.txtSql.Text = resources.GetString("txtSql.Text");
			// 
			// frmViewTourney
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1585, 284);
			this.Controls.Add(this.btnViewTourney);
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
		private System.Windows.Forms.Button btnViewTourney;
		private System.Windows.Forms.TextBox txtSql;
	}
}