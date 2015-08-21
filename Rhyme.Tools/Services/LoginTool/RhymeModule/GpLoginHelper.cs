using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

using Newtonsoft.Json;

using Rhyme.Tools.Services.LoginTool.RhymeModule.Common;

namespace Rhyme.Tools.Services.LoginTool.RhymeModule
{
	class GpLoginHelper
	{
		public static async Task<GPToken> GetAuthToken(string env, string userName, string password)
		{
			try
			{
				var tokenUrlGP = "";

				switch (env)
				{
					case "dev":
					case "test":
						tokenUrlGP = "http://192.168.0.203:8080/gg-launch-token?username={0}&password={1}";
						break;
					case "stress":
						throw new InvalidOperationException("Not support yet");
					case "uat":
					case "uatnew":
						tokenUrlGP = "http://tst-uat.good-gamenetwork.com:8080/gg-launch-token?username={0}&password={1}";
						break;
					case "live":
						throw new InvalidOperationException("Not support yet");
				}

				var requestQuery = string.Format(tokenUrlGP, userName, password);
				var request = WebRequest.CreateHttp(requestQuery) as HttpWebRequest;
				//request.ContentType = "application/json; charset=utf-8";
				request.Method = "GET";
				request.Timeout = 3000;
				request.Proxy = null;

				using (var response = await request.GetResponseAsync())
				using (var resStream = response.GetResponseStream())
				using (var reader = new StreamReader(resStream))
				{
					var json = await reader.ReadToEndAsync();
					return JsonConvert.DeserializeObject<GPToken>(json);
				}
			}
			catch
			{
				//Logger.Log(LogInfo.Warn, new
				//{
				//	Event = "acquire_token_failed",
				//	UserName = _userName,
				//});

				return null;
			}
		}
	}
}
