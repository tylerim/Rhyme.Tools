using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

using Rhyme.Tools.Services.BotLauncher;
using Rhyme.Tools.Services.ExecutePowerShell;
using Rhyme.Tools.Services.GuidGenerator;
using Rhyme.Tools.Services.HandIdConverter;
using Rhyme.Tools.Services.LoginTool;
using Rhyme.Tools.Services.Socket;
using Rhyme.Tools.Services.Tourney;
using Rhyme.Tools.Services.UploadImage;

namespace Rhyme.Tools
{
	public partial class frmMainContainer : Form
	{
		public frmMain FrmLoginTool;
		public TourneyForm FrmTourney;
		public frmUploadImage FrmUploadImage;
		public frmHandIdConverter FrmHandIdConverter;
		public frmGuidGenerator FrmGuidGenerator;
		public frmExecutePowerShell FrmExecutePowerShell;
		public frmSocket FrmSocket;
		public List<FrmBotLauncher> FrmBotLaunchers;
 
		public frmMainContainer()
		{
			InitializeComponent();
			MDIManager.ParentForm = this;
		}

		private void frmMainContainer_Load(object sender, EventArgs e)
		{
			Text = string.Format("{0} - {1}", Text, Assembly.GetExecutingAssembly().GetName().Version);

			FrmLoginTool = new frmMain();
			FrmHandIdConverter = new frmHandIdConverter();
			FrmGuidGenerator = new frmGuidGenerator();
			FrmUploadImage = new frmUploadImage();
			FrmTourney = new TourneyForm();
			FrmExecutePowerShell = new frmExecutePowerShell();
			FrmSocket = new frmSocket();
			
			FrmBotLaunchers = new List<FrmBotLauncher>() { new FrmBotLauncher() };
			
			MDIManager.Show(FrmHandIdConverter);
			MDIManager.Show(FrmGuidGenerator);
			MDIManager.Show(FrmExecutePowerShell);
			MDIManager.Show(FrmSocket);
			MDIManager.Show(FrmBotLaunchers[0]);
			MDIManager.Show(FrmUploadImage);
			MDIManager.Show(FrmTourney);
			
			MDIManager.Show(FrmLoginTool, FormWindowState.Maximized);
		}

		private void toolStripButton_LoginTool_Click(object sender, EventArgs e)
		{
			if (FrmLoginTool == null)
			{
				FrmLoginTool = new frmMain();
			}
			MDIManager.Show(FrmLoginTool);
		}

		private void toolStripButton_HandIdConverter_Click(object sender, EventArgs e)
		{
			if (FrmHandIdConverter == null)
			{
				FrmHandIdConverter = new frmHandIdConverter();
			}
			MDIManager.Show(FrmHandIdConverter);
		}

		private void toolStripButton_GuidGenerator_Click(object sender, EventArgs e)
		{
			if (FrmGuidGenerator == null)
			{
				FrmGuidGenerator = new frmGuidGenerator();
			}
			MDIManager.Show(FrmGuidGenerator);
		}

		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			if (FrmExecutePowerShell == null)
			{
				FrmExecutePowerShell = new frmExecutePowerShell();
			}
			MDIManager.Show(FrmExecutePowerShell);
		}

		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			if (FrmSocket == null)
			{
				FrmSocket = new frmSocket();
			}
			MDIManager.Show(FrmSocket);
		}

		private void toolStripButton5_Click(object sender, EventArgs e)
		{
			if (FrmBotLaunchers.Count == 0)
			{
				FrmBotLaunchers.Add(new FrmBotLauncher());
			}
			MDIManager.Show(FrmBotLaunchers[0]);
		}

		private void toolStripButton6_Click(object sender, EventArgs e)
		{
			if (FrmUploadImage == null)
			{
				FrmUploadImage = new frmUploadImage();
			}
			MDIManager.Show(FrmUploadImage);
		}

		private void toolStripButton7_Click(object sender, EventArgs e)
		{
			if (FrmTourney == null)
			{
				FrmTourney = new TourneyForm();
			}
			MDIManager.Show(FrmTourney);
		}
	}

	public class MDIManager
	{
		public static frmMainContainer ParentForm;

		public static void Show(Form form, FormWindowState formWindowState = FormWindowState.Normal)
		{
			form.MdiParent = ParentForm;
			if (formWindowState == FormWindowState.Maximized)
				form.WindowState = formWindowState;
			form.Show();
			form.Activate();
		}
	}
}
