using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Color = Entities.Concrete.Color;

namespace DataAccess.Concrete.EntityFramework
{
    class CarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Car;Trusted_Connection=true");

        }

        public DbSet<Color> Colors { get; set; } //hangi veri tabanı hangi classa karşolı?
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }

    }
}
