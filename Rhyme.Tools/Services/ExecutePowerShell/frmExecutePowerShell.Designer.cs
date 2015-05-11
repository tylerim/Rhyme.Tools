namespace Rhyme.Tools.Services.ExecutePowerShell
{
	partial class frmExecutePowerShell
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExecutePowerShell));
			this.txtCommand = new System.Windows.Forms.TextBox();
			this.btExecute = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtCommand
			// 
			this.txtCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCommand.Location = new System.Drawing.Point(12, 12);
			this.txtCommand.Multiline = true;
			this.txtCommand.Name = "txtCommand";
			this.txtCommand.Size = new System.Drawing.Size(476, 353);
			this.txtCommand.TabIndex = 0;
			this.txtCommand.Text = resources.GetString("txtCommand.Text");
			// 
			// btExecute
			// 
			this.btExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btExecute.Location = new System.Drawing.Point(413, 342);
			this.btExecute.Name = "btExecute";
			this.btExecute.Size = new System.Drawing.Size(75, 23);
			this.btExecute.TabIndex = 1;
			this.btExecute.Text = "Execute";
			this.btExecute.UseVisualStyleBackColor = true;
			this.btExecute.Click += new System.EventHandler(this.btExecute_Click);
			// 
			// frmExecutePowerShell
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 377);
			this.Controls.Add(this.btExecute);
			this.Controls.Add(this.txtCommand);
			this.Name = "frmExecutePowerShell";
			this.Text = "frmExecutePowerShell";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtCommand;
		private System.Windows.Forms.Button btExecute;
	}
}