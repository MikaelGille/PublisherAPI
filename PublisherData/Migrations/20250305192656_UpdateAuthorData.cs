using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PublisherData.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAuthorData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtistId", "FirstName", "LastName" },
                values: new object[] { 4, "Leonardo", "da Vinci" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Mikael", "Gille" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Ursula K.", "LeGuin" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Hugh", "Howey" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "FirstName", "LastName" },
                values: new object[] { 7, "Isabelle", "Allende" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AuthorId", "BasePrice", "PublishDate", "Title" },
                values: new object[] { 4, 4, 0m, new DateOnly(2025, 3, 5), "Livet som webbutvecklare" });

            migrationBuilder.InsertData(
                table: "Covers",
                columns: new[] { "CoverId", "BookId", "DesignIdeas", "DigitalOnly" },
                values: new object[] { 4, 4, "Nattvarden", false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtistId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Covers",
                keyColumn: "CoverId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Ursula K.", "LeGuin" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Hugh", "Howey" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Isabelle", "Allende" });
        }
    }
}
