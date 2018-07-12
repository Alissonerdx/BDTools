using System;
using System.Collections.Generic;
using System.Text;

namespace BDTools.Api.Data.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int ClasseId { get; set; }
        public string Name { get; set; }
        public string Rarity { get; set; }
        public string Type { get; set; }
    }
}
