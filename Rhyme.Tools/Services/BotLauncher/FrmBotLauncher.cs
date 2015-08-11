using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Rhyme.Tools.Services.BotLauncher
{
	public partial class FrmBotLauncher : Form
	{
		private string _uatNewString = "UatNew";
		private List<string> _uatNewIpList = new List<string> { "52.69.213.16", "54.64.173.174" };

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
					Arguments = string.Format(
						"{0} {1} {2} {3} {4} {5} {6}",
						cboBotType.SelectedItem,
						cboConnectType.SelectedItem,
						txtStartIndex.Text,
						txtBotCount.Text,
						cboTableIndex.SelectedIndex,
						txtStartBotDelay.Text,
						txtIPList.Text)
				});
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void cboConnectType_SelectedIndexChanged(object sender, EventArgs e)
		{
			txtIPList.Text = string.Empty;

			var comboBox = (sender as ComboBox);
			if (comboBox == null)
				return;

			if (string.Equals(_uatNewString, comboBox.Text) == false)
				return;

			txtIPList.Text = string.Join(",", _uatNewIpList);
		}
	}
}
