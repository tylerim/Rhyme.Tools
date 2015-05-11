using System.Collections.Generic;
using System.Linq;

namespace Rhyme.Bootstrapper.Service
{
	public class BackupDomain
	{
		private Dictionary<string, Dictionary<string, List<string>>> _domainList;

		public BackupDomain()
		{
			InitializeList();
		}

		private void InitializeList()
		{
			_domainList = new Dictionary<string, Dictionary<string, List<string>>>();

			MakeDomainListGG();
			MakeDomainListGGNETPRO();
			MakeDomainListGGREGULAR();
			MakeDomainListHAHA();
		}

		private void MakeDomainListGG()
		{
			var list = new List<string>();
			var dictionary = new Dictionary<string, List<string>>();

			list.Add("devgg.good-game-network.com");
			// backup domain 1
			list.Add("dev.hydrolysisguava.com");
			// backup domain 2
			list.Add("dev.keratotomymelon.com");
			dictionary.Add("dev", list.ToList());

			list.Clear();

			list.Add("uatgg.good-game-network.com");
			// backup domain 1
			list.Add("uat.hydrolysisguava.com");
			// backup domain 2
			list.Add("uat.keratotomymelon.com");
			dictionary.Add("uat", list.ToList());

			list.Clear();

			list.Add("gg.good-game-network.com");
			// backup domain 1
			list.Add("ko.hydrolysisguava.com");
			list.Add("kr.hydrolysisguava.com");
			list.Add("ssl.hydrolysisguava.com");
			// backup domain 2
			list.Add("ko.keratotomymelon.com");
			list.Add("kr.keratotomymelon.com");
			list.Add("ssl.keratotomymelon.com");
			dictionary.Add("live", list.ToList());

			_domainList.Add("GG", dictionary);
		}

		private void MakeDomainListGGNETPRO()
		{
			var list = new List<string>();
			var dictionary = new Dictionary<string, List<string>>();

			list.Add("devpro.good-game-network.com");
			// backup domain 1
			list.Add("prouat.hydrolysisguava.com");
			// backup domain 2
			list.Add("prouat.keratotomymelon.com");
			dictionary.Add("dev", list.ToList());

			list.Clear();

			list.Add("uatpro.good-game-network.com");
			// backup domain 1
			list.Add("prouat.hydrolysisguava.com");
			// backup domain 2
			list.Add("prouat.keratotomymelon.com");
			dictionary.Add("uat", list.ToList());

			list.Clear();

			list.Add("pro.good-game-network.com");
			// backup domain 1
			list.Add("pro.hydrolysisguava.com");
			list.Add("kopro.hydrolysisguava.com");
			// backup domain 2
			list.Add("pro.keratotomymelon.com");
			list.Add("kopro.keratotomymelon.com");
			dictionary.Add("live", list.ToList());

			_domainList.Add("GGNETPRO", dictionary);
		}

		private void MakeDomainListGGREGULAR()
		{
			var list = new List<string>();
			var dictionary = new Dictionary<string, List<string>>();

			list.Add("devregular.good-game-network.com");
			// backup domain 1
			list.Add("regularuat.hydrolysisguava.com");
			// backup domain 2
			list.Add("regularuat.keratotomymelon.com");
			dictionary.Add("dev", list.ToList());

			list.Clear();

			list.Add("uatregular.good-game-network.com");
			// backup domain 1
			list.Add("regularuat.hydrolysisguava.com");
			// backup domain 2
			list.Add("regularuat.keratotomymelon.com");
			dictionary.Add("uat", list.ToList());

			list.Clear();

			list.Add("regular.good-game-network.com");
			// backup domain 1
			list.Add("regular.hydrolysisguava.com");
			list.Add("koregular.hydrolysisguava.com");
			// backup domain 2
			list.Add("regular.keratotomymelon.com");
			list.Add("koregular.keratotomymelon.com");
			dictionary.Add("live", list.ToList());

			_domainList.Add("GGREGULAR", dictionary);
		}

		private void MakeDomainListHAHA()
		{
			var list = new List<string>();
			var dictionary = new Dictionary<string, List<string>>();

			list.Add("devhaha.good-game-network.com");
			// backup domain 1
			list.Add("uat.polyurialime.com");
			// backup domain 2
			list.Add("uat.collyriumraspberry.com");
			dictionary.Add("dev", list.ToList());

			list.Clear();

			list.Add("uathaha.good-game-network.com");
			// backup domain 1
			list.Add("uat.polyurialime.com");
			// backup domain 2
			list.Add("uat.collyriumraspberry.com");
			dictionary.Add("uat", list.ToList());

			list.Clear();

			list.Add("haha.good-game-network.com");
			// backup domain 1
			list.Add("ko.polyurialime.com");
			list.Add("kr.polyurialime.com");
			list.Add("ssl.polyurialime.com");
			// backup domain 2
			list.Add("ko.collyriumraspberry.com");
			list.Add("kr.collyriumraspberry.com");
			list.Add("ssl.collyriumraspberry.com");
			dictionary.Add("live", list.ToList());

			_domainList.Add("HAHA", dictionary);
		}

		public void BlockCurrentBackupDomain(string serviceProviderName, string environmentName)
		{
			Dictionary<string, List<string>> dictionary;
			if (_domainList.TryGetValue(serviceProviderName, out dictionary) == false)
				return;

			List<string> list;
			if (dictionary.TryGetValue(environmentName.ToLower(), out list) == false)
				return;

			if (list.Count <= 0)
				return;

			list.Remove(list.First());
		}

		public string GetBackupDomain(string serviceProviderName, string environmentName)
		{
			Dictionary<string, List<string>> dictionary;
			if (_domainList.TryGetValue(serviceProviderName, out dictionary) == false)
				return null;

			List<string> list;
			if (dictionary.TryGetValue(environmentName.ToLower(), out list) == false)
				return null;

			return list.FirstOrDefault();
		}

		public bool IsPreparedBackupDomain(string serviceProviderName)
		{
			return _domainList.ContainsKey(serviceProviderName);
		}
	}
}
