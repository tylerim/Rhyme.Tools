using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Rhyme.Tools.Services.BotLauncher
{
	public partial class FrmBotLauncher : Form
	{
		public FrmBotLauncher()
		{
			InitializeComponent();
		}

		private void FrmBotLauncher_Load(object sender, System.EventArgs e)
		{
			cboBotType.SelectedIndex = 0;
			cboConnectType.SelectedIndex = 0;
			cboTableIndex.SelectedIndex = 1;
		}

		private void btnStart_Click(object sender, System.EventArgs e)
		{
			if (cboTableIndex.SelectedIndex == 0)
			{
				MessageBox.Show("Error : Table index is 0");
				return;
			}

			try
			{
				Process.Start(new ProcessStartInfo(txtPath.Text)
				{
					Arguments = string.Format("{0} {1} {2} {3} {4}", cboBotType.SelectedItem, cboConnectType.SelectedItem, txtStartIndex.Text, txtBotCount.Text, cboTableIndex.SelectedIndex)
				});
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
	}
}
