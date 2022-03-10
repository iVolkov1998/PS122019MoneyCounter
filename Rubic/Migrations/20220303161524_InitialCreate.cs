using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rubic.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PhoneNumberPrefix = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Backpacks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Backpacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Backpacks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Moneys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Sum = table.Column<double>(nullable: false),
                    Operation = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moneys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moneys_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    ShortName = table.Column<string>(nullable: true),
                    BackpackId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stocks_Backpacks_BackpackId",
                        column: x => x.BackpackId,
                        principalTable: "Backpacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Backpacks_UserId",
                table: "Backpacks",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Moneys_UserId",
                table: "Moneys",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_BackpackId",
                table: "Stocks",
                column: "BackpackId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Moneys");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Backpacks");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
