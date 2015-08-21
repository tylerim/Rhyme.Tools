using System;
using System.Threading.Tasks;

using Rhyme.Tools.Services.LoginTool.RhymeModule.Common;

namespace Rhyme.Tools.Services.LoginTool.RhymeModule
{
	class MyPlatformLoginHelper
	{
		public static async Task<GPToken> GetAuthToken(string env, string userName, string password)
		{
			return new GPToken
			{
				token = Guid.NewGuid().ToString(),
				gp_id = userName + "_MyPlatform"
			};
		}
	}
}
