using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ReCapEntities.Concrete;

namespace ReCapDataAccess.Concrete.EntityFramework
{
    public class CarDatabaseContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CarDatabase;Trusted_Connection=true");
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<Rental> Rental { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<User> User { get; set; }



    }

}
