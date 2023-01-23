using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication6.Migrations
{
    /// <inheritdoc />
    public partial class dbinit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Title", "PublishDate", "Content" },
                values: new object[] { "bai viet 1", new DateTime(2023, 10, 12), "noi dung 1" }
            );
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Title", "PublishDate", "Content" },
                values: new object[] { "bai viet 2", new DateTime(2023, 10, 12), "noi dung 2" }
            );
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Title", "PublishDate", "Content" },
                values: new object[] { "bai viet 3", new DateTime(2023, 10, 12), "noi dung 3" }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");
        }
    }
}
