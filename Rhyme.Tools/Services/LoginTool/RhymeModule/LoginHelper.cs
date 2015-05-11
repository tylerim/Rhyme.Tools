using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Rhyme.Bootstrapper.Service;

namespace WindowsFormsApplication1
{
	public class ServiceProviderInformation
	{
		public string Name { get; set; }
		public string ServiceProviderName { get; set; }
		public string EnvironmentName { get; set; }
	}

	public static class LoginHelper
	{
		public static string UserId { get; set; }
		public static string UserPassword { get; set; }
		public static string Domain { get; set; }
		public static string ServiceProviderName { get; set; }
		public static string EnvironmentName { get; set; }
		public static BackupDomain _backupDomain = new BackupDomain();

		//private static void InitializeServiceProviderCustomization(string serviceProviderName)
		//{
		//	try
		//	{
		//		var spName = serviceProviderName;
		//		switch (spName)
		//		{
		//			case "GGNETPRO":
		//			case "GGREGULAR":
		//				spName = "GG";
		//				break;

		//			case "A303":
		//			case "IAO":
		//			case "ITCB":
		//				spName = "CPA";
		//				break;
		//		}

		//		//var icon = new BitmapImage();
		//		//icon.BeginInit();
		//		//icon.UriSource =
		//		//    new Uri(string.Format("pack://application:,,,/GGnetLauncher;component/Resources/Common/Icon/{0}.ico", spName));
		//		//icon.EndInit();
		//		//icon.Freeze();

		//		//Icon = icon;
		//	}
		//	catch (Exception ex)
		//	{
		//		//var icon = new BitmapImage();
		//		//icon.BeginInit();
		//		//icon.UriSource =
		//		//    new Uri(string.Format("pack://application:,,,/GGnetLauncher;component/Resources/Common/Icon/Rhyme.ico"));
		//		//icon.EndInit();
		//		//icon.Freeze();

		//		//Icon = icon;
		//	}
		//}

		public static string GetToken()
		{
			//using (var file = File.OpenText("ServiceProviderInformation.xml"))
			//{
			//	var information = new XmlSerializer(typeof(ServiceProviderInformation)).Deserialize(file) as ServiceProviderInformation;
			//	if (information == null)
			//	{
			//		//Coudn't find ServiceProviderInformation.xml
			//		MessageBox.Show("Failure to Login.  Please try again.  Error Code: 13502", "Poker", MessageBoxButtons.OK, MessageBoxIcon.Error);

			//		return null;
			//	}

			//	if (information.Name == "ONGATE" && Environment.GetCommandLineArgs().Length == 1)
			//	{
			//		MessageBox.Show("Please launch client via homepage");
			//		Environment.Exit(-1);
			//	}

			//	//InitializeServiceProviderCustomization(information.Name);

			//	return LoginHelper.Start(information);
			//}

			var information = new ServiceProviderInformation { ServiceProviderName = "GG" };
			return LoginHelper.Start(information);
		}

		private static string Start(ServiceProviderInformation spInformation)
		{
			ServiceProviderName = spInformation.ServiceProviderName;
			EnvironmentName = spInformation.EnvironmentName ?? "Live";

			//_backupDomain.BlockCurrentBackupDomain(ServiceProviderName, EnvironmentName);
			Domain = _backupDomain.GetBackupDomain(ServiceProviderName, EnvironmentName);

			EnvironmentName = "DEV";
			ViewModel_OnEnvironmentChanged(null, null);

#if DEBUG
			if (EnvironmentName.ToLower().Equals("dev"))
			{
				//Preferences.SetValue(Configurations.ServerAddress, viewModel.ServerAddress);
			}
#endif
			return AcquireToken();
		}

		private static void GetUrlForUat(out string url, out bool isShowMembersButton)
		{
			isShowMembersButton = true;

			switch (ServiceProviderName)
			{
				case "GGNETPRO":
					url = "uatpro.good-game-network.com";
					break;

				case "GGREGULAR":
					url = "uatregular.good-game-network.com";
					break;

				case "HAHA":
					url = "uathaha.good-game-network.com";
					break;

				case "AHAH":
					url = "uatahah.good-game-network.com";
					isShowMembersButton = false;
					break;

				case "ONGATE":
					url = "testggpoker.ongate.com";
					isShowMembersButton = false;
					break;

				case "DFP":
					url = "uat.dfplayer.com";
					break;

				case "W88":
					url = "api.w88uat.com";
					break;

				case "TNL":
					url = "210.56.53.112:8088";
					break;

				case "MANGO":
					url = "testmango.ggpoker.net";
					break;

				case "CPA":
					url = "uat.4playpoker.com";
					isShowMembersButton = false;
					break;

				case "A303":
					url = "ua303.clubpoker.asia";
					isShowMembersButton = false;
					break;

				case "IAO":
					url = "uiao.clubpoker.asia";
					isShowMembersButton = false;
					break;

				case "ITCB":
					url = "uitcb.clubpoker.asia";
					isShowMembersButton = false;
					break;

				case "GG":
				default:
					url = "uatgg.good-game-network.com";
					break;
			}
		}

		private static void GetUrlForStress(out string url, out bool isShowMembersButton)
		{
			isShowMembersButton = true;

			switch (ServiceProviderName)
			{
				case "W88":
					url = "integration.aqzbouat.com";
					break;

				case "GG":
				default:
					url = "stress.ggpoker.net";
					break;
			}
		}

		private static void GetUrl(out string url, out bool isShowMembersButton)
		{
			isShowMembersButton = true;

			switch (ServiceProviderName)
			{
				case "HAHA":
					url = "haha.good-game-network.com";
					break;

				case "AHAH":
					url = "ahah.good-game-network.com";
					isShowMembersButton = false;
					break;

				case "PGR":
					url = "www.pgrpoker.com";
					isShowMembersButton = false;
					break;

				case "GGNETPRO":
					url = "pro.good-game-network.com";
					isShowMembersButton = false;
					break;

				case "GGREGULAR":
					url = "regular.good-game-network.com";
					isShowMembersButton = false;
					break;

				case "ONGATE":
					url = "ggpoker.ongate.com";
					isShowMembersButton = false;
					break;

				case "DFP":
					url = "www.dfplayer.com";
					break;

				case "W88":
					url = "poker.w88api.com";
					break;

				case "TNL":
					url = "www.tianlongpoker.net";
					break;

				case "MANGO":
					url = "testmango.ggpoker.net";
					break;

				case "CPA":
					url = "4play.clubpoker.asia";
					isShowMembersButton = false;
					break;

				case "A303":
					url = "a303.clubpoker.asia";
					isShowMembersButton = false;
					break;

				case "IAO":
					url = "iao.clubpoker.asia";
					isShowMembersButton = false;
					break;

				case "ITCB":
					url = "itcb.clubpoker.asia";
					isShowMembersButton = false;
					break;

				case "GG":
				default:
					url = "gg.good-game-network.com";
					break;
			}
		}

		private static void ViewModel_OnEnvironmentChanged(object sender, EventArgs e)
		{
			//var viewModel = sender as LoginWindowViewModel;
			//Trace.Assert(viewModel != null);

			//EnvironmentName = viewModel.SelectedEnvironment;

			string url;
			var isShowMembersButton = true;

			switch (EnvironmentName.ToLower())
			{
				case "dev":
				case "test":
					url = ServiceProviderName.ToLower() == "mango" ? "devmango.ggpoker.net" : "dev.ggpoker.net";
					break;

				case "uat":
					GetUrlForUat(out url, out isShowMembersButton);
					break;

				case "stress":
					GetUrlForStress(out url, out isShowMembersButton);
					break;

				case "live":
					GetUrl(out url, out isShowMembersButton);
					break;

				default:
					Debug.Assert(false, "wrong environment");
					url = "www.ggpoker.net";
					break;
			}

			Domain = _backupDomain.GetBackupDomain(ServiceProviderName, EnvironmentName) ?? url;
		}

		private static string GetProtocol()
		{
			switch (ServiceProviderName)
			{
				// TODOW88 Once W88 integration is started, add entries for BET8 in Front/SP.xml as well(JooKwan's work) 
				case "HAHA":
				case "GG":
				case "GGNETPRO":
				case "GGREGULAR":
					return "https";

				case "DFP":
				case "W88":
					return EnvironmentName == "UAT" ? "http" : "https";

				// TODOSSL : once the certificate is installed on DEV and LIVE for other SPs, change the protocol to https.
				case "AHAH":
				case "TNL":
				case "MANGO":
				case "CPA":
				case "A303":
				case "IAO":
				case "ITCB":
				default:
					return "http";
			}
		}





		private static string GetHash(string userName, string password)
		{
			var hash = userName + password + "McjSIBDK2d";

			using (var md5 = MD5.Create())
			{
				var data = md5.ComputeHash(Encoding.Default.GetBytes(hash));

				StringBuilder stringBuilder = new StringBuilder();

				for (int i = 0; i < data.Length; i++)
				{
					stringBuilder.Append(data[i].ToString("x2"));
				}

				return stringBuilder.ToString();
			}
		}

		public static string GetResponse<T>(string url, T postData)
		{
			var request = (HttpWebRequest)WebRequest.Create(new Uri(url));
			request.Proxy = null;
			request.Method = "POST";
			//request.Timeout = (int)TimeSpan.FromSeconds(10).TotalMilliseconds;

			var sb = new StringBuilder();

			if (typeof(T) == typeof(string))
			{
				sb.Clear();
				sb.Append(postData);
			}
			else
			{
				throw new NotImplementedException();
				//new JsonSerializer().Serialize(new StringWriter(sb), postData);
			}

			var data = Encoding.UTF8.GetBytes(sb.ToString());
			request.ContentLength = data.Length;
			request.ContentType = "application/json; charset=utf-8";

			using (var newStream = request.GetRequestStream())
			{
				newStream.Write(data, 0, data.Length);
				newStream.Close();
			}

			var readedString = "";
			using (var response = (HttpWebResponse)request.GetResponse())
			{
				readedString = CheckBlockedDomain(response);
			}

			return readedString;
		}

		private static string CheckBlockedDomain(HttpWebResponse response)
		{
			// check warning page's url
			if (response.ResponseUri.ToString().Equals("http://www.warning.or.kr/"))
				return "IsBlockedDomain";

			// read string
			var readedString = string.Empty;
			using (var reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
			{
				readedString = reader.ReadToEnd();
			}

			// check meta tag
			var metaNameIndex = readedString.IndexOf("<meta name=");
			if (metaNameIndex != -1)
			{
				var metaName = readedString.Substring(metaNameIndex + 12, 4);
				if (metaName == "kcsc")
					return "IsBlockedDomain";
			}

			return readedString;
		}

		private static string AcquireToken()
		{
			//args.Failed = true;

			try
			{
				//Debug.WriteLine("Trying to login");

				//var viewModel = sender as LoginWindowViewModel;
				//Debug.Assert(viewModel != null);

				var protocol = GetProtocol();
				var url = string.Format("{0}://{1}/login", protocol, Domain);
				var hash = string.Empty;

				switch (ServiceProviderName)
				{
					case "W88":
						// if sp name is W88, attach hash at the login param
						hash = string.Format(",\"Hash\":\"{0}\"", GetHash(UserId, UserPassword));
						break;
					case "TNL":
						var suffix = string.Empty;
						if (EnvironmentName == "Live")
							suffix = "/ggpoker";
						url = string.Format("{0}://{1}{2}/login_ggp.aspx", protocol, Domain, suffix);
						break;
				}

				var response = GetResponse(url, string.Format("{{\"Mode\":\"ClientLogin\",\"Username\":\"{0}\",\"Password\":\"{1}\"{2}}}", UserId, UserPassword, hash));

				//Stopwatch sw = new Stopwatch();
				//sw.Start();
				//for (int i = 0; i < 30; i++)
				//{
				//	response = GetResponse(url, string.Format("{{\"Mode\":\"ClientLogin\",\"Username\":\"{0}\",\"Password\":\"{1}\"{2}}}", UserId, UserPassword, hash));
				//}
				//sw.Stop();
				//Debug.WriteLine(sw.Elapsed);

				// check redirect to warning page
				if (response == "IsBlockedDomain")
				{
					//args.ErrorString = "ErrorLoginServerNotFound";
					MessageBox.Show("ErrorLoginServerNotFound");

					return response;
				}

				var correctTokenLength = Guid.NewGuid().ToString().Length;

				// if [token] + & + [check T&C agree flag(Y or N]
				if (response.Length == correctTokenLength + 2 && response.Contains('&'))
				{
					// split token and flag
					var payload = response.Split('&');

					response = payload[0];

					// blocked T&C window
					/*var checkAgree = payload[1];
					if (checkAgree.Equals("N"))
					{
						// if did not agree Terms & Condition, pop up Terms & Condition window
						viewModel.Dispatcher.Invoke(new Action(() =>
						{
							var window = new TermsAndConditionWindow();
							Debug.Assert(window != null);

							window.LoginUrl = url;
							window.Username = args.Username;

							window.ViewModel.TermsAndConditionUrl = string.Format("{0}://{1}/contents/term.php", protocol, Domain);
							window.ViewModel.PrivacyPolicyUrl = string.Format("{0}://{1}/contents/policy.php", protocol, Domain);

							window.ShowDialog();
						}));
					}*/
				}

				// is not a token
				if (response.Length != correctTokenLength && (response.Contains("-") == false || response.Contains("<")))
				{
					//args.ErrorString = response;
					//Debug.WriteLine("Login failed, Reason: {0}", StringTable.GetString(args.ErrorString));
					MessageBox.Show(response, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

					return null;
				}

				return response;
			}
			catch (Exception e)
			{
				//args.ErrorString = "ErrorLoginUnknownError";
				//Debug.WriteLine("Login failed, Reason: {0}", StringTable.GetString(args.ErrorString));
				//Debug.WriteLine("Exception Reason: {0}", e.ToString());

				MessageBox.Show(e.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return null;
			}
		}

		public static bool ValidateTokenString(string tokenString)
		{
			Guid result;
			return Guid.TryParse(tokenString, out result);
		}
	}
}
