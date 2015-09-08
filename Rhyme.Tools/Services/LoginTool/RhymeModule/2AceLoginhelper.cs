using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

using Newtonsoft.Json;

using Rhyme.Tools.Services.LoginTool.RhymeModule.Common;

namespace Rhyme.Tools.Services.LoginTool.RhymeModule
{
	/// <summary>
	/// help by simon.kim
	/// </summary>
	class _2AceLoginhelper
	{
		private static readonly Uri baseAddress = new Uri(@"http://106.241.31.29:47002");
		private const string _2ace_platform_autorization_key = @"c3eca13b-4ecb-cf36-3728-3c15c02c4696";
		private const string _login_session_create_url = @"/two-ace-client/api/users/session/create";
		//private const string _login_user_detail_url = @"/two-ace-client/api/users/token";
		private const string _login_user_token_url = @"/two-ace-client/api/users/token";

		public static async Task<GPToken> GetAuthToken(string env, string userName, string password)
		{
			try
			{
				using (var handler = new HttpClientHandler { UseCookies = false })
				using (var client = new HttpClient(handler) { BaseAddress = baseAddress })
				{
					// This needs to go over as a dict.
					var formContent = new Dictionary<string, string>
						{
							{"username", userName},
							{"password", password}
						};

					// Login to 2Ace Auth Server and Convert the dict to form encoded content.
					client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(_2ace_platform_autorization_key);
					var result = client.PostAsync(_login_session_create_url, new FormUrlEncodedContent(formContent)).Result;

					// Variable to hold the authentication cookie.
					var setCookie = string.Empty;

					// Get the authentication cookie from the login request.
					foreach (var header in result.Headers.Where(header => header.Key == "Set-Cookie"))
					{
						foreach (var value in header.Value)
						{
							setCookie = value;
							break; // Stop after finding something..
						}
						break; // We only care about the first match.
					}

					// Uh oh, something bad happened...
					if (setCookie.Trim().Equals(""))
					{
						throw new Exception("No authentication cookie from login call!");
					}

					// Make sure the accept headers are empty.
					client.DefaultRequestHeaders.Accept.Clear();
					client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

					var message = new HttpRequestMessage(HttpMethod.Get, _login_user_token_url);
					message.Headers.Add("Cookie", setCookie);

					// Get a list of processes.
					var result2 = client.SendAsync(message).Result;

					// Make sure a success code was returned.
					result2.EnsureSuccessStatusCode();

					var resultContent = await result2.Content.ReadAsStringAsync();
					return JsonConvert.DeserializeObject<GPToken>(resultContent);
				}
			}
			catch (Exception)
			{
				return null;
			}
		}
	}
}
