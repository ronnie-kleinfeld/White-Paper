using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DLEFCore2.Migrations
{
    /// <inheritdoc />
    public partial class AddNumbersToUserMode6 : Migration
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
                name: "EntityId",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityId", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntityNoId",
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

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    GroupName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    GroupName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GenderTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_GenderType_GenderTypeId",
                        column: x => x.GenderTypeId,
                        principalTable: "GenderType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersGroups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersGroups_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersGroups_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GenderType",
                columns: new[] { "Id", "Description", "IsDefault", "Name", "OrderBy" },
                values: new object[] { 1, "Male", true, "Male", 1 });

            migrationBuilder.InsertData(
                table: "GenderType",
                columns: new[] { "Id", "Description", "Name", "OrderBy" },
                values: new object[,]
                {
                    { 2, "Female", "Female", 2 },
                    { 3, "Other", "Other", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_GenderTypeId",
                table: "Users",
                column: "GenderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersGroups_GroupId",
                table: "UsersGroups",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersGroups_UserId",
                table: "UsersGroups",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataTypes");

            migrationBuilder.DropTable(
                name: "EntityId");

            migrationBuilder.DropTable(
                name: "EntityNoId");

            migrationBuilder.DropTable(
                name: "UsersGroups");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "GenderType");
        }
    }
}
