using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DLEFCore2.Migrations
{
    /// <inheritdoc />
    public partial class AddNumbersToUserModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name1 = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Ronnie"),
                    Name11 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name3 = table.Column<string>(type: "nvarchar(257)", maxLength: 257, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsActive2 = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDateTime1 = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Age1 = table.Column<int>(type: "int", nullable: false),
                    Age2 = table.Column<long>(type: "bigint", nullable: false),
                    value1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    value2 = table.Column<double>(type: "float", nullable: false),
                    value3 = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
