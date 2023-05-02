using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class DeleteRelationShipBProfile2Address : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Profile_Address_AddressId",
                table: "Profile");

            migrationBuilder.DropIndex(
                name: "IX_Profile_AddressId",
                table: "Profile");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Profile");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AddressId",
                table: "Profile",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Profile_AddressId",
                table: "Profile",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profile_Address_AddressId",
                table: "Profile",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id");
        }
    }
}
