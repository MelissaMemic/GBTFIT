using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBT.Migrations
{
    /// <inheritdoc />
    public partial class AddPdfToKarta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Pdf",
                table: "Karta",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(3780), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(3790), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(3790), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(3790), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(3790), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(3790) });


            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Pdf" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4070), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4070), null });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Pdf" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4080), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4080), null });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "Pdf" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4080), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4080), null });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "Pdf" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4080), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4080), null });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "Pdf" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4080), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4080), null });


            migrationBuilder.UpdateData(
                table: "LojalnostProgram",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4120), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "ObavestenjaKorisnicima",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4180), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "ObavestenjaKorisnicima",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4190), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "OcjenjivanjeZaposlenih",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4200), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "OcjenjivanjeZaposlenih",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4200), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "OtkazivanjaRezervacija",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "DatumOtkazivanja" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4220), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4220), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "OtkazivanjaRezervacija",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "DatumOtkazivanja" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4220), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4220), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "PaketnePonude",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4240), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4240) });

            migrationBuilder.UpdateData(
                table: "PaketnePonude",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4240), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4240) });

            migrationBuilder.UpdateData(
                table: "PartneriPrevoznici",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4260), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "PartneriPrevoznici",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4260), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "Posiljka",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4270), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Posiljka",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4270), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "PromocijePopusti",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "DatumKraja", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4300), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4300), new DateTime(2025, 3, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4290), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "PromocijePopusti",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "DatumKraja", "DatumPocetka" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4300), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4300), new DateTime(2025, 4, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4300), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "RasporedOdrzavanjaVozova",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "DatumOdrzavanja" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4320), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4320), new DateTime(2025, 3, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "RasporedOdrzavanjaVozova",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "DatumOdrzavanja" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4320), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4320), new DateTime(2025, 4, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "RecenzijeVozova",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4340), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "RecenzijeVozova",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4340), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "ReklamacijeKorisnika",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "DatumReklamacije" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4350), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4350), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "ReklamacijeKorisnika",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "DatumReklamacije" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4360), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4360), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "RezervacijaSedista",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4370), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "RezervacijaSedista",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4370), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(3950), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(3950), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(3960), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(3960), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(3960), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "StatusPosiljki",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4100), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "StatusPosiljki",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4100), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4040), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4040), new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4040), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4040), new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4040), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4040), new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4050), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4050), new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4050), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4050), new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "VremenskaPrognoza",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "Datum" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4390), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4390), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "VremenskaPrognoza",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "Datum" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4390), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4390), new DateTime(2025, 2, 9, 22, 27, 48, 130, DateTimeKind.Utc).AddTicks(4390) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pdf",
                table: "Karta");

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
                table: "HstorijaPlacanja",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified", "DatumPlacanja" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5800), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5800), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "HstorijaPlacanja",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "DatumPlacanja" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5800), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5800), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5680), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5690), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5690), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5690), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5690), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5690) });

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
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5650), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5650), new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5650), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateModified", "DatumVoznje" },
                values: new object[] { new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 9, 25, 20, 6, 2, 767, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc) });

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
    }
}
