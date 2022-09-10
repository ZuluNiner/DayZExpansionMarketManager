using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.Logging;
using System.Windows.Forms.Design;
using BrightIdeasSoftware;

namespace DayZExpansionMarketManager.Handlers
{
	public class DebugHandler
	{
		private string logFiles;
		private MainForm parent;
		public DebugHandler(MainForm prnt)
		{
			parent = prnt;
			logFiles = Directory.GetCurrentDirectory()+"/logs";
			if (!Directory.Exists(logFiles))
			{
				Directory.CreateDirectory(logFiles);
			}
		}

		public void debugLog(string message,int level = 0)
		{
			if(parent.settings.basicSettings.verboseLogging)
			{
				if(level > 1)
				{
					Console.WriteLine(message);
					WriteLog(message);
				}
			}
		}

		private void WriteLog(string msg)
		{
			string curlog = logFiles + DateTime.Now.ToString("yyyy_mm_dd");
			if (!File.Exists(curlog))
			{
				var fle = File.Create(curlog);
				fle.Close();
				File.WriteAllText(curlog,msg);
			}
			else
			{
				var fle = File.ReadAllText(curlog);
				fle += Environment.NewLine + msg;
				File.WriteAllText(curlog, fle);
			}
		}
	}
}
