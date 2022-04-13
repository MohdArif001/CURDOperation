using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CURDOperation.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeakerName = table.Column<string>(maxLength: 100, nullable: false),
                    Qualification = table.Column<string>(maxLength: 100, nullable: false),
                    Experience = table.Column<int>(maxLength: 100, nullable: false),
                    SpeakingDate = table.Column<DateTime>(nullable: false),
                    SpeakingTime = table.Column<DateTime>(nullable: false),
                    Venue = table.Column<string>(maxLength: 255, nullable: false),
                    ProfilePicture = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speaker");
        }
    }
}
