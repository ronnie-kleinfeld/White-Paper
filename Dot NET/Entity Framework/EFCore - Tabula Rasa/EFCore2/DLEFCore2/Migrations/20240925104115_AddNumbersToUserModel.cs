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
                name: "DataTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    field = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NVarChar1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NVarChar2 = table.Column<string>(type: "nvarchar(257)", maxLength: 257, nullable: false),
                    Boolean1 = table.Column<bool>(type: "bit", nullable: false),
                    Boolean2 = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Integer = table.Column<int>(type: "int", nullable: false),
                    Bigint = table.Column<long>(type: "bigint", nullable: false),
                    Decimal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Float = table.Column<double>(type: "float", nullable: false),
                    Real = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntitesId",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntitesId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntitesNoId",
                columns: table => new
                {
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "GenderType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderBy = table.Column<int>(type: "int", nullable: false, defaultValueSql: "-1"),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Disabled = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenderType", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataTypes");

            migrationBuilder.DropTable(
                name: "EntitesId");

            migrationBuilder.DropTable(
                name: "EntitesNoId");

            migrationBuilder.DropTable(
                name: "GenderType");
        }
    }
}
