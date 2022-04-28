using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using MaskShop.Models;
using Microsoft.EntityFrameworkCore;

namespace MaskShop.DataBase
{
    public class DataBaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Mask> Masks { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ShopCart> ShopCarts { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var masks = new Mask[1000];

            for(int i = 0; i < 1000; i++)
            {
                masks[i] = new Mask("Mask" + (i + 1).ToString(), "s;alds;adls;adl'sl;aldlsa;ldldsldsa;dlald;ald;asld;asld", 123.4m, 25)
                {
                    Id = i + 1,
                };
            }
            modelBuilder.Entity<Mask>().HasData(masks);
        }
    }
}
