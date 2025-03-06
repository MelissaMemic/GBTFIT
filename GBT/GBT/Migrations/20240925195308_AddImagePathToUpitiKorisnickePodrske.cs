using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBT.Migrations
{
    /// <inheritdoc />
    public partial class AddImagePathToUpitiKorisnickePodrske : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "UpitiKorisnickePodrske",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1840), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1850), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1850), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1850), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1850), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "FavoritiRute",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2190), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "FavoritiRute",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2190), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1960), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1960), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1960), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1960), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1960), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1960) });

          
            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2120), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2130), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2130), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2130), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2130), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2010), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2010), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2010), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2040), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "LojalnostProgram",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2170), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "LojalnostProgram",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2170), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "ObavestenjaKorisnicima",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2230), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "ObavestenjaKorisnicima",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2230), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "OcjenjivanjeZaposlenih",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2250), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "OcjenjivanjeZaposlenih",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2250), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "OtkazivanjaRezervacija",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "DatumOtkazivanja" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2260), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2260), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "OtkazivanjaRezervacija",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "DatumOtkazivanja" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2270), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2270), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "PaketnePonude",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2280), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "PaketnePonude",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2280), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "PartneriPrevoznici",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2300), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "PartneriPrevoznici",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2300), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "Posiljka",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2320), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "Posiljka",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2320), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "PromocijePopusti",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "DatumKraja", "DatumPocetka" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2340), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2340), new DateTime(2024, 10, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2340), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "PromocijePopusti",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "DatumKraja", "DatumPocetka" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2350), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2350), new DateTime(2024, 11, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2350), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "RasporedOdrzavanjaVozova",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "DatumOdrzavanja" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2360), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2360), new DateTime(2024, 10, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "RasporedOdrzavanjaVozova",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "DatumOdrzavanja" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2360), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2360), new DateTime(2024, 11, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "RecenzijeVozova",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2380), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "RecenzijeVozova",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2380), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "ReklamacijeKorisnika",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "DatumReklamacije" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2400), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2400), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "ReklamacijeKorisnika",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "DatumReklamacije" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2400), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2400), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "RezervacijaSedista",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2410), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "RezervacijaSedista",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2420), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1990), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1990), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1990), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "StatusPosiljki",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2150), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "StatusPosiljki",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2160), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2070), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2070), new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2070), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2070), new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2070), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2070), new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2080), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2080), new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2080), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2080), new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "VremenskaPrognoza",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Datum" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2430), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2430), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "VremenskaPrognoza",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Datum" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2440), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2440), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2440) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "UpitiKorisnickePodrske");

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5350), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5350) });

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

            migrationBuilder.UpdateData(
                table: "FavoritiRute",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5670), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "FavoritiRute",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5680), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5680) });

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
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5520), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5520) });

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

            migrationBuilder.UpdateData(
                table: "LojalnostProgram",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "LojalnostProgram",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "ObavestenjaKorisnicima",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5710), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "ObavestenjaKorisnicima",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5710), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "OcjenjivanjeZaposlenih",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5730), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "OcjenjivanjeZaposlenih",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5730), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "OtkazivanjaRezervacija",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "DatumOtkazivanja" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5750), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5750), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "OtkazivanjaRezervacija",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "DatumOtkazivanja" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5750), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5750), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "PaketnePonude",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5770), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "PaketnePonude",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5770), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "PartneriPrevoznici",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5780), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "PartneriPrevoznici",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5790), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Posiljka",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5800), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Posiljka",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5800), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "PromocijePopusti",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "DatumKraja", "DatumPocetka" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5830), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5830), new DateTime(2024, 10, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5820), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "PromocijePopusti",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "DatumKraja", "DatumPocetka" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5830), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5830), new DateTime(2024, 11, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5830), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "RasporedOdrzavanjaVozova",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "DatumOdrzavanja" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5840), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5840), new DateTime(2024, 10, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "RasporedOdrzavanjaVozova",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "DatumOdrzavanja" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5850), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5850), new DateTime(2024, 11, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "RecenzijeVozova",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5860), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "RecenzijeVozova",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5860), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "ReklamacijeKorisnika",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "DatumReklamacije" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5880), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5880), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "ReklamacijeKorisnika",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "DatumReklamacije" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5880), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5880), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "RezervacijaSedista",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5900), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "RezervacijaSedista",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5900), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5900) });

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

            migrationBuilder.UpdateData(
                table: "StatusPosiljki",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5640), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "StatusPosiljki",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5640), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5640) });

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

            migrationBuilder.UpdateData(
                table: "VremenskaPrognoza",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Datum" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5940), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5940), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "VremenskaPrognoza",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Datum" },
                values: new object[] { new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5940), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5950), new DateTime(2024, 9, 12, 22, 15, 42, 978, DateTimeKind.Utc).AddTicks(5940) });
        }
    }
}
