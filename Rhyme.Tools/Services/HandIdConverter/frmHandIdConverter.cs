using System;
using System.Windows.Forms;

namespace Rhyme.Tools.Services.HandIdConverter
{
	public partial class frmHandIdConverter : Form
	{
		public frmHandIdConverter()
		{
			InitializeComponent();
			Init();
		}

		private void Init()
		{
			foreach (var playType in Enum.GetValues(typeof(HandIdPlayType)))
			{
				CB_PlayType.Items.Add(playType.ToString());
			}

			CB_PlayType.SelectedIndex = 1;

			foreach (var gameType in Enum.GetValues(typeof(HandIdGameType)))
			{
				CB_GameType.Items.Add(gameType.ToString());
			}

			CB_GameType.SelectedIndex = 1;

			foreach (var modeType in Enum.GetValues(typeof(HandIdModeType)))
			{
				CB_ModeType.Items.Add(modeType.ToString());
			}

			CB_ModeType.SelectedIndex = 1;
		}

		private void frmHandIdConverter_Load(object sender, EventArgs e)
		{
			TB_ClientHandID.Select();
		}

		private void BT_C2S_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TB_ClientHandID.Text) || string.IsNullOrWhiteSpace(TB_ClientHandID.Text))
				return;

			var clientHandId = 0L;
			if (long.TryParse(TB_ClientHandID.Text, out clientHandId) == false)
			{
				MessageBox.Show("invalid_client_hand_id {0}", TB_ClientHandID.Text);
				return;
			}

			TB_ServerHandID.Text = HandIdConverter.ToHandId((HandIdPlayType)CB_PlayType.SelectedIndex,
				(HandIdGameType)CB_GameType.SelectedIndex, (HandIdModeType)CB_ModeType.SelectedIndex, clientHandId).ToString();
		}

		private void BT_S2C_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TB_ServerHandID.Text) || string.IsNullOrWhiteSpace(TB_ServerHandID.Text))
				return;

			var serverHandId = 0L;
			if (long.TryParse(TB_ServerHandID.Text, out serverHandId) == false)
			{
				MessageBox.Show("invalid_server_hand_id {0}", TB_ServerHandID.Text);
				return;
			}

			var type = HandIdConverter.FromHandId(serverHandId);
			CB_PlayType.SelectedIndex = (int)type.Item1;
			CB_GameType.SelectedIndex = (int)type.Item2;
			CB_ModeType.SelectedIndex = (int)type.Item3;

			TB_ClientHandID.Text = (serverHandId << 20 >> 20).ToString();
		}
	}
}
