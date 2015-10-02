using System;
using System.Reflection;
using System.Windows.Forms;

using Rhyme.Tools.Services.BotLauncher;
using Rhyme.Tools.Services.ExecutePowerShell;
using Rhyme.Tools.Services.GuidGenerator;
using Rhyme.Tools.Services.HandIdConverter;
using Rhyme.Tools.Services.LoginTool;
using Rhyme.Tools.Services.UploadImage;

using RhymeLoginTool.Z_Socket;

namespace Rhyme.Tools
{
	public partial class frmMainContainer : Form
	{
		public frmMainContainer()
		{
			InitializeComponent();
		}

		private void frmMainContainer_Load(object sender, EventArgs e)
		{
			this.Text = string.Format("{0} - {1}", Text, Assembly.GetExecutingAssembly().GetName().Version);

			MDIManager.Show(this, new frmMain(), FormWindowState.Maximized);
		}

		private void toolStripButton_LoginTool_Click(object sender, EventArgs e)
		{
			MDIManager.Show(this, new frmMain());
		}

		private void toolStripButton_HandIdConverter_Click(object sender, EventArgs e)
		{
			MDIManager.Show(this, new frmHandIdConverter());
		}

		private void toolStripButton_GuidGenerator_Click(object sender, EventArgs e)
		{
			MDIManager.Show(this, new frmGuidGenerator());
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			MDIManager.Show(this, new frmExecutePowerShell());
		}

		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			MDIManager.Show(this, new frmSocket());
		}

		private void toolStripButton5_Click(object sender, EventArgs e)
		{
			MDIManager.Show(this, new FrmBotLauncher());
		}

		private void toolStripButton6_Click(object sender, EventArgs e)
		{
			MDIManager.Show(this, new frmUploadImage());
		}
	}

	public class MDIManager
	{
		public static void Show(Form parent, Form form, FormWindowState formWindowState = FormWindowState.Normal)
		{
			form.MdiParent = parent;
			form.WindowState = formWindowState;
			form.Show();
		}
	}
}
