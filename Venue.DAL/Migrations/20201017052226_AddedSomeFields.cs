using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Venue.DAL.Migrations
{
    public partial class AddedSomeFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Photos");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Places",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Places",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Picture",
                table: "Photos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Photos");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Photos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
