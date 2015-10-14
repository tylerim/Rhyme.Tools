using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Rhyme.Tools.Services.ExecutePowerShell
{
	public partial class frmExecutePowerShell : Form
	{
		public frmExecutePowerShell()
		{
			InitializeComponent();
		}

		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);

			MDIManager.ParentForm.FrmExecutePowerShell = null;
		}


		private void btExecute_Click(object sender, EventArgs e)
		{
			// return value
			var info = new ProcessStartInfo("cmd.exe")
			{
				WorkingDirectory = @"c:\",
				Arguments = this.txtCommand.Text,
				WindowStyle = ProcessWindowStyle.Normal,
			};

			ProcessStartInternal(info);
		}

		private void ProcessStartInternal(ProcessStartInfo startInfo)
		{
			Cursor.Current = Cursors.WaitCursor;

			var info = new ProcessStartInfo(startInfo.FileName)
			{
				WorkingDirectory = startInfo.WorkingDirectory,
				Arguments = startInfo.Arguments,
				WindowStyle = startInfo.WindowStyle,
			};
			var process = Process.Start(info);

			Cursor.Current = Cursors.Default;
		}
	}
}
