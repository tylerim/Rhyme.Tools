namespace Rhyme.Tools.Services.Tourney
{
	partial class frmViewPlayers
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewPlayers));
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.btnView = new System.Windows.Forms.Button();
			this.txtSql = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(10, 105);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowTemplate.Height = 23;
			this.dataGridView.Size = new System.Drawing.Size(369, 345);
			this.dataGridView.TabIndex = 0;
			// 
			// btnView
			// 
			this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnView.Location = new System.Drawing.Point(315, 13);
			this.btnView.Name = "btnView";
			this.btnView.Size = new System.Drawing.Size(64, 25);
			this.btnView.TabIndex = 1;
			this.btnView.Text = "View";
			this.btnView.UseVisualStyleBackColor = true;
			this.btnView.Click += new System.EventHandler(this.btnView_Click);
			// 
			// txtSql
			// 
			this.txtSql.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSql.Location = new System.Drawing.Point(10, 13);
			this.txtSql.Multiline = true;
			this.txtSql.Name = "txtSql";
			this.txtSql.Size = new System.Drawing.Size(369, 85);
			this.txtSql.TabIndex = 2;
			this.txtSql.Text = resources.GetString("txtSql.Text");
			// 
			// frmViewPlayers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 463);
			this.Controls.Add(this.btnView);
			this.Controls.Add(this.txtSql);
			this.Controls.Add(this.dataGridView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "frmViewPlayers";
			this.Text = "View Players";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button btnView;
		private System.Windows.Forms.TextBox txtSql;
	}
}