using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class AddRel22334 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Profile_ProfileId",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_ProfileId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Address");

            migrationBuilder.AddColumn<Guid>(
                name: "AddressId",
                table: "Profile",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Profile_AddressId",
                table: "Profile",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Profile_Address_AddressId",
                table: "Profile",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "ProfileId",
                table: "Address",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Address_ProfileId",
                table: "Address",
                column: "ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Profile_ProfileId",
                table: "Address",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
