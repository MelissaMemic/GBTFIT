using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GBT.Migrations
{
    /// <inheritdoc />
    public partial class AddTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoritiRute",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    RasporedVoznjiID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoritiRute", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FavoritiRute_Korisnik_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoritiRute_Voznja_RasporedVoznjiID",
                        column: x => x.RasporedVoznjiID,
                        principalTable: "Voznja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            
            migrationBuilder.CreateTable(
                name: "LojalnostProgram",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Poeni = table.Column<int>(type: "int", nullable: false),
                    Nivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LojalnostProgram", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LojalnostProgram_Korisnik_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ObavestenjaKorisnicima",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Poruka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumSlanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Procitano = table.Column<bool>(type: "bit", nullable: false),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObavestenjaKorisnicima", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ObavestenjaKorisnicima_Korisnik_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OcjenjivanjeZaposlenih",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ocjena = table.Column<int>(type: "int", nullable: false),
                    Komentar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumOcenjivanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ZaposleniID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OcjenjivanjeZaposlenih", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OcjenjivanjeZaposlenih_Korisnik_ZaposleniID",
                        column: x => x.ZaposleniID,
                        principalTable: "Korisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OtkazivanjaRezervacija",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumOtkazivanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Razlog = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RezervacijaID = table.Column<int>(type: "int", nullable: false),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtkazivanjaRezervacija", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OtkazivanjaRezervacija_Korisnik_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OtkazivanjaRezervacija_Voznja_RezervacijaID",
                        column: x => x.RezervacijaID,
                        principalTable: "Voznja",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaketnePonude",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Popust = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaketnePonude", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PartneriPrevoznici",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivPartnera = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KontaktTelefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartneriPrevoznici", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PromocijePopusti",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcenatPopusta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DatumPocetka = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumKraja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromocijePopusti", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ReklamacijeKorisnika",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumReklamacije = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reseno = table.Column<bool>(type: "bit", nullable: false),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReklamacijeKorisnika", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReklamacijeKorisnika_Korisnik_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TipRute",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrzavaPolaska = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrzavaDolaska = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zabrane = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipRute", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UpitiKorisnickePodrske",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sadrzaj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumUpita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpitiKorisnickePodrske", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UpitiKorisnickePodrske_Korisnik_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Voz",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrojSjedista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Boja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumServisiranja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voz", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VremenskaPrognoza",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prognoza = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VremenskaPrognoza", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RasporedOdrzavanjaVozova",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumOdrzavanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Napomena = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VozID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RasporedOdrzavanjaVozova", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RasporedOdrzavanjaVozova_Voz_VozID",
                        column: x => x.VozID,
                        principalTable: "Voz",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecenzijeVozova",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ocjena = table.Column<int>(type: "int", nullable: false),
                    Komentar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumRecenzije = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    VozID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecenzijeVozova", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RecenzijeVozova_Korisnik_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RecenzijeVozova_Voz_VozID",
                        column: x => x.VozID,
                        principalTable: "Voz",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RezervacijaSedista",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojSjedista = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RezervacijaID = table.Column<int>(type: "int", nullable: false),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    VozID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RezervacijaSedista", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RezervacijaSedista_Karta_RezervacijaID",
                        column: x => x.RezervacijaID,
                        principalTable: "Karta",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RezervacijaSedista_Korisnik_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RezervacijaSedista_Voz_VozID",
                        column: x => x.VozID,
                        principalTable: "Voz",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posiljka",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusPosiljkeID = table.Column<int>(type: "int", nullable: false),
                    PosiljaocID = table.Column<int>(type: "int", nullable: false),
                    PrimalacID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posiljka", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Posiljka_Korisnik_PosiljaocID",
                        column: x => x.PosiljaocID,
                        principalTable: "Korisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posiljka_Korisnik_PrimalacID",
                        column: x => x.PrimalacID,
                        principalTable: "Korisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "StatusPosiljki",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumStatusa = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PosiljkaID = table.Column<int>(type: "int", nullable: false),
                    KorisnikID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusPosiljki", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StatusPosiljki_Korisnik_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_StatusPosiljki_Posiljka_PosiljkaID",
                        column: x => x.PosiljkaID,
                        principalTable: "Posiljka",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5350), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5350) });

            migrationBuilder.InsertData(
                table: "Voz",
                columns: new[] { "ID", "DateCreated", "DateModified", "Naziv", "BrojSjedista", "Boja", "DatumServisiranja" },
                values: new object[,]
            {
                { 1,new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1410), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1410), "V1232", "100", "Crvena", "2024-01-15" },
                { 2, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1410), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1410), "V3323", "120", "Plava", "2024-02-20" },
                { 3,new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1410), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1410),  "V4555", "150", "Zelena", "2024-03-10" },
                { 4,new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1410), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1410),  "V2355", "80", "Žuta", "2024-04-05" }
            });
            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5360), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5360), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5360), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5360), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5360) });

            migrationBuilder.InsertData(
                table: "FavoritiRute",
                columns: new[] { "ID", "DateCreated", "DateModified", "KorisnikID", "RasporedVoznjiID" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5670), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5670), 1, 5 },
                    { 2, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5680), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5680), 2, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5460), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5470), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5470), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5470), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5470), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5470) });

           

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5610), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5620), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5620), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5620), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5620), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Token" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5520), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5520), "secret" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5520), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5520), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5540), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5550), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5550), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5550), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5550), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5550) });

            migrationBuilder.InsertData(
                table: "LojalnostProgram",
                columns: new[] { "ID", "DateCreated", "DateModified", "KorisnikID", "Nivo", "Poeni" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5660), 1, "Silver", 100 },
                    { 2, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5660), 2, "Gold", 250 }
                });

            migrationBuilder.InsertData(
                table: "ObavestenjaKorisnicima",
                columns: new[] { "ID", "DateCreated", "DateModified", "DatumSlanja", "KorisnikID", "Poruka", "Procitano" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5710), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5710), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Voz kasni 15 minuta", false },
                    { 2, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5710), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5710), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Nova promotivna ponuda", false }
                });

            migrationBuilder.InsertData(
                table: "OcjenjivanjeZaposlenih",
                columns: new[] { "ID", "DateCreated", "DateModified", "DatumOcenjivanja", "Komentar", "Ocjena", "ZaposleniID" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5730), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5730), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Odlična usluga", 5, 1 },
                    { 2, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5730), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5730), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vrlo dobra usluga", 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "OtkazivanjaRezervacija",
                columns: new[] { "ID", "DateCreated", "DateModified", "DatumOtkazivanja", "KorisnikID", "Razlog", "RezervacijaID" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5750), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5750), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5750), 1, "Promjena plana", 1 },
                    { 2, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5750), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5750), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5750), 2, "Kašnjenje voza", 1 }
                });

            migrationBuilder.InsertData(
                table: "PaketnePonude",
                columns: new[] { "ID", "DateCreated", "DateModified", "Naziv", "Opis", "Popust" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5770), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5770), "Porodični paket", "Paket za porodice sa 20% popusta", 20 },
                    { 2, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5770), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5770), "Studentski paket", "Paket za studente sa 15% popusta", 15 }
                });

            migrationBuilder.InsertData(
                table: "PartneriPrevoznici",
                columns: new[] { "ID", "Adresa", "DateCreated", "DateModified", "KontaktTelefon", "NazivPartnera" },
                values: new object[,]
                {
                    { 1, "Ulica 1", new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5780), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5780), "123456789", "Prevoznik A" },
                    { 2, "Ulica 2", new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5790), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5790), "987654321", "Prevoznik B" }
                });

            migrationBuilder.InsertData(
                table: "Posiljka",
                columns: new[] { "ID", "DateCreated", "DateModified", "PosiljaocID", "PrimalacID", "StatusPosiljkeID" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5800), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5800), 1, 2, 1 },
                    { 2, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5800), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5800), 2, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "PromocijePopusti",
                columns: new[] { "ID", "DateCreated", "DateModified", "DatumKraja", "DatumPocetka", "Naziv", "ProcenatPopusta" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5830), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5830), new DateTime(2024, 10, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5820), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5820), "Letnja akcija", 30m },
                    { 2, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5830), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5830), new DateTime(2024, 11, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5830), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5830), "Zimski popust", 25m }
                });

            migrationBuilder.InsertData(
                table: "RasporedOdrzavanjaVozova",
                columns: new[] { "ID", "DateCreated", "DateModified", "DatumOdrzavanja", "Napomena", "VozID" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5840), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5840), new DateTime(2024, 10, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5840), "Redovan servis", 1 },
                    { 2, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5850), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5850), new DateTime(2024, 11, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5850), "Zimska priprema", 2 }
                });

            migrationBuilder.InsertData(
                table: "RecenzijeVozova",
                columns: new[] { "ID", "DateCreated", "DateModified", "DatumRecenzije", "Komentar", "KorisnikID", "Ocjena", "VozID" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5860), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5860), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brz i udoban", 1, 5, 1 },
                    { 2, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5860), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5860), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dobar, ali može bolje", 2, 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "ReklamacijeKorisnika",
                columns: new[] { "ID", "DateCreated", "DateModified", "DatumReklamacije", "KorisnikID", "Opis", "Reseno" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5880), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5880), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5880), 1, "Kasno uručenje", true },
                    { 2, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5880), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5880), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5880), 2, "Oštećena pošiljka", false }
                });

            migrationBuilder.InsertData(
                table: "RezervacijaSedista",
                columns: new[] { "ID", "BrojSjedista", "DateCreated", "DateModified", "KorisnikID", "RezervacijaID", "VozID" },
                values: new object[,]
                {
                    { 1, "A1", new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5900), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5900), 1, 1, 1 },
                    { 2, "B5", new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5900), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5900), 2, 2, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5490), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5490), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5490), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5500), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5500), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.InsertData(
                table: "StatusPosiljki",
                columns: new[] { "ID", "DateCreated", "DateModified", "DatumStatusa", "KorisnikID", "PosiljkaID", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5640), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5640), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "U transportu" },
                    { 2, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5640), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5640), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "Isporučeno" }
                });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5580), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5580), new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5580), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5580), new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5580), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5580), new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5580), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5580), new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5590), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5590), new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.InsertData(
                table: "VremenskaPrognoza",
                columns: new[] { "ID", "DateCreated", "DateModified", "Datum", "Grad", "Prognoza" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5940), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5940), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5940), "Sarajevo", "Oblacno" },
                    { 2, new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5940), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5950), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5940), "Banja Luka", "Suncano" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FavoritiRute_KorisnikID",
                table: "FavoritiRute",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_FavoritiRute_RasporedVoznjiID",
                table: "FavoritiRute",
                column: "RasporedVoznjiID");


            migrationBuilder.CreateIndex(
                name: "IX_LojalnostProgram_KorisnikID",
                table: "LojalnostProgram",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_ObavestenjaKorisnicima_KorisnikID",
                table: "ObavestenjaKorisnicima",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_OcjenjivanjeZaposlenih_ZaposleniID",
                table: "OcjenjivanjeZaposlenih",
                column: "ZaposleniID");

            migrationBuilder.CreateIndex(
                name: "IX_OtkazivanjaRezervacija_KorisnikID",
                table: "OtkazivanjaRezervacija",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_OtkazivanjaRezervacija_RezervacijaID",
                table: "OtkazivanjaRezervacija",
                column: "RezervacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Posiljka_PosiljaocID",
                table: "Posiljka",
                column: "PosiljaocID");

            migrationBuilder.CreateIndex(
                name: "IX_Posiljka_PrimalacID",
                table: "Posiljka",
                column: "PrimalacID");

            migrationBuilder.CreateIndex(
                name: "IX_Posiljka_StatusPosiljkeID",
                table: "Posiljka",
                column: "StatusPosiljkeID");

            migrationBuilder.CreateIndex(
                name: "IX_RasporedOdrzavanjaVozova_VozID",
                table: "RasporedOdrzavanjaVozova",
                column: "VozID");

            migrationBuilder.CreateIndex(
                name: "IX_RecenzijeVozova_KorisnikID",
                table: "RecenzijeVozova",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_RecenzijeVozova_VozID",
                table: "RecenzijeVozova",
                column: "VozID");

            migrationBuilder.CreateIndex(
                name: "IX_ReklamacijeKorisnika_KorisnikID",
                table: "ReklamacijeKorisnika",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_RezervacijaSedista_KorisnikID",
                table: "RezervacijaSedista",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_RezervacijaSedista_RezervacijaID",
                table: "RezervacijaSedista",
                column: "RezervacijaID");

            migrationBuilder.CreateIndex(
                name: "IX_RezervacijaSedista_VozID",
                table: "RezervacijaSedista",
                column: "VozID");

            migrationBuilder.CreateIndex(
                name: "IX_StatusPosiljki_KorisnikID",
                table: "StatusPosiljki",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_StatusPosiljki_PosiljkaID",
                table: "StatusPosiljki",
                column: "PosiljkaID");

            migrationBuilder.CreateIndex(
                name: "IX_UpitiKorisnickePodrske_KorisnikID",
                table: "UpitiKorisnickePodrske",
                column: "KorisnikID");

            migrationBuilder.AddForeignKey(
                name: "FK_Posiljka_StatusPosiljki_StatusPosiljkeID",
                table: "Posiljka",
                column: "StatusPosiljkeID",
                principalTable: "StatusPosiljki",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posiljka_StatusPosiljki_StatusPosiljkeID",
                table: "Posiljka");

            migrationBuilder.DropTable(
                name: "FavoritiRute");

            migrationBuilder.DropTable(
                name: "LojalnostProgram");

            migrationBuilder.DropTable(
                name: "ObavestenjaKorisnicima");

            migrationBuilder.DropTable(
                name: "OcjenjivanjeZaposlenih");

            migrationBuilder.DropTable(
                name: "OtkazivanjaRezervacija");

            migrationBuilder.DropTable(
                name: "PaketnePonude");

            migrationBuilder.DropTable(
                name: "PartneriPrevoznici");

            migrationBuilder.DropTable(
                name: "PromocijePopusti");

            migrationBuilder.DropTable(
                name: "RasporedOdrzavanjaVozova");

            migrationBuilder.DropTable(
                name: "RecenzijeVozova");

            migrationBuilder.DropTable(
                name: "ReklamacijeKorisnika");

            migrationBuilder.DropTable(
                name: "RezervacijaSedista");

            migrationBuilder.DropTable(
                name: "TipRute");

            migrationBuilder.DropTable(
                name: "UpitiKorisnickePodrske");

            migrationBuilder.DropTable(
                name: "VremenskaPrognoza");

            migrationBuilder.DropTable(
                name: "Voz");

            migrationBuilder.DropTable(
                name: "StatusPosiljki");

            migrationBuilder.DropTable(
                name: "Posiljka");

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1400), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1400), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1410), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1410), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1410), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1510), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1510), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1510), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1520), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1520), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1650), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1660), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1660), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1660), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1670), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Token" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1560), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1560), "token1" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1570), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1570), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1570), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1580), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1590), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1600), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1600), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1600), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1600), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1620), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1620), new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1620), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1620), new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 8, 28, 0, 0, 0, 0, DateTimeKind.Utc) });
        }
    }
}
