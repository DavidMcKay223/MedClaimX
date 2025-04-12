using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedClaimX.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ClaimNOrganization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Claims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryAddress_Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PrimaryAddress_City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PrimaryAddress_State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PrimaryAddress_ZipCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PrimaryAddress_GeoLocation_Latitude = table.Column<double>(type: "float", nullable: true),
                    PrimaryAddress_GeoLocation_Longitude = table.Column<double>(type: "float", nullable: true),
                    SecondaryAddress_Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SecondaryAddress_City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SecondaryAddress_State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SecondaryAddress_ZipCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SecondaryAddress_GeoLocation_Latitude = table.Column<double>(type: "float", nullable: true),
                    SecondaryAddress_GeoLocation_Longitude = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Claims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentObjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentId = table.Column<int>(type: "int", nullable: false),
                    ObjectId = table.Column<int>(type: "int", nullable: false),
                    ObjectType = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentObjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    FileExtension = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Content = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrgType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Tin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PrimaryAddress_Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PrimaryAddress_City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PrimaryAddress_State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PrimaryAddress_ZipCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    PrimaryAddress_GeoLocation_Latitude = table.Column<double>(type: "float", nullable: true),
                    PrimaryAddress_GeoLocation_Longitude = table.Column<double>(type: "float", nullable: true),
                    SecondaryAddress_Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SecondaryAddress_City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SecondaryAddress_State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SecondaryAddress_ZipCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    SecondaryAddress_GeoLocation_Latitude = table.Column<double>(type: "float", nullable: true),
                    SecondaryAddress_GeoLocation_Longitude = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Claims");

            migrationBuilder.DropTable(
                name: "DocumentObjects");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "Organizations");
        }
    }
}
