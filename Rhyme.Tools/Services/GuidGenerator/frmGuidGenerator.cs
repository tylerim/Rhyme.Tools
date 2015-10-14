using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Rhyme.Tools.Services.GuidGenerator
{
	public partial class frmGuidGenerator : Form
	{
		public frmGuidGenerator()
		{
			InitializeComponent();
			Init();
		}

		private Dictionary<int /* combobox index */, int /* GuidHelper.GuidType */> _prefixDictionary;

		private void Init()
		{
			_prefixDictionary = new Dictionary<int, int>();

			var index = 0;
			foreach (var guidType in Enum.GetValues(typeof(GuidHelper.GuidType)))
			{
				CB_Prefix.Items.Add(guidType.ToString());
				_prefixDictionary.Add(index++, (int) guidType);
			}

			CB_Prefix.SelectedIndex = 0;
		}

		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);

			MDIManager.ParentForm.FrmGuidGenerator = null;
		}


		private void btGenerate_Click(object sender, EventArgs e)
		{
			int tryPrefix = -1;
			if (_prefixDictionary.TryGetValue(CB_Prefix.SelectedIndex, out tryPrefix) == false)
				return;

			var prefix = tryPrefix;
			var bogus = this.ValidateText(this.txtBogus.Text);
			var serviceLabel = this.ValidateText(this.txtServiceLabel.Text);
			var seqId = this.ValidateText(this.txtSeqId.Text);

			var generatedGuid = GuidHelper.GenerateGuid((GuidHelper.GuidType)prefix, bogus, serviceLabel, seqId);

			this.txtGeneratedText.Text = generatedGuid.ToString();
		}

		private int ValidateText(string value)
		{
			var validatedValue = -1;

			if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
				validatedValue = 0;

			var tryInt = -1;
			if (int.TryParse(value, out tryInt) == false)
				validatedValue = 0;
			else
				validatedValue = tryInt;

			return validatedValue;
		}

		private void btRegenerate_Click(object sender, EventArgs e)
		{
			var regeneratedText = this.txtReGeneratedText.Text;
			Guid tryGuid;
			if (Guid.TryParse(regeneratedText, out tryGuid) == false)
				return;

			var regeneratedGuid = tryGuid;

			// guidType
			var guidType = regeneratedGuid.GetGuidType();
			var tryValue = _prefixDictionary.FirstOrDefault(d => d.Value == (int)guidType).Key;
			CB_Prefix.SelectedIndex = tryValue;
			
			// Bogus
			this.txtBogus.Text = regeneratedGuid.GetBogus().ToString();

			// ServiceLabel
			this.txtServiceLabel.Text = regeneratedGuid.GetServiceLabel().ToString();

			// SeqId
			this.txtSeqId.Text = regeneratedGuid.GetValue().ToString();
		}

		
	}
}
