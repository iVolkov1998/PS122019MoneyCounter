using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rubic.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nickname = table.Column<string>(nullable: true),
                    IsBoy = table.Column<bool>(nullable: false),
                    Birthday = table.Column<DateTimeOffset>(nullable: false),
                    PhoneNumberPrefix = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<long>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    AvatarUrl = table.Column<string>(nullable: true),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    HatImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profiles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProfileId = table.Column<int>(nullable: false),
                    ContentUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Videos_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SavedVideos",
                columns: table => new
                {
                    ProfileId = table.Column<int>(nullable: false),
                    VideoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SavedVideos", x => new { x.ProfileId, x.VideoId });
                    table.ForeignKey(
                        name: "FK_SavedVideos_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SavedVideos_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VideoComments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VideoId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    DateTimeStamp = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoComments_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_UserId",
                table: "Profiles",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SavedVideos_ProfileId",
                table: "SavedVideos",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_SavedVideos_VideoId",
                table: "SavedVideos",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoComments_VideoId",
                table: "VideoComments",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_Videos_ProfileId",
                table: "Videos",
                column: "ProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SavedVideos");

            migrationBuilder.DropTable(
                name: "VideoComments");

            migrationBuilder.DropTable(
                name: "Videos");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
