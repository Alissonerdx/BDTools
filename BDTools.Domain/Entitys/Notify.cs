using System;
using System.Collections.Generic;
using System.Text;

namespace BDTools.Domain.Entitys
{
    public class Notify
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
