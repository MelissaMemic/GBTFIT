using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBT.Migrations
{
    /// <inheritdoc />
    public partial class AddImagePathToKarta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Karta",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5420), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5420), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "FavoritiRute",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5770), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "FavoritiRute",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5780), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5540), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5540), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5540), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5540), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5540) });

           
            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Image" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5680), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5680), null });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Image" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5690), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5690), null });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Image" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5690), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5690), null });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Image" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5690), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5690), null });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Image" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5690), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5690), null });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5590), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5590), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5600), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5600), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5600), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5620), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5620), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5620), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5630), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5630), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "LojalnostProgram",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5750), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "LojalnostProgram",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5760), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "ObavestenjaKorisnicima",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5820), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "ObavestenjaKorisnicima",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5820), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "OcjenjivanjeZaposlenih",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5830), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "OcjenjivanjeZaposlenih",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5830), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "OtkazivanjaRezervacija",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "DatumOtkazivanja" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5850), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5850), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "OtkazivanjaRezervacija",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "DatumOtkazivanja" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5850), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5850), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "PaketnePonude",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5870), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "PaketnePonude",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5870), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "PartneriPrevoznici",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5890), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "PartneriPrevoznici",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5890), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Posiljka",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5900), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Posiljka",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5910), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "PromocijePopusti",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "DatumKraja", "DatumPocetka" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5930), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5930), new DateTime(2024, 10, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5920), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "PromocijePopusti",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "DatumKraja", "DatumPocetka" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5930), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5930), new DateTime(2024, 11, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5930), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "RasporedOdrzavanjaVozova",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "DatumOdrzavanja" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5950), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5950), new DateTime(2024, 10, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "RasporedOdrzavanjaVozova",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "DatumOdrzavanja" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5950), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5950), new DateTime(2024, 11, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "RecenzijeVozova",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5970), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "RecenzijeVozova",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5970), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "ReklamacijeKorisnika",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "DatumReklamacije" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5990), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5990), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "ReklamacijeKorisnika",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "DatumReklamacije" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5990), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5990), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "RezervacijaSedista",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(6000), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "RezervacijaSedista",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(6010), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5560), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5560), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5570), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5570), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5570), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "StatusPosiljki",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5710), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "StatusPosiljki",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5710), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5650), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5650), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "VremenskaPrognoza",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Datum" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(6020), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(6020), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "VremenskaPrognoza",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Datum" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(6030), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(6030), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(6030) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Karta");

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
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2070), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2070), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2070), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2080), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2080), new DateTime(2024, 9, 25, 19, 53, 8, 25, DateTimeKind.Utc).AddTicks(2080) });

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
    }
}
