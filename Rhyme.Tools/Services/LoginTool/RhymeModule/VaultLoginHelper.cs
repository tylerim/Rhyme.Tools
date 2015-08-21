using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Rhyme.Tools.Services.LoginTool.RhymeModule.Common;

namespace Rhyme.Tools.Services.LoginTool.RhymeModule
{
	public class VaultLoginHelper
	{
		private const string TokenUrlString = "https://{0}ggcom.good-game-network.com/login";
		private const string AuthString = "{{\"Mode\":\"ClientLogin\",\"Username\":\"{0}\",\"Password\":\"{1}\"}}";

		public static async Task<GPToken> GetAuthToken(string env, string userName, string password)
		{
			try
			{
				var localEnv = env == "test" ? "dev" : env;

				var tokenUrl = string.Format(TokenUrlString, localEnv);
				var data = Encoding.UTF8.GetBytes(string.Format(AuthString, userName, password));

				var request = WebRequest.CreateHttp(tokenUrl) as HttpWebRequest;
				request.ContentType = "application/json; charset=utf-8";
				request.Method = "POST";
				request.Timeout = 3000;
				request.Proxy = null;

				using (var rStream = request.GetRequestStream())
					rStream.Write(data, 0, data.Length);

				using (var response = await request.GetResponseAsync())
				using (var resStream = response.GetResponseStream())
				using (var reader = new StreamReader(resStream))
				{
					return new GPToken
					{
						token = await reader.ReadToEndAsync(),
						//gp_id = string.Empty
					};
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
