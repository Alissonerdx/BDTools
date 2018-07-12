using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BDTools.Api.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BDTools.Api.Data
{
    public class BDToolsContext : IdentityDbContext<AppUser>
    {
        public BDToolsContext(DbContextOptions<BDToolsContext> options)
            : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<PreOrder> PreOrders { get; set; }
    }
}
