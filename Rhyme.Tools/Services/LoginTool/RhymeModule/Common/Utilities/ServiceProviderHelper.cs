using System;
using System.Diagnostics;

namespace Rhyme.Tools.Services.LoginTool.RhymeModule.Common.Utilities
{
	public static class ServiceProviderHelper
	{
		private static string _spName;

		public static string ConvertSpName(string spName)
		{
			if (string.IsNullOrEmpty(spName))
				Debug.Assert(false, "It not exsits Service provider name.");

			//Logger.Log(LogInfo.Info, new
			//{
			//	Event = "a_service_provider_name_is_being_converted_to_client's_expression",
			//	ServiceProviderName = spName,
			//});

			var convertedSpName = spName.ToUpper();

			switch (convertedSpName)
			{
				case "GGPOKER":
					convertedSpName = "GGPOKER.COM";
					break;
				case "HAHAPOKER":
					convertedSpName = "HAHA";
					break;
				case "LGPOKER":
					convertedSpName = "AHAH";
					break;
				case "DFPLAYER":
					convertedSpName = "DFP";
					break;
				case "TIANLONG":
					convertedSpName = "TNL";
					break;
				case "4PLAYPOKER":
					convertedSpName = "CPA";
					break;
				case "88FOXPOKER":
					convertedSpName = "88FOXGG";
					break;
			}

			//Logger.Log(LogInfo.Info, new
			//{
			//	Event = "a_service_provider_name's_converting_is_done",
			//	UpdatedServiceProviderName = convertedSpName,
			//});

			_spName = convertedSpName;

			return convertedSpName;
		}
		public static string GetConvertedSpName()
		{
			if (string.IsNullOrEmpty(_spName))
			{
				_spName = ConvertSpName(Environment.GetCommandLineArgs()[1]);
			}

			return _spName;
		}

		[Obsolete]
		public static void OnlyInLoginToolSetConvertedSpName(string serviceProviderName)
		{
			_spName = serviceProviderName;
		}
	}
}
