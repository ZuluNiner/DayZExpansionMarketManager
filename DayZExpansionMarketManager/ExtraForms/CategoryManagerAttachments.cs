using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayZExpansionMarketManager.ExtraForms
{
	public partial class CategoryManagerAttachments : Form
	{
		Classes.Item item;
		public CategoryManagerAttachments(Classes.Item itm)
		{
			item = itm;
			InitializeComponent();
		}
		List<string> attachments;

		private void CategoryManagerAttachments_Load(object sender, EventArgs e)
		{
			headerLabel.Text = "Attachments for " + item.ClassName;
			if (item.SpawnAttachments == null || item.SpawnAttachments.Count == 0)
				attachments = new List<string>();
			else
				attachments = item.SpawnAttachments;
		}

		private Panel buildPanel(string ClassName)
		{

		}
	}
}
