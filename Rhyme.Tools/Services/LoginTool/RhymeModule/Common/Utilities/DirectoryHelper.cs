using System;
using System.IO;

namespace Rhyme.Tools.Services.LoginTool.RhymeModule.Common.Utilities
{
	public static class DirectoryHelper
	{
		//public static string GetBaseDirectory()
		//{
		//	RegistryKey dir = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\RichBitch",
		//		RegistryKeyPermissionCheck.Default);

		//	// [hdkim]
		//	// Must not Use Environment.CurrentDirectory Property, Because It is variable Property regardless of your intention
		//	// if You get File by FileOpenDialog Method, Environment.CurrentDirectory Property Value is changed by OpenFilePath in WindowsXP
		//	if (dir == null)
		//		return AppDomain.CurrentDomain.BaseDirectory;

		//	object value = dir.GetValue("Path");

		//	if (value != null && DesignerProperties.GetIsInDesignMode(new DependencyObject()))
		//		return value as string;

		//	try
		//	{
		//		// [hdkim]
		//		// if You set Registery Value, You use RegistryValueKind.String Option Value, because This SetValue Method don't realize space character
		//		if (DesignerProperties.GetIsInDesignMode(new DependencyObject()) == false)
		//			dir.SetValue("Path", AppDomain.CurrentDomain.BaseDirectory, RegistryValueKind.String);
		//	}
		//	catch (UnauthorizedAccessException ex)
		//	{
		//		Logger.Log(LogInfo.Debug, "GetBaseDirectory: CommunicationException {0}", ex.ToString());
		//	}

		//	return AppDomain.CurrentDomain.BaseDirectory;
		//}

		public static string GetAppDataDirectory()
		{
			var spName = "\\" + GetServiceProviderFullName() + "\\";
#if DEBUG
			spName = "\\GGNETDEBUG\\";
#endif
			var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + spName;

			if (Directory.Exists(path) == false)
			{
				Directory.CreateDirectory(path);
			}

			return path;
		}

		/// <summary>
		/// Program files에 있는 옛 클라이언트 경로를 가져옴 (존재하지 않을수도 있음)
		/// </summary>
		/// <returns></returns>
		//public static string GetProgramFilesPath()
		//{
		//	var spName = ServiceProviderHelper.GetConvertedSpName();
		//	string targetFolderName;
		//	switch (spName)
		//	{
		//		case "GG":
		//			{
		//				targetFolderName = "GGpokernet";
		//			}
		//			break;
		//		case "GGPOKER.COM":
		//			{
		//				targetFolderName = "GGpoker";
		//			}
		//			break;
		//		case "HAHA":
		//			{
		//				targetFolderName = "HaHapoker";
		//			}
		//			break;
		//		case "AHAH":
		//			{
		//				targetFolderName = "LGpoker";
		//			}
		//			break;
		//		case "DFP":
		//			{
		//				targetFolderName = "巅峰扑克";
		//			}
		//			break;
		//		case "TNL":
		//			{
		//				targetFolderName = "Tianlong";
		//			}
		//			break;
		//		case "CPA":
		//			{
		//				targetFolderName = "4playpoker";
		//			}
		//			break;
		//		case "A303":
		//		case "IAO":
		//		case "ITCB":
		//			{
		//				targetFolderName = spName;
		//			}
		//			break;
		//		case "88FOXGG":
		//			{
		//				targetFolderName = "88FoxGG";
		//			}
		//			break;
		//		case "OMGFISH":
		//			{
		//				targetFolderName = "OMGfish";
		//			}
		//			break;
		//		case "RED6POKER":
		//			{
		//				targetFolderName = "Red6poker";
		//			}
		//			break;
		//		default:
		//			{
		//				//APES, ALLNEWPOKER는 프로그램파일 폴더가 없음
		//				targetFolderName = string.Empty;
		//			}
		//			break;
		//	}

		//	return string.Format("{0}\\{1}\\", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), targetFolderName);
		//}

		private static string GetServiceProviderFullName()
		{
			var spName = ServiceProviderHelper.GetConvertedSpName();

			switch (spName)
			{
				case "GG":
					return "GGpokernet";
				case "GGPOKER.COM":
					return "GGpoker";
				case "HAHA":
					return "HaHapoker";
				case "AHAH":
					return "LGpoker";
				case "DFP":
					return "巅峰扑克";
				case "TNL":
					return "TianLong";
				case "CPA":
					return "4playpoker";
				case "A303":
					return "A303";
				case "IAO":
					return "IAO";
				case "ITCB":
					return "ITCB";
				case "88FOXGG":
					return "88FoxGG";
				case "OMGFISH":
					return "OMGfish";
				case "RED6POKER":
					return "Red6poker";
				case "ALLNEWPOKER":
					return "AllNewPoker";
				case "APESPOKER":
					return "ApesPoker";
				default:
					return spName + "poker";
			}

			throw new NotImplementedException("AppDataService_GetServiceProviderFullName");
		}
	}
}
