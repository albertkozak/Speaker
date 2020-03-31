using Microsoft.EntityFrameworkCore.Migrations;

namespace SpeakerAPI.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Speakers",
                columns: table => new
                {
                    SpeakerId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    Specialization = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Province = table.Column<string>(nullable: true),
                    Employer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speakers", x => x.SpeakerId);
                });

            migrationBuilder.InsertData(
                table: "Speakers",
                columns: new[] { "SpeakerId", "City", "Email", "Employer", "FirstName", "LastName", "MobileNumber", "Province", "Specialization" },
                values: new object[,]
                {
                    { "bd7f16df-ee6a-402f-aeb4-96e0b64de30d", "Vancouver", "jdoe@gmail.com", "UBC", "John", "Doe", "604-123-4567", "BC", "JavaScript" },
                    { "8b3017b4-2882-432f-be4f-5cc60821d532", "Maple Ridge", "pweier@gmail.com", "BCIT", "Phil", "Weier", "604-987-6543", "BC", ".NET" },
                    { "1696df16-1aa4-4058-841f-ce95d48b7ee2", "Vancouver", "jharrison@gmail.com", "SFU", "Jason", "Harrison", "604-111-1111", "BC", "Laravel" },
                    { "172aa0ac-bc8b-4f4c-ad71-b1fb2ec6c9a1", "Chilliwack", "acooper@gmail.com", "BCIT", "Alex", "Cooper", "604-2121-2121", "BC", "HTML/CSS" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speakers");
        }
    }
}
