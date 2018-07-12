using System;
using System.Collections.Generic;
using System.Text;

namespace BDTools.Domain.Entitys
{
    public class PreOrder
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
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
