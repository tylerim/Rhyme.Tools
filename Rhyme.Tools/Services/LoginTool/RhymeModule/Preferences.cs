using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml.Serialization;

using Rhyme.Tools.Services.LoginTool.RhymeModule.Common;
using Rhyme.Tools.Services.LoginTool.RhymeModule.Common.Utilities;
//using System.Windows.Threading;

namespace Rhyme.Tools.Services.LoginTool.RhymeModule
{
	//[Serializable]
	//[XmlSerializerAssembly("RhymeLoginTool.XmlSerializers")]
	public class ConfigEntry
	{
		[XmlAttribute("Key")]
		public string Key { get; set; }

		[XmlAttribute("Value")]
		public string Value { get; set; }

		public ConfigEntry(string key, string value)
		{
			Key = key;
			Value = value;
		}

		public ConfigEntry()
		{
		}
	}

	//[Serializable]
	//[XmlSerializerAssembly("RhymeLoginTool.XmlSerializers")]
	public class ConfigEntryList : List<ConfigEntry>
	{
		public ConfigEntryList(List<ConfigEntry> list)
			: base()
		{
			AddRange(list);
		}

		public ConfigEntryList()
			: base()
		{

		}
	}

	public sealed class Preferences
	{
		private static ConcurrentDictionary<string, ConfigEntry> _configDictionary = new ConcurrentDictionary<string, ConfigEntry>();
		private static DateTime _nextUpdate = DateTime.MaxValue;
		private static bool _initialized = false;
		//private static DispatcherTimer _timer;

		public static string WorkingDirectory;

		public static void Initialize()
		{
			if (_initialized == false)
				_initialized = true;
			else
				return;

			_configDictionary = DeSerialize();

			//_timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
			//_timer.Tick += TimerWork;

			//_timer.Start();
		}

		public static bool Exist(Configurations configuration)
		{
			return _configDictionary.ContainsKey(configuration.ToString());
		}

		public static T GetValue<T>(Configurations configuration, T defaultValue)
		{
			//if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
			//{
			//	return defaultValue;
			//}

			ConfigEntry configEntry;
			var isExistKey = _configDictionary.TryGetValue(configuration.ToString(), out configEntry);
			if (isExistKey == false)
				return defaultValue;

			if (configEntry == null)
				return defaultValue;

			var type = typeof(T);
			T resultValue = defaultValue;

			var typeCode = Type.GetTypeCode(type);

			// check if type is string
			if (typeCode == TypeCode.String)
			{
				var temp = (object)configEntry.Value;
				return (T)temp;
			}

			// check if type is bool
			if (typeCode == TypeCode.Boolean)
			{
				try
				{
					var temp = (object)Convert.ToBoolean(configEntry.Value);
					return (T)temp;
				}
				catch (FormatException)
				{
					return defaultValue;
				}
			}

			// try converting to numeric forms
			var methodInfo = (from m in type.GetMethods(BindingFlags.Public | BindingFlags.Static)
							  where m.Name == "TryParse"
							  select m).FirstOrDefault();

			if (methodInfo == null)
			{
				var temp = (object)configEntry.Value;
				return (T)temp;
			}

			object result = methodInfo.Invoke(null, new object[] { configEntry.Value, resultValue });

			if ((bool)result == false)
			{
				return defaultValue;
			}

			methodInfo = (from m in type.GetMethods(BindingFlags.Public | BindingFlags.Static)
						  where m.Name == "Parse"
						  select m).FirstOrDefault();

			if (methodInfo == null)
			{
				return defaultValue;
			}

			resultValue = (T)methodInfo.Invoke(null, new object[] { configEntry.Value });
			return resultValue;
		}

		public static void SetValue<T>(Configurations configuration, T value)
		{
			//if (DesignerProperties.GetIsInDesignMode(new DependencyObject()))
			//{
			//	return;
			//}

			var newValue = new ConfigEntry(configuration.ToString(), value.ToString());
			_configDictionary.AddOrUpdate(configuration.ToString(), newValue, (k, v) =>
			{
				v.Value = value.ToString();
				return v;
			});

			// This will flush configuration 1 seconds later after configuration is changed
			_nextUpdate = DateTime.UtcNow.AddSeconds(1);
		}

		private static void TimerWork(object sender, EventArgs e)
		{
			if (_nextUpdate > DateTime.UtcNow)
				return;

			try
			{
				Serialize();
			}
			catch (IOException ex)
			{
			}

			_nextUpdate = DateTime.MaxValue;
		}

		private static void Serialize()
		{
			var lists = _configDictionary.Select(configEntry => configEntry.Value).ToList();

			ConfigEntryList list = new ConfigEntryList(lists);

			var serializer = new XmlSerializer(typeof(ConfigEntryList));

			// [hdkim]
			// Must not Use Environment.CurrentDirectory Property, Because It is variable Property regardless of your intention
			using (TextWriter writer = new StreamWriter(DirectoryHelper.GetAppDataDirectory() + Constants.PreferenceXml))
			{
				serializer.Serialize(writer, list);
			}
		}

		private static ConcurrentDictionary<string, ConfigEntry> DeSerialize()
		{
			// [hdkim]
			// Must not Use Environment.CurrentDirectory Property, Because It is variable Property regardless of your intention
			if (File.Exists(DirectoryHelper.GetAppDataDirectory() + Constants.PreferenceXml) == false)
				Serialize();


			var serializer = new XmlSerializer(typeof(ConfigEntryList));

			using (TextReader reaader = new StreamReader(DirectoryHelper.GetAppDataDirectory() + Constants.PreferenceXml))
			{
				ConfigEntryList list;

				try
				{
					list = serializer.Deserialize(reaader) as ConfigEntryList;
				}
				catch (Exception)
				{
					list = new ConfigEntryList();
				}

				var concurrentDictionary = new ConcurrentDictionary<string, ConfigEntry>();

				if (list != null)
				{
					foreach (var configEntry in list)
					{
						concurrentDictionary[configEntry.Key] = configEntry;
					}
				}

				return concurrentDictionary;
			}
		}

		public static void Shutdown()
		{
			Serialize();
		}
	}
}