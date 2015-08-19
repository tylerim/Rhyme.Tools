using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Rhyme.Bootstrapper;
using Rhyme.Common;
using Rhyme.Common.Utilities;
using Rhyme.Tools.Behavior;
using Rhyme.Tools.Helper;
using Rhyme.Tools.Services.LoginTool.RhymeModule;

namespace Rhyme.Tools.Services.LoginTool
{
	public partial class frmMain : Form
	{
		//private Dictionary<int, Process> ExecuteProcessList = new Dictionary<int, Process>();

		private string GetSourceRootDir
		{
			get
			{
				if (rbSourceRootDir.Checked)
					return this.txtSourceRootDir.Text;
				else if (rbSourceRootDir2.Checked)
					return this.txtSourceRootDir2.Text;
				else if (rbSourceRootDir3.Checked)
					return this.txtSourceRootDir3.Text;

				return this.txtSourceRootDir.Text;
			}
		}

		public frmMain()
		{
			InitializeComponent();
			InitializeForm();
		}

		private void InitializeForm()
		{
			var mouseDoubleClick = new MouseEventHandler((sender, args) => { Process.Start((sender as TextBox).Text); });
			this.txtSourceRootDir.MouseDoubleClick += mouseDoubleClick;
			this.txtSourceRootDir2.MouseDoubleClick += mouseDoubleClick;
			this.txtSourceRootDir3.MouseDoubleClick += mouseDoubleClick;

			// Attach handler
			ProcessBehavior.PrintLog += AddLog;
			DbBehavior.PrintLog += AddLog;

			// set  the command line args.
			var commandLineArgs = Environment.GetCommandLineArgs();

			if (commandLineArgs.Count() == 3)
			{
				if (commandLineArgs[1].ToUpper() == "QA")
				{
					tabControl1.SelectedIndex = 1;
					this.txtSourceRootDir.Text = commandLineArgs[2];
				}
			}

			// QA 탭 감춤.
			tabControl1.SelectedTab.Visible = false;

			cbxClientCount.SelectedIndex = 0;
			cbxEnvironment.SelectedIndex = 0;

			//if (Screen.AllScreens.Length > 1)
			//{
			//	this.Location = new Point(Screen.AllScreens[1].WorkingArea.X, Screen.AllScreens[1].WorkingArea.Height - this.Height);
			//}
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
		}

		#region Start Program

		private void CopyXmlFile(string filename)
		{
			var frontPath = Paths.GetRhymePath(Paths.RhymePathEnum.Front);
			var frontFullPath = Path.Combine(this.GetSourceRootDir, frontPath, "Config");

			CopyXmlFileInternal(Path.Combine(Application.StartupPath, filename), Path.Combine(frontFullPath, filename));
		}

		private void CopyXmlFileToCRM(string filename)
		{
			var path = Paths.GetRhymePath(Paths.RhymePathEnum.CRMHttpServer);
			var fullPath = Path.Combine(this.GetSourceRootDir, path);

			CopyXmlFileInternal(Path.Combine(Application.StartupPath, filename), Path.Combine(fullPath, filename));
		}

		private void CopyXmlFileInternal(string sourceFileName, string destFileName)
		{
			try
			{
				File.Copy(sourceFileName, destFileName, true);
			}
			catch (Exception ex)
			{
				this.AddLog(ex.ToString());
			}
		}

		// Rhyme.CRM.Server.exe 시작 버튼
		private void button15_Click(object sender, EventArgs e)
		{
			//this.CopyXmlFileToCRM("TableManager.xml");

			var process = ProcessBehavior.CRMServer("Rhyme.CRM.Server.exe", this.GetSourceRootDir);

			if (Screen.AllScreens.Length > 1)
			{
				var position = new Point(Screen.AllScreens[1].WorkingArea.X + this.Width + 10, Screen.AllScreens[1].WorkingArea.Height - 600);
				Move(process, position);
			}
		}

		// Front.exe 시작 버튼
		private void button1_Click(object sender, EventArgs e)
		{
			//this.CopyXmlFile("ServiceConfiguration.xml");
			//this.CopyXmlFile("TableManager.xml");

			if (Process.GetProcesses().Any(p => p.ProcessName == "Front"))
			{
				if (MessageBox.Show("Close?", "Already Exists", MessageBoxButtons.OKCancel) == DialogResult.OK)
				{
					ProcessBehavior.DoProcessClose("Front");
				}
				else
				{
					return;
				}
			}

			var process = ProcessBehavior.Front("Front.exe", this.GetSourceRootDir);

			if (Screen.AllScreens.Length > 1)
			{
				Point position = new Point(Screen.AllScreens[1].WorkingArea.X, 530);
				Move(process, position);
			}
		}

		[DllImport("user32.dll", EntryPoint = "SetWindowPos")]
		public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);

		private static void Move(Process process, Point position)
		{
			var result = Task.Factory.StartNew(new Action(() =>
			{
				Thread.Sleep(500);
			}));

			result.Wait();

			SetWindowPos(process.MainWindowHandle, 0, position.X, position.Y, 0, 0, 0x01);
		}

		private async Task<string> GetVaultLoginToken(string environment, string userId, string password, string serviceProviderName)
		{
			this.AddLog("Start, Get Vault Token...");

			Cursor.Current = Cursors.WaitCursor;

			try
			{
				var token = await VaultLoginHelper.GetAuthToken(environment, userId, password);
				if (token == null)
				{
					this.AddLog(string.Format("vault_auth_failed : {0}, {1}, {2}", environment, userId, password));
					return null;
				}

				this.AddLog(string.Format("vault_login_token_info : {0}" , token));
				
				Guid resultGuid;
				return Guid.TryParse(token, out resultGuid) ? token : string.Empty;
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		private async Task<string> GetGpLoginToken(string environment, string userId, string password)
		{
			this.AddLog("Start, Get Gp Token...");

			Cursor.Current = Cursors.WaitCursor;

			try
			{
				var token = await GpLoginHelper.GetAuthToken(environment, userId, password);
				if (token == null)
				{
					this.AddLog(string.Format("gp_auth_failed : {0}, {1}, {2}", environment, userId, password));
					return null;
				}

				this.AddLog(string.Format("gp_login_token_info : {0} | {1}" , token.gp_id, token.token));
				
				Guid resultGuid;
				return Guid.TryParse(token.token, out resultGuid) == false
					? string.Empty
					: string.Format("{0}:{1}", token.token, token.gp_id);
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		// GGnet.exe 시작 버튼
		private async void btnStartAll_Click(object sender, EventArgs e)
		{
			// Preferences.xml 에 저장
			Preferences.WorkingDirectory = Path.Combine(this.GetSourceRootDir, Paths.GetRhymePath(Paths.RhymePathEnum.Client));

			if (File.Exists(Path.Combine(this.GetSourceRootDir, "GGNetLauncher.exe")))
			{
				Preferences.WorkingDirectory = this.GetSourceRootDir;
			}

			ServiceProviderHelper.OnlyInLoginToolSetConvertedSpName(txtServiceProviderName.Text);

			// use txtFrontIP.Text if DEV
			if (isReleaseCheckBox.Checked == false)
			{
				Preferences.Initialize();
				Preferences.SetValue(Configurations.ServerAddress, this.txtFrontIP.Text);
				Preferences.Shutdown();
			}

			var serviceProviderName = txtServiceProviderName.Text;
			var env = cbxEnvironment.Text.ToLower();
			var language = txtLanguage.Text;
			var idNumberString = txtTestClientIdList.Text ?? "";
			var idPrefix = txtPrefix.Text ?? "";
			var commandLine = commandLineTextBox.Text;
			var isReleaseChecked = isReleaseCheckBox.Checked;

			int idNumber;
			var isBoolIdNumber = int.TryParse(txtTestClientIdList.Text, out idNumber);
			var clientCount = Convert.ToInt32(cbxClientCount.Text);
			var password = txtPassword.Text;

			var isLoginTokenFromGp = rbGp.Checked;

			for (var i = clientCount - 1; i >= 0; i--)
			{
				var refI = i;

				await Task.Run(() =>
				{
					var testClientId = "";
					if (isBoolIdNumber)
						testClientId = string.Format("{0}{1}", idPrefix, (idNumber + refI));
					else
						testClientId = string.Format("{0}{1}", idPrefix, idNumberString);

					var loginToken = "";
					if (isLoginTokenFromGp)
					{
						// must change
						serviceProviderName = "GP";

						// login_token:gp_id
						loginToken = GetGpLoginToken(env, testClientId, password).Result;
					}
					else
					{
						loginToken = GetVaultLoginToken(env, testClientId, password, serviceProviderName).Result;
					}
					
					if (string.IsNullOrEmpty(loginToken) || loginToken == Guid.Empty.ToString())
					{
						AddLog(string.Format("invalid token : {0}", loginToken));
						return;
					}

					var args = ProcessBehavior.GetClientStartString(serviceProviderName, loginToken, env, language, commandLine);

					ProcessBehavior.GGnet("GGnet.exe", this.GetSourceRootDir, args, isReleaseChecked);
				});

				await Task.Delay(100);
			}

			//var list = this.txtTestClientIdList.Text.Split(',');

			//foreach (var id in list)
			//{
			//	var liveToken = this.GetVaultLoginToken(this.txtEnvironment.Text, string.Format("t{0}", id.Trim()), "1");

			//	var args = ProcessBehavior.GetClientStartString(liveToken, this.txtEnvironment.Text, this.txtLanguage.Text);

			//	ProcessBehavior.GGnet("GGnet.exe", this.GetSourceRootDir, args);
			//}
		}

		#endregion

		#region Terminate

		private void button3_Click(object sender, EventArgs e)
		{
			ProcessBehavior.DoProcessClose("Front");
		}
		private void button4_Click(object sender, EventArgs e)
		{
			ProcessBehavior.DoProcessClose("GGnet");
		}
		private void button14_Click(object sender, EventArgs e)
		{
			ProcessBehavior.DoProcessClose("Rhyme.CRM.Server");
		}

		private void btnKillProcessRhymeBot_Click(object sender, EventArgs e)
		{
			ProcessBehavior.DoProcessClose("Rhyme.Bot");
		}

		#endregion

		#region Test Methods

		// Get token to textbox
		private void button16_Click(object sender, EventArgs e)
		{
			// NOTE : GG ... is temp ...
			var response = this.GetVaultLoginToken(this.txtTestEnvironment.Text, this.txtTestUserId.Text, this.txtTestUserPassword.Text, "GG").Result;
			this.txtAcquireToken.Text = response;
		}

		#endregion

		#region Tab2 - QA

		private void btnQAClientStart_Click(object sender, EventArgs e)
		{
			var list = this.txtQATestClientIdList.Text.Split(',');

			foreach (var id in list)
			{
				// NOTE : GG ... is temp ...
				var liveToken = this.GetVaultLoginToken(this.txtQAEnvironment.Text, string.Format("{0}", id.Trim()), "1", "GG").Result;

				var args = ProcessBehavior.GetClientStartString(txtServiceProviderName.Text, liveToken, this.txtQAEnvironment.Text, this.txtQALanguage.Text, this.commandLineTextBox.Text);

				ProcessBehavior.GGnetQa("GGnet.exe", this.GetSourceRootDir, args);
			}
		}

		#endregion

		#region Change, Lobby & GameTable for Jump

		private void btnClientCaptionChange_Click(object sender, EventArgs e)
		{
			int i = 0;
			string baseMainWindowTitle = "GGpoker";

			foreach (var process in Process.GetProcesses().Where((p) => p.ProcessName == "GGnet").ToList().OrderBy(list => list.Id))
			{
				// Window 핸들 얻기
				var window = NativeMethodsHelper.FindWindow(null, process.MainWindowTitle);

				var sb = new StringBuilder(500);
				var length = NativeMethodsHelper.GetWindowText(window, sb, 500);
				if (length > 0)
				{
					var title = sb.ToString();

					if (title.Contains(baseMainWindowTitle) == false)
						continue;
				}

				// 캡션 변경
				//NativeMethodsHelper.SetWindowText(window, string.Format("{0} - {1}", baseMainWindowTitle, process.Id));

				// 위치 정렬
				if (i < 12)
				{
					NativeMethodsHelper.MoveWindow(process.MainWindowHandle, WindowBehavior.Instance.WindowPositions[i].X, WindowBehavior.Instance.WindowPositions[i].Y, WindowBehavior.Instance.WindowPositions[i].Width, WindowBehavior.Instance.WindowPositions[i].Height, true);
				}

				i++;

				// 창 Foreground 처리
				NativeMethodsHelper.SetForegroundWindow(window);
			}
		}

		private void btnMoveHoldemTable_Click(object sender, EventArgs e)
		{
			var gameTableWindowList = new Dictionary<string, IntPtr>();

			var childs = NativeMethodsHelper.GetAllWindows();
			foreach (var handle in childs)
			{
				var sb = new StringBuilder(500);

				var length = NativeMethodsHelper.GetWindowText((IntPtr)handle, sb, 500);
				if (length <= 0)
					continue;

				var title = sb.ToString();

				var pattern = @"\[(?<NickName>.*)\]\[(?<TableId>.*)\]\[(?<JumpEntryId>.*)\]";
				foreach (Match m in Regex.Matches(title, pattern))
				{
					if (m.Success == false)
						continue; ;

					var nickName = m.Groups["NickName"];
					var tableId = m.Groups["TableId"];
					var jumpEntryId = m.Groups["JumpEntryId"];

					// JumpEntryId -> NickName 순으로 정렬
					gameTableWindowList.Add(string.Format("{0}.{1}", tableId, nickName), (IntPtr)handle);
				}
			}

			// 정렬
			if (gameTableWindowList.Count == 0)
				return;

			// 위치 정렬
			var tableIdList = gameTableWindowList.GroupBy(g => g.Key.Split('.')[0]).ToList().OrderBy(list => list.Key).ToList();
			if (tableIdList.Count > 0)
			{
				int yLocation = 0;
				foreach (var tableIdKV in tableIdList)
				{
					var tableId = tableIdKV.Key;
					var lists = gameTableWindowList.Where(g => g.Key.Split('.')[0] == tableId).OrderBy(g => g.Key).Select(g => g.Value).ToList();

					this.MoveGameTable(tableId, lists, yLocation++);
				}
			}
		}

		private void MoveGameTable(string tableId, List<IntPtr> lists, int yLocation)
		{
			int xDelimiter = 0;
			int yDelimiter = yLocation;
			foreach (var handle in lists)
			{
				// 위치 정렬
				var rect = WindowBehavior.GetRectangle(xDelimiter, yDelimiter);

				NativeMethodsHelper.MoveWindow(handle, rect.X, rect.Y, rect.Width, rect.Height, true);

				// 창 Foreground 처리
				NativeMethodsHelper.SetForegroundWindow(handle);

				xDelimiter++;
			}
		}

		#endregion

		#region Log

		private void btnLogClear_Click(object sender, EventArgs e)
		{
			this.lbLog.Items.Clear();
		}

		private void AddLog(params string[] logs)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new Action(() => AddLog(logs)));
				return;
			}

			foreach (var log in logs)
			{
				this.lbLog.Items.Add(log);
			}

			this.lbLog.SetSelected(this.lbLog.Items.Count - 1, true);
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (this.lbLog.SelectedItem == null)
				return;

			Clipboard.SetText(this.lbLog.SelectedItem.ToString());
		}

		#endregion

		#region DB Update

		private void btnDbUpdate_RB_Click(object sender, EventArgs e)
		{
			this.DoProcessStartDbUpdate("RB");
		}

		private void btnDbUpdate_CRM_Click(object sender, EventArgs e)
		{
			this.DoProcessStartDbUpdate("CRM");
		}

		private void DoProcessStartDbUpdate(string dbType)
		{
			ProcessBehavior.DbUpdate(this.GetSourceRootDir, dbType);
		}

		#endregion

		private void btnLogClient_Click(object sender, EventArgs e)
		{
			var fullPath = Paths.GetFullPath(this.GetSourceRootDir, Paths.RhymePathEnum.Client, "Logs");
			if (Directory.Exists(fullPath) == false)
				Directory.CreateDirectory(fullPath);

			Process.Start(fullPath);
		}

		private void btnLogServer_Click(object sender, EventArgs e)
		{
			var fullPath = Paths.GetFullPath(this.GetSourceRootDir, Paths.RhymePathEnum.Front, "Logs");
			if (Directory.Exists(fullPath) == false)
				Directory.CreateDirectory(fullPath);

			Process.Start(fullPath);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var fullPath = Paths.GetFullPath(this.GetSourceRootDir, Paths.RhymePathEnum.CRMHttpServer, "Logs");
			if (Directory.Exists(fullPath) == false)
				Directory.CreateDirectory(fullPath);

			Process.Start(fullPath);
		}

		private void btnDbExecute_Click(object sender, EventArgs e)
		{
			try
			{
				DbBehavior.DbConnectionString = this.txtDbConnectionString.Text;

				var tourneyTemplateId = int.Parse(this.txtTourneyTemplateId.Text);
				var bufferTime = int.Parse(this.txtBufferTime.Text);

				var result = DbBehavior.CreateTourney(tourneyTemplateId, bufferTime);

				AddLog("Result code : ", result.ToString());
			}
			catch (Exception ex)
			{
				AddLog("Exception : ", ex.ToString());
			}
		}

		private void btnViewTourney_Click(object sender, EventArgs e)
		{
			try
			{
				DbBehavior.DbConnectionString = this.txtDbConnectionString.Text;

				var form = new frmViewTourney();
				form.Show();
			}
			catch (Exception ex)
			{
				AddLog("Exception : ", ex.ToString());
			}
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			try
			{
				DbBehavior.DbConnectionString = this.txtDbConnectionString.Text;

				var dateTime = DbBehavior.ExecuteSql("Select Getdate() as MSSQLServerDate").Rows[0][0];

				AddLog("Now db server datetime : ", dateTime.ToString());
			}
			catch (Exception ex)
			{
				AddLog("Exception : ", ex.ToString());
			}
		}

		private void btnStartLive_Click(object sender, EventArgs e)
		{
			ProcessBehavior.ExecuteFile(txtLivePath.Text);
		}

		private void btnStartUAT_Click(object sender, EventArgs e)
		{
			ProcessBehavior.ExecuteFile(txtUATPath.Text);
		}
	}
}
