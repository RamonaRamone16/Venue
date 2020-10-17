using Microsoft.EntityFrameworkCore.Migrations;

namespace Venue.DAL.Migrations
{
    public partial class ChangedPhotoEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Places_VenueId",
                table: "Photos");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Places_VenueId",
                table: "Photos",
                column: "VenueId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Places_VenueId",
                table: "Photos");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Places_VenueId",
                table: "Photos",
                column: "VenueId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
