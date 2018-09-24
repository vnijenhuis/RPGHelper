using System;
using System.Collections.Generic;
using System.Text;

namespace RPGHelper.Models.Entities
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public RarityEnum Rarity { get; set; }
        public string Location { get; set; }
        public string Url { get; set; }
    }
}
