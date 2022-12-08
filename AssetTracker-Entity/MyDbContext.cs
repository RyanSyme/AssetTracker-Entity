using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracker_Entity
{
    internal class MyDbContext : DbContext
    {
        string connectionString = "Server=(localdb)\\mssqllocaldb;Database=assets1;Trusted_Connection=True;MultipleActiveResultSets=true";

        public DbSet<Asset> Assets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // this tells the app to use the connectionstring
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            ModelBuilder.Entity<Asset>().HasData(new Asset 
            {
                Id = 1,
                Type = "Desktop",
                Brand = "HP",
                Model = "Elitebook",
                Office = "Germany",
                Price = 8423, 
                PurchaseDate = Convert.ToDateTime("2022-05-01") 
            });
            ModelBuilder.Entity<Asset>().HasData(new Asset
            {
                Id = 2,
                Type = "Phone",
                Brand = "iPhone",
                Model = "11",
                Office = "Germany",
                Price = 3990,
                PurchaseDate = Convert.ToDateTime("2022-04-25")
            });
            ModelBuilder.Entity<Asset>().HasData(new Asset
            {
                Id = 3,
                Type = "Desktop",
                Brand = "Lenovo",
                Model = "Yoga 730",
                Office = "USA",
                Price = 9835,
                PurchaseDate = Convert.ToDateTime("2020-09-28")
            });
            ModelBuilder.Entity<Asset>().HasData(new Asset
            {
                Id = 4,
                Type = "Phone",
                Brand = "Samsung",
                Model = "20",
                Office = "Sweden",
                Price = 6245,
                PurchaseDate = Convert.ToDateTime("2020-03-25")
            });
            ModelBuilder.Entity<Asset>().HasData(new Asset
            {
                Id = 5,
                Type = "Laptop",
                Brand = "HP",
                Model = "Elitebook",
                Office = "Sweden",
                Price = 9588,
                PurchaseDate = Convert.ToDateTime("2020-10-07")
            });
            ModelBuilder.Entity<Asset>().HasData(new Asset
            {
                Id = 6,
                Type = "Desktop",
                Brand = "Asus",
                Model = "W234",
                Office = "USA",
                Price = 10200,
                PurchaseDate = Convert.ToDateTime("2020-07-21")
            });
            ModelBuilder.Entity<Asset>().HasData(new Asset
            {
                Id = 7,
                Type = "Phone",
                Brand = "iPhone",
                Model = "8",
                Office = "Germany",
                Price = 1970,
                PurchaseDate = Convert.ToDateTime("2019-11-05")
            });
            ModelBuilder.Entity<Asset>().HasData(new Asset
            {
                Id = 8,
                Type = "Laptop",
                Brand = "Acer",
                Model = "Aspire",
                Office = "USA",
                Price = 6030,
                PurchaseDate = Convert.ToDateTime("2019-11-21")
            });
            ModelBuilder.Entity<Asset>().HasData(new Asset
            {
                Id = 9,
                Type = "Phone",
                Brand = "Motorola",
                Model = "Razr",
                Office = "Sweden",
                Price = 970,
                PurchaseDate = Convert.ToDateTime("2020-03-06")
            });
        }

    }
}