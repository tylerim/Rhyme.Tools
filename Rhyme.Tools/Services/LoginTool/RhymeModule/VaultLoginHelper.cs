using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Rhyme.Tools.Services.LoginTool.RhymeModule
{
	public class VaultLoginHelper
	{
		private const string TokenUrlString = "https://{0}ggcom.good-game-network.com/login";
		private const string AuthString = "{{\"Mode\":\"ClientLogin\",\"Username\":\"{0}\",\"Password\":\"{1}\"}}";

		public static async Task<string> GetAuthToken(string env, string userName, string password)
		{
			try
			{
				var tokenUrl = string.Format(TokenUrlString, env);

				var request = WebRequest.CreateHttp(tokenUrl) as HttpWebRequest;
				request.ContentType = "application/json; charset=utf-8";
				request.Method = "POST";
				request.Timeout = 2000;
				request.Proxy = null;
				var rStream = request.GetRequestStream();
				var data = Encoding.UTF8.GetBytes(string.Format(AuthString, userName, password));
				rStream.Write(data, 0, data.Length);
				rStream.Close();

				using (var response = await request.GetResponseAsync())
				using (var resStream = response.GetResponseStream())
				using (var reader = new StreamReader(resStream))
					return await reader.ReadToEndAsync();
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
