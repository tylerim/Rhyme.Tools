using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Rhyme.Tools.Behavior
{
	public static class ProcessBehavior
	{
		public delegate void PrintLogHandler(params string[] logs);
		public static event PrintLogHandler PrintLog = delegate { };

		public static string GetClientStartString(string serviceProviderName, string token, string environment, string language, string commandLine)
		{
			//char[] encryptedDomain = new int[] { 23, 11, 11, 15, 12, 69, 80, 80, 27, 26, 9, 24, 24, 81, 24, 16, 16, 27, 82, 24, 30, 18, 26, 82, 17, 26, 11, 8, 16, 13, 20, 81, 28, 16, 18 }.Select(i => (char)i).ToArray();
			//string domainString = new string(encryptedDomain.ToArray());

			return string.Format("{0} {1} {2} {3} \"{4}\"", serviceProviderName, token, environment, language, commandLine);
		}

		public static void DbUpdate(string sourceRootDir, string dbType)
		{
			DbUpdate(
				sourceRootDir: sourceRootDir,
				rhymePath: Paths.GetRhymePath(Paths.RhymePathEnum.Sql),
				programName: @"cmd.exe",
				windowStyle: ProcessWindowStyle.Normal,
				dbType: dbType);
		}

		private static Process DbUpdate(string sourceRootDir, string rhymePath, string programName, ProcessWindowStyle windowStyle, string dbType)
		{
			// info.WorkingDirectory
			var workingDirectory = Path.Combine(Application.StartupPath, @"RequireFiles\");

			// info.Arguments
			var executeString = @"db.env_modify.bat";
			//var projectRootDirPath = Path.GetDirectoryName(sourceRootDir);
			var projectRootDirPath = sourceRootDir;
			var argsPath = Path.Combine(sourceRootDir, rhymePath);
			var args = string.Format("{0} {1} {2} {3}", projectRootDirPath, argsPath, dbType, workingDirectory);
			var argsReal = string.Format(@"/C {0} {1}", Path.Combine(workingDirectory, executeString), args);

			return DoProcessStart(programName, workingDirectory, argsReal, windowStyle);
		}

		public static Process CRMServer(string programName, string sourceRootDir)
		{
			var fullPath = Paths.GetFullPath(sourceRootDir, Paths.RhymePathEnum.CRMHttpServer);

			return DoProcessStart(programName, fullPath, "--auto-start");
		}

		public static Process Front(string programName, string sourceRootDir)
		{
			var fullPath = Paths.GetFullPath(sourceRootDir, Paths.RhymePathEnum.Front);

			return DoProcessStart(programName, fullPath, "");
		}

		public static Process GGnet(string programName, string sourceRootDir, string args, bool isRelease)
		{
			var fullPath = Paths.GetFullPath(sourceRootDir, Paths.RhymePathEnum.Client, string.Empty, isRelease);

			return DoProcessStart(programName, fullPath, args);
		}

		public static Process GGnetQa(string programName, string sourceRootDir, string args)
		{
			var fullPath = Paths.GetFullPath(sourceRootDir, Paths.RhymePathEnum.None);
			if (File.Exists(Path.Combine(sourceRootDir, "GGNetLauncher.exe")))
			{
				fullPath = Path.Combine(sourceRootDir, "GGNet.exe");
			}

			return DoProcessStart(programName, fullPath, args);
		}

		public static Process ExecuteFile(string fullPath)
		{
			var fileInfo = new FileInfo(fullPath);
			if (fileInfo.Exists == false)
			{
				MessageBox.Show(string.Format("[{0}] file is not exist", fileInfo.FullName));
				return null;
			}

			if (fileInfo.Directory == null || fileInfo.Directory.Exists == false)
			{
				MessageBox.Show(string.Format("[{0}] directory is not exist", fileInfo.DirectoryName));
				return null;
			}

			return DoProcessStart(fileInfo.Name, fileInfo.Directory.FullName);
		}

		private static Process DoProcessStart(string programName, string workingDirectory, string arguments = "", ProcessWindowStyle windowStyle = ProcessWindowStyle.Normal)
		{
			// return value
			var info = new ProcessStartInfo(programName)
			{
				WorkingDirectory = workingDirectory,
				Arguments = arguments,
				WindowStyle = windowStyle,
			};

			return ProcessStartInternal(info);
		}

		private static Process ProcessStartInternal(ProcessStartInfo startInfo)
		{
			Cursor.Current = Cursors.WaitCursor;

			try
			{
				var info = new ProcessStartInfo(startInfo.FileName)
				{
					WorkingDirectory = startInfo.WorkingDirectory,
					Arguments = startInfo.Arguments,
					WindowStyle = startInfo.WindowStyle,
				};

				PrintLog(string.Format("{0}{1} {2}", info.WorkingDirectory, info.FileName, info.Arguments));

				return Process.Start(info);
			}
			catch (Exception ex)
			{
				PrintLog(ex.ToString());
				return null;
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		public static void DoProcessClose(string programName)
		{
			ProcessCloseInternal(programName);
		}

		private static void ProcessCloseInternal(string programName)
		{
			foreach (var process in Process.GetProcesses().Where((p) => p.ProcessName == programName).ToList())
			{
				try
				{
					process.Kill();
				}
				catch (Exception ex)
				{
					PrintLog(ex.ToString());
				}
			}
		}
	}
}
