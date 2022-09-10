using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.IO;
using DayZExpansionMarketManager.Classes;

namespace DayZExpansionMarketManager
{
    public partial class MainForm : Form
    {

        private OpenFileDialog openMarketFileDialog;
        public List<Category> categories;
        public Handlers.DebugHandler debug;
		public Handlers.SettingsHandler settings;
		public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            debug = new Handlers.DebugHandler(this);
            settings = new Handlers.SettingsHandler();
        }

        private void categoryManagerButton_Click(object sender, EventArgs e)
        {
            Managers.CategoryManager manager = new Managers.CategoryManager(this);
            manager.Show();
        }

        private void traderManagerButton_Click(object sender, EventArgs e)
        {
			Managers.TraderManager manager = new Managers.TraderManager();
			manager.Show();
		}

        private void safezoneManagerButton_Click(object sender, EventArgs e)
        {
			Managers.SafezoneManager manager = new Managers.SafezoneManager();
			manager.Show();
		}

        private void mapManagerButton_Click(object sender, EventArgs e)
        {
			Managers.MapManager manager = new Managers.MapManager();
			manager.Show();
		}

        private void traderZoneManagerButton_Click(object sender, EventArgs e)
        {
			Managers.TraderZoneManager manager = new Managers.TraderZoneManager();
			manager.Show();
		}

        private void settingsManagerButton_Click(object sender, EventArgs e)
        {
            Managers.SettingsManager manager = new Managers.SettingsManager();
            manager.Show();
        }
    }
}