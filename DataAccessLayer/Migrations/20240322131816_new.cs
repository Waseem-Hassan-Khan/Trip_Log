using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "accomodation",
                columns: table => new
                {
                    AccommodationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccommodationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccommodationPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccommodationEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accomodation", x => x.AccommodationId);
                });

            migrationBuilder.CreateTable(
                name: "activities",
                columns: table => new
                {
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_activities", x => x.ActivityId);
                });

            migrationBuilder.CreateTable(
                name: "destination",
                columns: table => new
                {
                    DestinationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestinationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_destination", x => x.DestinationId);
                });

            migrationBuilder.CreateTable(
                name: "tripLogModels",
                columns: table => new
                {
                    TripId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestinationId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccommodationId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThingToDo1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThingToDo2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThingToDo3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DestinationEntityDestinationId = table.Column<int>(type: "int", nullable: false),
                    AccommodationEntityAccommodationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tripLogModels", x => x.TripId);
                    table.ForeignKey(
                        name: "FK_tripLogModels_accomodation_AccommodationEntityAccommodationId",
                        column: x => x.AccommodationEntityAccommodationId,
                        principalTable: "accomodation",
                        principalColumn: "AccommodationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tripLogModels_destination_DestinationEntityDestinationId",
                        column: x => x.DestinationEntityDestinationId,
                        principalTable: "destination",
                        principalColumn: "DestinationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActivitiesTripLogModel",
                columns: table => new
                {
                    ActivitiesActivityId = table.Column<int>(type: "int", nullable: false),
                    TripsTripId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivitiesTripLogModel", x => new { x.ActivitiesActivityId, x.TripsTripId });
                    table.ForeignKey(
                        name: "FK_ActivitiesTripLogModel_activities_ActivitiesActivityId",
                        column: x => x.ActivitiesActivityId,
                        principalTable: "activities",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivitiesTripLogModel_tripLogModels_TripsTripId",
                        column: x => x.TripsTripId,
                        principalTable: "tripLogModels",
                        principalColumn: "TripId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "accomodation",
                columns: new[] { "AccommodationId", "AccommodationEmail", "AccommodationName", "AccommodationPhone" },
                values: new object[,]
                {
                    { 1, "info@hilton.com", "Hilton Hotel", "+123456789" },
                    { 2, "info@marriott.com", "Marriott Resort", "+987654321" },
                    { 3, "host@airbnb.com", "Airbnb Apartment", "+111222333" },
                    { 4, "info@holidayinn.com", "Holiday Inn Express", "+444555666" },
                    { 5, "info@sheraton.com", "Sheraton Suites", "+777888999" },
                    { 6, "info@radisson.com", "Radisson Blu", "+555666777" },
                    { 7, "info@hyatt.com", "Hyatt Regency", "+222333444" },
                    { 8, "info@motel6.com", "Motel 6", "+666777888" },
                    { 9, "info@fourseasons.com", "Four Seasons Resort", "+999000111" },
                    { 10, "info@bestwestern.com", "Best Western Plus", "+123123123" }
                });

            migrationBuilder.InsertData(
                table: "activities",
                columns: new[] { "ActivityId", "ActivityName" },
                values: new object[,]
                {
                    { 1, "Skiing" },
                    { 2, "Swimming" },
                    { 3, "Skydiving" },
                    { 4, "Hiking" },
                    { 5, "Surfing" },
                    { 6, "Bungee jumping" },
                    { 7, "Rock climbing" },
                    { 8, "Snorkeling" },
                    { 9, "Kayaking" },
                    { 10, "Horseback riding" }
                });

            migrationBuilder.InsertData(
                table: "destination",
                columns: new[] { "DestinationId", "DestinationName" },
                values: new object[,]
                {
                    { 1, "Paris" },
                    { 2, "New York City" },
                    { 3, "Tokyo" },
                    { 4, "Rome" },
                    { 5, "Sydney" },
                    { 6, "Cape Town" },
                    { 7, "Rio de Janeiro" },
                    { 8, "Bali" },
                    { 9, "Barcelona" },
                    { 10, "Dubai" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivitiesTripLogModel_TripsTripId",
                table: "ActivitiesTripLogModel",
                column: "TripsTripId");

            migrationBuilder.CreateIndex(
                name: "IX_tripLogModels_AccommodationEntityAccommodationId",
                table: "tripLogModels",
                column: "AccommodationEntityAccommodationId");

            migrationBuilder.CreateIndex(
                name: "IX_tripLogModels_DestinationEntityDestinationId",
                table: "tripLogModels",
                column: "DestinationEntityDestinationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivitiesTripLogModel");

            migrationBuilder.DropTable(
                name: "activities");

            migrationBuilder.DropTable(
                name: "tripLogModels");

            migrationBuilder.DropTable(
                name: "accomodation");

            migrationBuilder.DropTable(
                name: "destination");
        }
    }
}
