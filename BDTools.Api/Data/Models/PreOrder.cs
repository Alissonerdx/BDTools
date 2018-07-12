using System;
using System.Collections.Generic;
using System.Text;

namespace BDTools.Api.Data.Models
{
    public class PreOrder
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public AppUser Identity { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int Level { get; set; }
        public string Server { get; set; }
        public string City { get; set; }
        public DateTime DatePosted { get; set; } 
        public DateTime DateMaximum { get; set; }
        public double BasePrice { get; set; }
    }
}
