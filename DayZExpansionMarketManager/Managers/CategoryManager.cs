using DayZExpansionMarketManager.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayZExpansionMarketManager.Managers
{
	public partial class CategoryManager : Form
	{
		private MainForm parent;
		public List<Category> categories;
		OpenFileDialog categoryFile;
		public CategoryManager(MainForm prnt)
		{
			parent = prnt;
			InitializeComponent();
		}

		private void CategoryManager_Load(object sender, EventArgs e)
		{
			categories = new List<Category>();
		}

		private void importCategoryFileButton_Click(object sender, EventArgs e)
		{
			categoryFile = new OpenFileDialog();
			categoryFile.Filter = "Json File (*.json)|*.json";
			categoryFile.FileOk += acceptCategoryFile;
			categoryFile.ShowDialog();
		}

		private void acceptCategoryFile(object o,EventArgs e)
		{
			Debug.WriteLine("Found category file: " + categoryFile.FileName);
			try
			{
				Classes.Category newCat = new Classes.Category(File.ReadAllText(categoryFile.FileName));
				if(categories.Exists(x=>x.data.DisplayName == newCat.data.DisplayName))
				{
					var conf = MessageBox.Show("A duplicate category with the name \"" + newCat.data.DisplayName + "\" was found, do you want to overwrite it?", "Overwrite Category", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if(conf == DialogResult.Yes)
					{
						categories.Remove(categories.Find(x => x.data.DisplayName == newCat.data.DisplayName));
						categories.Add(newCat);
					}
				}
				else
				{
					categories.Add(newCat);
					categoryListBox.Items.Add(newCat.data.DisplayName);
				}
				categories.Add(newCat);
			}catch(Exception ex)
			{
				MessageBox.Show("Exception: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Debug.WriteLine("Exception: " + ex.Message);
				return;
			}
			processCategoryItems();
		}

		private void processCategoryItems()
		{
			ClearItems();
			int run = 0;
			foreach(Category category in categories)
			{
				foreach(Item itm in category.data.Items)
				{
					Panel itmPnl = buildItem(category.data, itm);
					itemPanel.Controls.Add(itmPnl);
					itemPanel.Controls.SetChildIndex(itmPnl, 0);
					run++;
				}
			}
		}

		private Panel buildItem(CategoryData cat, Item itm)
		{
			Panel pnl = new Panel();
			pnl.Size = new Size(994, 30);
			pnl.Dock = DockStyle.Top;
			pnl.Padding = new Padding(2, 2, 2, 2);
			pnl.Margin = new Padding(3, 3, 3, 3);
			pnl.Name = cat.DisplayName + "~" + itm.ClassName;

			Label className = new Label();
			className.Text = itm.ClassName;
			className.Width = 148;
			className.Dock = DockStyle.Left;

			Label category = new Label();
			category.Text = cat.DisplayName;
			category.Width = 131;
			category.Dock = DockStyle.Left;

			TextBox maxPriceThreshold = new TextBox();
			maxPriceThreshold.Text = itm.MaxPriceThreshold.ToString();
			maxPriceThreshold.Width = 111;
			maxPriceThreshold.Dock = DockStyle.Left;
			maxPriceThreshold.TextChanged += changeMaxPriceThreshold;

			TextBox minPriceThreshold = new TextBox();
			minPriceThreshold.Text = itm.MaxPriceThreshold.ToString();
			minPriceThreshold.Width = 106;
			minPriceThreshold.Dock = DockStyle.Left;

			TextBox sellPricePercent = new TextBox();
			sellPricePercent.Text = itm.MaxPriceThreshold.ToString();
			sellPricePercent.Width = 91;
			sellPricePercent.Dock = DockStyle.Left;

			TextBox maxStockThreshold = new TextBox();
			maxStockThreshold.Text = itm.MaxPriceThreshold.ToString();
			maxStockThreshold.Width = 113;
			maxStockThreshold.Dock = DockStyle.Left;

			TextBox minStockThreshold = new TextBox();
			minStockThreshold.Text = itm.MaxPriceThreshold.ToString();
			minStockThreshold.Width = 116;
			minStockThreshold.Dock = DockStyle.Left;

			Label quantityPercent = new Label();
			quantityPercent.Text = itm.MaxPriceThreshold.ToString();
			quantityPercent.Width = 116;
			quantityPercent.Dock = DockStyle.Left;

			Button spawnAttachments = new Button();
			spawnAttachments.Text = "Attachments";
			spawnAttachments.Click += spawnAttaches;
			spawnAttachments.Dock = DockStyle.Left;
			spawnAttachments.Width = 112;

			Button variants = new Button();
			variants.Text = "Variants";
			variants.Click += itemVariants;
			variants.Dock = DockStyle.Left;
			variants.Width = 63;

			pnl.Controls.Add(className);
			pnl.Controls.Add(category);
			pnl.Controls.Add(maxPriceThreshold);
			pnl.Controls.Add(minPriceThreshold);
			pnl.Controls.Add(sellPricePercent);
			pnl.Controls.Add(maxStockThreshold);
			pnl.Controls.Add(minStockThreshold);
			pnl.Controls.Add(spawnAttachments);
			pnl.Controls.Add(variants);

			pnl.Controls.SetChildIndex(variants, 0);
			pnl.Controls.SetChildIndex(spawnAttachments, 1);
			pnl.Controls.SetChildIndex(minStockThreshold, 2);
			pnl.Controls.SetChildIndex(maxStockThreshold, 3);
			pnl.Controls.SetChildIndex(sellPricePercent, 4);
			pnl.Controls.SetChildIndex(minPriceThreshold, 5);
			pnl.Controls.SetChildIndex(maxPriceThreshold, 6);
			pnl.Controls.SetChildIndex(category, 7);
			pnl.Controls.SetChildIndex(className, 8);

			return pnl;
		}

		private void spawnAttaches(object o, EventArgs e)
		{
			Button bt = (Button)o;
			Panel btParent = (Panel)bt.Parent;
			Category cat = categories.Find(x => x.data.DisplayName == btParent.Name.Split('~')[1]);
			Item itm = cat.data.Items.Find(x => x.ClassName == btParent.Name.Split('~')[0]);
			ExtraForms.CategoryManagerAttachments attachmentManager = new ExtraForms.CategoryManagerAttachments(itm);
		}

		private void itemVariants(object o, EventArgs e)
		{

		}

		private void ClearItems()
		{
			List<Control> toClear = new List<Control>();
			foreach (Control con in itemPanel.Controls)
			{
				if (con.Name == "headerPanel")
					continue;
				toClear.Add(con);
			}
			foreach (Control clear in toClear)
			{
				itemPanel.Controls.Remove(clear);
			}
		}

		private void changeMaxPriceThreshold(object o, EventArgs e)
		{
			TextBox tb = (TextBox)o;
			Panel tbParent = (Panel)tb.Parent;
			Debug.WriteLine(tbParent.Name);
		}
	}
}
