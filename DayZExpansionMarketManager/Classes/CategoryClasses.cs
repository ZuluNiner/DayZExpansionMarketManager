using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DayZExpansionMarketManager.Classes
{
    public class Item
    {
        public string ClassName;
        public int MaxPriceThreshold, MinPriceThreshold, MaxStockThreshold, MinStockThreshold;
        public float SellPricePercent, QuantityPercent;
        public List<string> SpawnAttachments, Variants;
    }

    public class Category
    {
        public CategoryData data;

        public Category(string jsonData)
        {
            data = JsonConvert.DeserializeObject<CategoryData>(jsonData);
        }
    }
    public class CategoryData
    {
        public List<Item> Items;
        public string Color, Icon, DisplayName;
        public int IsExchange, m_Version;
        public float InitStockPercent;
    }
}
