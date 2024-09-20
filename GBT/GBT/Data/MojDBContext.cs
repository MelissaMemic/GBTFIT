using System;
using GBT.Helpers;
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
        public DbSet<KreditnaKartica> KreditnaKartica { get; set; }
        public DbSet<Stanica> Stanica { get; set; }
        public DbSet<Karta> Karta { get; set; }
        public DbSet<Voznja> Voznja { get; set; }
        public DbSet<Voz> Voz { get; set; }
        public DbSet<LojalnostProgram> LojalnostProgram { get; set; }
        public DbSet<FavoritiRute> FavoritiRute { get; set; }
        public DbSet<HstorijaPlacanja> HstorijaPlacanja { get; set; }
        public DbSet<ObavestenjaKorisnicima> ObavestenjaKorisnicima { get; set; }
        public DbSet<OcjenjivanjeZaposlenih> OcjenjivanjeZaposlenih { get; set; }
        public DbSet<OtkazivanjaRezervacija> OtkazivanjaRezervacija { get; set; }
        public DbSet<PaketnePonude> PaketnePonude { get; set; }
        public DbSet<PartneriPrevoznici> PartneriPrevoznici { get; set; }
        public DbSet<Posiljka> Posiljka { get; set; }
        public DbSet<PromocijePopusti> PromocijePopusti { get; set; }
        public DbSet<RasporedOdrzavanjaVozova> RasporedOdrzavanjaVozova { get; set; }
        public DbSet<RecenzijeVozova> RecenzijeVozova { get; set; }
        public DbSet<ReklamacijeKorisnika> ReklamacijeKorisnika { get; set; }
        public DbSet<RezervacijaSedista> RezervacijaSedista { get; set; }
        public DbSet<StatusPosiljki> StatusPosiljki { get; set; }
        public DbSet<TipRute> TipRute { get; set; }
        public DbSet<UpitiKorisnickePodrske> UpitiKorisnickePodrske { get; set; }
        public DbSet<VremenskaPrognoza> VremenskaPrognoza { get; set; }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {
            builder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverter>()
                .HaveColumnType("date");

            base.ConfigureConventions(builder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Defining relationships
            modelBuilder.Entity<Voznja>()
                .HasOne(v => v.PocetnaDestinacija)
                .WithMany()
                .HasForeignKey(v => v.PocetnaDestinacijaID)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Voznja>()
                .HasOne(v => v.KrajnjaDestinacija)
                .WithMany()
                .HasForeignKey(v => v.KrajnjaDestinacijaID)
                .OnDelete(DeleteBehavior.NoAction);

            // Seeding data
            modelBuilder.Entity<Drzava>().HasData(
                new Drzava { ID = 1, Naziv = "Bosna i Hercegovina", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Drzava { ID = 2, Naziv = "Hrvatska", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Drzava { ID = 3, Naziv = "Srbija", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Drzava { ID = 4, Naziv = "Slovenija", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Drzava { ID = 5, Naziv = "Crna Gora", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
            );

            modelBuilder.Entity<Grad>().HasData(
                new Grad { ID = 1, Naziv = "Sarajevo", PostanskiBroj = "71000", DrzavaID = 1, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Grad { ID = 2, Naziv = "Zagreb", PostanskiBroj = "10000", DrzavaID = 2, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Grad { ID = 3, Naziv = "Beograd", PostanskiBroj = "11000", DrzavaID = 3, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Grad { ID = 4, Naziv = "Ljubljana", PostanskiBroj = "1000", DrzavaID = 4, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Grad { ID = 5, Naziv = "Podgorica", PostanskiBroj = "81000", DrzavaID = 5, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
            );

            modelBuilder.Entity<Stanica>().HasData(
                new Stanica { ID = 1, Naziv = "Sarajevo Stanica", GradID = 1, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Stanica { ID = 2, Naziv = "Zagreb Stanica", GradID = 2, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Stanica { ID = 3, Naziv = "Beograd Stanica", GradID = 3, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Stanica { ID = 4, Naziv = "Ljubljana Stanica", GradID = 4, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Stanica { ID = 5, Naziv = "Podgorica Stanica", GradID = 5, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
            );

            modelBuilder.Entity<Korisnik>().HasData(
                new Korisnik { ID = 1, Ime = "Fariss", Prezime = "Memic", Username = "fariss", Password = "password", Token = "secret", Rola = "Admin", Email = "fariss@example.com", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Korisnik { ID = 2, Ime = "John", Prezime = "Doe", Username = "john", Password = "password", Token = "token2", Rola = "User", Email = "john@example.com", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Korisnik { ID = 3, Ime = "Jane", Prezime = "Smith", Username = "jane", Password = "password", Token = "token3", Rola = "User", Email = "jane@example.com", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Korisnik { ID = 4, Ime = "Alice", Prezime = "Brown", Username = "alice", Password = "password", Token = "token4", Rola = "User", Email = "alice@example.com", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Korisnik { ID = 5, Ime = "Bob", Prezime = "Davis", Username = "bob", Password = "password", Token = "token5", Rola = "User", Email = "bob@example.com", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
            );

            modelBuilder.Entity<KreditnaKartica>().HasData(
                new KreditnaKartica { ID = 1, KorisnikID = 1, BrojKartice = "1234567890123456", Code = 123, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new KreditnaKartica { ID = 2, KorisnikID = 2, BrojKartice = "2345678901234567", Code = 234, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new KreditnaKartica { ID = 3, KorisnikID = 3, BrojKartice = "3456789012345678", Code = 345, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new KreditnaKartica { ID = 4, KorisnikID = 4, BrojKartice = "4567890123456789", Code = 456, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new KreditnaKartica { ID = 5, KorisnikID = 5, BrojKartice = "5678901234567890", Code = 567, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
            );

            modelBuilder.Entity<Voznja>().HasData(
                new Voznja { ID = 1, PocetnaDestinacijaID = 1, KrajnjaDestinacijaID = 2, DatumVoznje = DateTime.UtcNow.Date, PocetakVoznje = "08:00", KrajVoznje = "12:00", Trajanje = "4h", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Voznja { ID = 2, PocetnaDestinacijaID = 2, KrajnjaDestinacijaID = 3, DatumVoznje = DateTime.UtcNow.Date, PocetakVoznje = "09:00", KrajVoznje = "13:00", Trajanje = "4h", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Voznja { ID = 3, PocetnaDestinacijaID = 3, KrajnjaDestinacijaID = 4, DatumVoznje = DateTime.UtcNow.Date, PocetakVoznje = "10:00", KrajVoznje = "14:00", Trajanje = "4h", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Voznja { ID = 4, PocetnaDestinacijaID = 4, KrajnjaDestinacijaID = 5, DatumVoznje = DateTime.UtcNow.Date, PocetakVoznje = "11:00", KrajVoznje = "15:00", Trajanje = "4h", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Voznja { ID = 5, PocetnaDestinacijaID = 5, KrajnjaDestinacijaID = 1, DatumVoznje = DateTime.UtcNow.Date, PocetakVoznje = "12:00", KrajVoznje = "16:00", Trajanje = "4h", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
            );

            modelBuilder.Entity<Karta>().HasData(
                new Karta { ID = 1, KorisnikID = 1, VoznjaID = 1, KlasaVoznje = Klasa.Prva, Obrok = true, Popust = false, BrojPerona = 2, Cijena = 50.0, isPlaceno = true, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Karta { ID = 2, KorisnikID = 2, VoznjaID = 2, KlasaVoznje = Klasa.Prva, Obrok = true, Popust = true, BrojPerona = 3, Cijena = 60.0, isPlaceno = true, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Karta { ID = 3, KorisnikID = 3, VoznjaID = 3, KlasaVoznje = Klasa.Druga, Obrok = false, Popust = false, BrojPerona = 1, Cijena = 40.0, isPlaceno = true, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Karta { ID = 4, KorisnikID = 4, VoznjaID = 4, KlasaVoznje = Klasa.Druga, Obrok = true, Popust = true, BrojPerona = 4, Cijena = 70.0, isPlaceno = true, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Karta { ID = 5, KorisnikID = 5, VoznjaID = 5, KlasaVoznje = Klasa.Prva, Obrok = true, Popust = false, BrojPerona = 2, Cijena = 55.0, isPlaceno = true, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
            );
            modelBuilder.Entity<StatusPosiljki>().HasData(
                 new StatusPosiljki { ID = 1, KorisnikID = 1, Status = "U transportu", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                 new StatusPosiljki { ID = 2, KorisnikID = 1, Status = "Isporučeno", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
             );

            modelBuilder.Entity<LojalnostProgram>().HasData(
                new LojalnostProgram { ID = 1, KorisnikID = 1, Poeni = 100, Nivo = "Silver", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new LojalnostProgram { ID = 2, KorisnikID = 2, Poeni = 250, Nivo = "Gold", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
            );

            modelBuilder.Entity<FavoritiRute>().HasData(
                new FavoritiRute { ID = 1, KorisnikID = 1, RasporedVoznjiID = 5, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new FavoritiRute { ID = 2, KorisnikID = 2, RasporedVoznjiID = 3, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
            );

            modelBuilder.Entity<HstorijaPlacanja>().HasData(
                new HstorijaPlacanja { ID = 1, KorisnikID = 1, Iznos = 120.50m, DatumPlacanja = DateTime.UtcNow, MetodPlacanja = "Kreditna kartica", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new HstorijaPlacanja { ID = 2, KorisnikID = 2, Iznos = 89.99m, DatumPlacanja = DateTime.UtcNow, MetodPlacanja = "PayPal", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
            );

            modelBuilder.Entity<ObavestenjaKorisnicima>().HasData(
                new ObavestenjaKorisnicima { ID = 1, KorisnikID = 1, Poruka = "Voz kasni 15 minuta",  DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new ObavestenjaKorisnicima { ID = 2, KorisnikID = 2, Poruka = "Nova promotivna ponuda", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
            );

            modelBuilder.Entity<OcjenjivanjeZaposlenih>().HasData(
                new OcjenjivanjeZaposlenih { ID = 1, ZaposleniID = 1, Ocjena = 5, Komentar = "Odlična usluga", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new OcjenjivanjeZaposlenih { ID = 2, ZaposleniID = 2, Ocjena = 4, Komentar = "Vrlo dobra usluga", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
            );

            modelBuilder.Entity<OtkazivanjaRezervacija>().HasData(
                new OtkazivanjaRezervacija { ID = 1, KorisnikID = 1, Razlog = "Promjena plana", DatumOtkazivanja = DateTime.UtcNow, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new OtkazivanjaRezervacija { ID = 2, KorisnikID = 2, Razlog = "Kašnjenje voza", DatumOtkazivanja = DateTime.UtcNow, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
            );

            modelBuilder.Entity<PaketnePonude>().HasData(
                new PaketnePonude { ID = 1, Naziv = "Porodični paket", Opis = "Paket za porodice sa 20% popusta", Popust = 20, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new PaketnePonude { ID = 2, Naziv = "Studentski paket", Opis = "Paket za studente sa 15% popusta", Popust = 15, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
            );

            modelBuilder.Entity<PartneriPrevoznici>().HasData(
                new PartneriPrevoznici { ID = 1, NazivPartnera = "Prevoznik A", KontaktTelefon = "123456789", Adresa = "Ulica 1", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new PartneriPrevoznici { ID = 2, NazivPartnera = "Prevoznik B", KontaktTelefon = "987654321", Adresa = "Ulica 2", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
            );

            modelBuilder.Entity<Posiljka>().HasData(
                new Posiljka { ID = 1, PosiljaocID = 1, PrimalacID = 2, StatusPosiljkeID = 6, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new Posiljka { ID = 2, PosiljaocID = 2, PrimalacID = 1, StatusPosiljkeID = 7,  DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
            );

            modelBuilder.Entity<PromocijePopusti>().HasData(
                new PromocijePopusti { ID = 1, Naziv = "Letnja akcija", ProcenatPopusta = 30, DatumPocetka = DateTime.UtcNow, DatumKraja = DateTime.UtcNow.AddMonths(1), DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new PromocijePopusti { ID = 2, Naziv = "Zimski popust", ProcenatPopusta = 25, DatumPocetka = DateTime.UtcNow, DatumKraja = DateTime.UtcNow.AddMonths(2), DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
            );

            modelBuilder.Entity<RasporedOdrzavanjaVozova>().HasData(
                new RasporedOdrzavanjaVozova { ID = 1, VozID = 1, DatumOdrzavanja = DateTime.UtcNow.AddMonths(1), Napomena = "Redovan servis", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new RasporedOdrzavanjaVozova { ID = 2, VozID = 2, DatumOdrzavanja = DateTime.UtcNow.AddMonths(2), Napomena = "Zimska priprema", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
            );

            modelBuilder.Entity<RecenzijeVozova>().HasData(
                new RecenzijeVozova { ID = 1, KorisnikID = 1, VozID = 1, Ocjena = 5, Komentar = "Brz i udoban", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new RecenzijeVozova { ID = 2, KorisnikID = 2, VozID = 2, Ocjena = 4, Komentar = "Dobar, ali može bolje", DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
            );

            modelBuilder.Entity<ReklamacijeKorisnika>().HasData(
                new ReklamacijeKorisnika { ID = 1, KorisnikID = 1, Opis = "Kasno uručenje", Reseno = true, DatumReklamacije = DateTime.UtcNow, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new ReklamacijeKorisnika { ID = 2, KorisnikID = 2, Opis = "Oštećena pošiljka", Reseno = false, DatumReklamacije = DateTime.UtcNow, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
            );

            modelBuilder.Entity<RezervacijaSedista>().HasData(
                new RezervacijaSedista { ID = 1, KorisnikID = 1, VozID = 1, BrojSjedista = "A1",  DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new RezervacijaSedista { ID = 2, KorisnikID = 2, VozID = 2, BrojSjedista = "B5",  DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
            );

           
            modelBuilder.Entity<VremenskaPrognoza>().HasData(
                new VremenskaPrognoza { ID = 1, Grad = "Sarajevo", Prognoza = "Oblacno", Datum = DateTime.UtcNow, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow },
                new VremenskaPrognoza { ID = 2, Grad = "Banja Luka", Prognoza = "Suncano", Datum = DateTime.UtcNow, DateCreated = DateTime.UtcNow, DateModified = DateTime.UtcNow }
            );
        

    }
}
}
