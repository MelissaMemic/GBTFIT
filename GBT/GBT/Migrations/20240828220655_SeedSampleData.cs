using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable


namespace GBT.Migrations
{
    public partial class SeedSampleData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KrajnjaDestinacijaD",
                table: "Voznja");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DatumVoznje",
                table: "Voznja",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.InsertData(
                table: "Drzava",
                columns: new[] { "ID", "DateCreated", "DateModified", "Naziv" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1400), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1400), "Bosna i Hercegovina" },
                    { 2, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1400), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1400), "Hrvatska" },
                    { 3, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1410), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1410), "Srbija" },
                    { 4, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1410), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1410), "Slovenija" },
                    { 5, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1410), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1410), "Crna Gora" }
                });

            migrationBuilder.InsertData(
                table: "Korisnik",
                columns: new[] { "ID", "DateCreated", "DateModified", "Email", "Ime", "Password", "Prezime", "Rola", "Token", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1560), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1560), "fariss@example.com", "Fariss", "password", "Memic", "Admin", "token1", "fariss" },
                    { 2, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1570), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1570), "melissa@example.com", "Melissa", "password", "Memic", "User", "token2", "melissa" },
                    { 3, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1570), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1570), "hana@example.com", "Hana", "password", "Maric", "User", "token3", "hana" },
                    { 4, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1570), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1570), "anel@example.com", "Anel", "password", "Memic", "User", "token4", "anel" },
                    { 5, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1580), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1580), "adil@example.com", "Adil", "password", "Joldic", "User", "token5", "adil" }
                });

            migrationBuilder.InsertData(
                table: "Grad",
                columns: new[] { "ID", "DateCreated", "DateModified", "DrzavaID", "Naziv", "PostanskiBroj" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1510), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1510), 1, "Sarajevo", "71000" },
                    { 2, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1510), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1510), 2, "Zenica", "10000" },
                    { 3, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1510), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1510), 3, "Neum", "11000" },
                    { 4, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1520), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1520), 4, "Mostar", "1000" },
                    { 5, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1520), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1520), 5, "Tuzla", "81000" },
                    { 6, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1520), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1520), 5, "Banja Luka", "81000" },
                    { 7, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1520), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1520), 5, "Bihac", "81000" }
                });

            migrationBuilder.InsertData(
                table: "KreditnaKartica",
                columns: new[] { "ID", "BrojKartice", "Code", "DateCreated", "DateModified", "KorisnikID" },
                values: new object[,]
                {
                    { 1, "1234567890123456", 123, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1590), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1600), 1 },
                    { 2, "2345678901234567", 234, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1600), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1600), 2 },
                    { 3, "3456789012345678", 345, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1600), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1600), 3 },
                    { 4, "4567890123456789", 456, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1600), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1600), 4 },
                    { 5, "5678901234567890", 567, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1600), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1600), 5 }
                });

            migrationBuilder.InsertData(
                table: "Stanica",
                columns: new[] { "ID", "DateCreated", "DateModified", "GradID", "Naziv" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540), 1, "Sarajevo Stanica" },
                    { 2, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540), 2, "Zenica Stanica" },
                    { 3, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540), 3, "Neum Stanica" },
                    { 4, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540), 4, "Mostar Stanica" },
                    { 5, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540), 5, "Tuzla Stanica" },
                    { 6, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540), 6, "Banja Luka Stanica" },
                    { 7, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1540), 7, "Bihac Stanica" }
                });

            migrationBuilder.InsertData(
                table: "Voznja",
                columns: new[] { "ID", "DateCreated", "DateModified", "DatumVoznje", "KrajVoznje", "KrajnjaDestinacijaID", "PocetakVoznje", "PocetnaDestinacijaID", "Trajanje" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1620), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1620), new DateTime(2024, 9, 14, 0, 0, 0, 0, DateTimeKind.Utc), "12:00", 2, "08:00", 1, "4h" },
                    { 2, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1620), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1620), new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Utc), "13:00", 3, "09:00", 2, "4h" },
                    { 3, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 9, 22, 0, 0, 0, 0, DateTimeKind.Utc), "14:00", 4, "10:00", 3, "4h" },
                    { 4, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 9, 21, 0, 0, 0, 0, DateTimeKind.Utc), "15:00", 5, "11:00", 4, "4h" },
                    { 5, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Utc), "15:00", 5, "11:00", 2, "4h" },
                    { 6, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Utc), "15:00", 5, "11:00", 1, "4h" },
                    { 7, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc), "15:00", 1, "11:00", 2, "8h" },
                    { 8, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 9, 30, 0, 0, 0, 0, DateTimeKind.Utc), "15:00", 1, "11:00", 4, "6h" },
                    { 9, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1630), new DateTime(2024, 9, 12, 0, 0, 0, 0, DateTimeKind.Utc), "16:00", 1, "12:00", 5, "2h" }
                });

            migrationBuilder.InsertData(
                table: "Karta",
                columns: new[] { "ID", "BrojPerona", "Cijena", "DateCreated", "DateModified", "KlasaVoznje", "KorisnikID", "Obrok", "Popust", "VoznjaID", "isPlaceno" },
                values: new object[,]
                {
                    { 1, 2, 50.0, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1650), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1650), 0, 1, true, false, 1, true },
                    { 2, 3, 60.0, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1660), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1660), 0, 2, true, true, 2, true },
                    { 3, 1, 40.0, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1660), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1660), 1, 3, false, false, 3, true },
                    { 4, 4, 70.0, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1660), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1660), 1, 4, true, true, 1, true },
                    { 5, 4, 70.0, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1660), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1660), 0, 4, true, true, 9, true },
                    { 6, 4, 70.0, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1660), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1660), 0, 4, true, true, 7, true },
                    { 7, 4, 70.0, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1660), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1660), 1, 4, true, true, 4, true },
                    { 8, 4, 70.0, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1660), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1660), 1, 4, true, true, 5, true },
                    { 9, 2, 55.0, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1670), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1670), 0, 5, true, false, 5, true },
                    { 10, 2, 55.0, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1670), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1670), 0, 1, true, false, 6, true },
                    { 11, 2, 55.0, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1670), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1670), 0, 2, true, false, 7, true },
                    { 12, 2, 55.0, new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1670), new DateTime(2024, 8, 28, 22, 6, 55, 156, DateTimeKind.Utc).AddTicks(1670), 0, 1, true, false, 8, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "KreditnaKartica",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Korisnik",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Voznja",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stanica",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Grad",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Drzava",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DatumVoznje",
                table: "Voznja",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "KrajnjaDestinacijaD",
                table: "Voznja",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
