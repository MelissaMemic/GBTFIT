using System.Collections.Generic;
using System.Reflection.Emit;
using GBT.Models;
using Microsoft.EntityFrameworkCore;

namespace MobitelShop.Data
{
    public class MojDBContext : DbContext
    {
        public MojDBContext(DbContextOptions<MojDBContext> options) : base(options)
        {
        }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Drzava> Drzava { get; set; }
        public DbSet<Grad> Grad { get; set; }
        //public DbSet<KreditnaKartica> KreditnaKartica { get; set; }
        public DbSet<Karta> Karta { get; set; }
        //public DbSet<NarudzbaProizvod> NarudzbaProizvod { get; set; }
        //public DbSet<OmiljeniProizvod> OmiljeniProizvod { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //ovo on nije radio ali je na adilovim vjezbama
        //{
        //  base.OnConfiguring(optionsBuilder);
        //
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //ni ovo nego je radio ono modelBuilder.Entity<Student>().ToTable("Student"); ali to nama ne treba
        }


    }
}
