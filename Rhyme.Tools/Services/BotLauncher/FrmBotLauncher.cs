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

		private void FrmBotLauncher_Load(object sender, EventArgs e)
		{
			cboBotType.SelectedIndex = 2;			// TCP
			cboConnectType.SelectedIndex = 0;		// Dev
			cboTableIndex.SelectedIndex = 1;		// 1
			cboLoginPlatform.SelectedIndex = 1;		// GP
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (cboTableIndex.SelectedIndex == 0)
			{
				MessageBox.Show("Error : Table index is 0");
				return;
			}

			try
			{
				var arguments = string.Format(
					"{0} {1} {2} {3} {4} {5} {6} {7} {8}",
					cboBotType.SelectedItem,
					cboConnectType.SelectedItem,
					txtStartIndex.Text,
					txtBotCount.Text,
					cboTableIndex.SelectedIndex,
					txtStartBotDelay.Text,
					rbRegisterTourneyTrue.Checked ? "True" : "False",
					cboLoginPlatform.SelectedItem,
					txtIPList.Text);

				txtCommand.Text = arguments;

				Process.Start(new ProcessStartInfo(txtPath.Text)
				{
					Arguments = arguments
				});
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void cboConnectType_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtIPList.Enabled = false;
			txtIPList.Text = string.Empty;

			var comboBox = (sender as ComboBox);
			if (comboBox == null)
				return;

			if ((string.Equals("Dev", comboBox.Text) || string.Equals("Direct", comboBox.Text)) == false)
				return;

			txtIPList.Enabled = true;
		}
	}
}
