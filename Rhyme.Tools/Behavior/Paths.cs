using System.IO;

namespace Rhyme.Tools.Behavior
{
	public static class Paths
	{
		public enum RhymePathEnum
		{
			None,
			CRMHttpServer,
			Front,
			Client,
			Sql,
		}

		public static string GetRhymePath(RhymePathEnum rhymeType, bool isRelease = false)
		{
			string path = "";

			switch (rhymeType)
			{
				case RhymePathEnum.CRMHttpServer:
					path = @"dev\src\tools\Rhyme.CRM\Rhyme.CRM.Server\bin\Debug";
					break;
				case RhymePathEnum.Front:
					path = @"dev\build\server\debug\";
					break;
				case RhymePathEnum.Client:
					if (isRelease)
						path = @"dev\build\client\release\";
					else
						path = @"dev\build\client\debug\";
					break;
				case RhymePathEnum.Sql:
					path = @"dev\src\sql\bin\";
					break;
			}
			return path;
		}

		public static string GetFullPath(string sourceRootDir, Paths.RhymePathEnum pathEnum, string sub1 = "", bool isRelease = false)
		{
			var fullPath = "";
			if (pathEnum == Paths.RhymePathEnum.None)
			{
				fullPath = Path.Combine(sourceRootDir, "", sub1);
			}
			else
			{
				fullPath = Path.Combine(sourceRootDir, Paths.GetRhymePath(pathEnum, isRelease), sub1);
			}
			return fullPath;
		}
	}
}
