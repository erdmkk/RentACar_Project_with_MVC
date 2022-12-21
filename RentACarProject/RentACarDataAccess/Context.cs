using Microsoft.EntityFrameworkCore;
using RentACarEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarDataAccess
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-MILUGA6; Database=RentACar ; Trusted_Connection=true");
        }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
