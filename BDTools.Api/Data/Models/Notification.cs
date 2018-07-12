using System;
using System.Collections.Generic;
using System.Text;

namespace BDTools.Api.Data.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public string IdentityId { get; set; }
        public AppUser Identity { get; set; }
    }
}
