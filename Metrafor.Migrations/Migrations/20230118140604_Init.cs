using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Metrafor.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    PersonId = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    LastName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Patronymic = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Inn = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    PassportSeries = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    PassportNumber = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    PassportWho = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: false),
                    PassportWhen = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Phone = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    AddressCity = table.Column<string>(type: "character varying(64)", maxLength: 64, nullable: false),
                    AddressStreet = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    AddressHouse = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false),
                    Position = table.Column<string>(type: "character varying(32)", maxLength: 32, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Login = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    Password = table.Column<string>(type: "character varying(16)", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_Login",
                table: "User",
                column: "Login",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
