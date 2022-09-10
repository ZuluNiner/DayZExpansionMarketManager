using DayZExpansionMarketManager.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayZExpansionMarketManager.Handlers
{
	public class SettingsHandler
	{
		private string settingsFiles;
		private List<string> settingsFileList = new List<string>()
		{
			"Basic.cfg"
		};
		public BasicSettings basicSettings;
		public SettingsHandler()
		{
			settingsFiles = Directory.GetCurrentDirectory() + "/settings";
			if (!Directory.Exists(settingsFiles))
			{
				Directory.CreateDirectory(settingsFiles);
			}
			foreach (string settingsFile in settingsFileList)
			{
				string curFile = settingsFiles + "/" + settingsFile;
				if (!File.Exists(curFile))
				{
					var file = File.Create(curFile);
					file.Close();
					var objType = Type.GetType(settingsFile.Replace(".cfg", "") + "Settings");
					var obj = Activator.CreateInstance(objType);
					File.WriteAllText(curFile, JsonConvert.SerializeObject(obj));
				}
			}
		}

		public void LoadSettings()
		{
			foreach(string setFile in settingsFileList)
			{

			}
		}
	}
}
