using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class addmigrationasd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tripLogModels_accomodation_AccommodationEntityAccommodationId",
                table: "tripLogModels");

            migrationBuilder.DropForeignKey(
                name: "FK_tripLogModels_destination_DestinationEntityDestinationId",
                table: "tripLogModels");

            migrationBuilder.DropIndex(
                name: "IX_tripLogModels_AccommodationEntityAccommodationId",
                table: "tripLogModels");

            migrationBuilder.DropIndex(
                name: "IX_tripLogModels_DestinationEntityDestinationId",
                table: "tripLogModels");

            migrationBuilder.DropColumn(
                name: "AccommodationEntityAccommodationId",
                table: "tripLogModels");

            migrationBuilder.DropColumn(
                name: "DestinationEntityDestinationId",
                table: "tripLogModels");

            migrationBuilder.AlterColumn<int>(
                name: "DestinationId",
                table: "tripLogModels",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "AccommodationId",
                table: "tripLogModels",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_tripLogModels_AccommodationId",
                table: "tripLogModels",
                column: "AccommodationId");

            migrationBuilder.CreateIndex(
                name: "IX_tripLogModels_DestinationId",
                table: "tripLogModels",
                column: "DestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_tripLogModels_accomodation_AccommodationId",
                table: "tripLogModels",
                column: "AccommodationId",
                principalTable: "accomodation",
                principalColumn: "AccommodationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tripLogModels_destination_DestinationId",
                table: "tripLogModels",
                column: "DestinationId",
                principalTable: "destination",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tripLogModels_accomodation_AccommodationId",
                table: "tripLogModels");

            migrationBuilder.DropForeignKey(
                name: "FK_tripLogModels_destination_DestinationId",
                table: "tripLogModels");

            migrationBuilder.DropIndex(
                name: "IX_tripLogModels_AccommodationId",
                table: "tripLogModels");

            migrationBuilder.DropIndex(
                name: "IX_tripLogModels_DestinationId",
                table: "tripLogModels");

            migrationBuilder.AlterColumn<string>(
                name: "DestinationId",
                table: "tripLogModels",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "AccommodationId",
                table: "tripLogModels",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AccommodationEntityAccommodationId",
                table: "tripLogModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DestinationEntityDestinationId",
                table: "tripLogModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tripLogModels_AccommodationEntityAccommodationId",
                table: "tripLogModels",
                column: "AccommodationEntityAccommodationId");

            migrationBuilder.CreateIndex(
                name: "IX_tripLogModels_DestinationEntityDestinationId",
                table: "tripLogModels",
                column: "DestinationEntityDestinationId");

            migrationBuilder.AddForeignKey(
                name: "FK_tripLogModels_accomodation_AccommodationEntityAccommodationId",
                table: "tripLogModels",
                column: "AccommodationEntityAccommodationId",
                principalTable: "accomodation",
                principalColumn: "AccommodationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tripLogModels_destination_DestinationEntityDestinationId",
                table: "tripLogModels",
                column: "DestinationEntityDestinationId",
                principalTable: "destination",
                principalColumn: "DestinationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
