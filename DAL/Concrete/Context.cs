using Entity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class Context: IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=Randevu_SystemFour;Username=postgres;Password=postgre;Port=4444;");
       
        public DbSet<Arama> Arama { get; set; } = null!;
        public DbSet<Randevular> Randevu { get; set; } = null!;
        public DbSet<ArayanTipi> ArayanTipi { get; set; } = null!;
        public DbSet<AramaTipi> AramaTipi { get; set; } = null!;
        public DbSet<RandevuDurumu> RandevuDurumu { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Arama>()
                .HasOne(m => m.ArayanTipi);


        }
    }
     
}
