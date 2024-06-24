using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspNetCoreMvc_eTicaret_MovieSales.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Email", "Name", "Password", "Phone" },
                values: new object[,]
                {
                    { 1, "Beşiktaş - İstanbul", "ali@gmail.com", "Ali Uçar", "123", "533 333 33 33" },
                    { 2, "Kadıköy - İstanbul", "oya@gmail.com", "Oya Uçar", "123", "533 333 33 33" },
                    { 3, "Bakırköy - İstanbul", "nese@gmail.com", "Neşe Sever", "123", "533 333 33 33" },
                    { 4, "Fatih - İstanbul", "hasan@gmail.com", "Hasan Kaya", "123", "533 333 33 33" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Komik olaylar", "Komedi" },
                    { 2, "Tarihi savaşlar, kani şiddet", "Savaş" },
                    { 3, "Hem romantik hem komik", "Romantik Komedi" },
                    { 4, "Acıklı hikayeler", "Dram" },
                    { 5, "Korku, gerilim", "Korku" },
                    { 6, "Robotlar, uzay", "Bilim Kurgu" },
                    { 7, "Gerçek dışı, heyecenlı", "Fantastik" },
                    { 8, "Hareket, aksiyon dolu sahneler", "Aksiyon" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "Cast", "Director", "GenreId", "ImageUrl", "IsDiscount", "IsLocal", "Name", "Price", "ReleaseDate", "Stock", "Summary" },
                values: new object[,]
                {
                    { 1, "Brad Pitt", "Wolfgan Petter", 2, "/images/truva.jpg", false, false, "Truva", 350m, new DateTime(1992, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Tarihten Truva savaşından kesitler" },
                    { 2, "Ananda George, Denny Alamsyah", "Gareth Evans", 8, "/images/baskin.jpg", false, false, "Baskın", 340m, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Operasyon timinin uyuşturucu baskınları" },
                    { 3, "Leonardo Di Caprio, Cate Winelet", "James Cameron", 4, "/images/baskin.jpg", false, false, "Titanic", 320m, new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Lüks Titanci gemisinin hazin öyküsü" },
                    { 4, "Bradd Pitt, Edward Norton", "David Lyinch", 4, "/images/fight.jpg", false, false, "Fight Club", 320m, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Dövüş kulübü, ilk kural bahsetmemek" },
                    { 5, "Bradd Pitt, Christoph Wals", "Quentin Tarantino", 2, "/images/fight.jpg", false, false, "Soysuzlar Çetesi", 310m, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "2. Dünya savaşından kesitler" },
                    { 6, "Bradd Pitt, Christoph Wals", "Quentin Tarantino", 2, "/images/fight.jpg", false, false, "Soysuzlar Çetesi", 310m, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "2. Dünya savaşından kesitler" },
                    { 7, "Bradd Pitt, Christoph Wals", "Quentin Tarantino", 2, "/images/fight.jpg", false, false, "Soysuzlar Çetesi", 310m, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "2. Dünya savaşından kesitler" },
                    { 8, "Bradd Pitt, Christoph Wals", "Quentin Tarantino", 2, "/images/fight.jpg", false, false, "Soysuzlar Çetesi", 310m, new DateTime(2006, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "2. Dünya savaşından kesitler" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AlterColumn<int>(
                name: "Password",
                table: "Customers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
