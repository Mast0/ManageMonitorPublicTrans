using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Coordinates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Latitude = table.Column<double>(type: "double precision", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ScheduleId = table.Column<int>(type: "integer", nullable: false),
                    ScheduleId1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Routes_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Routes_Schedules_ScheduleId1",
                        column: x => x.ScheduleId1,
                        principalTable: "Schedules",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Vechicles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<string>(type: "text", nullable: false),
                    LocationId = table.Column<int>(type: "integer", nullable: false),
                    RouteId = table.Column<int>(type: "integer", nullable: false),
                    CoordinatesId = table.Column<int>(type: "integer", nullable: true),
                    RouteId1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vechicles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vechicles_Coordinates_CoordinatesId",
                        column: x => x.CoordinatesId,
                        principalTable: "Coordinates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vechicles_Coordinates_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Coordinates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vechicles_Routes_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vechicles_Routes_RouteId1",
                        column: x => x.RouteId1,
                        principalTable: "Routes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    VechicleId = table.Column<int>(type: "integer", nullable: false),
                    VechicleId1 = table.Column<int>(type: "integer", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drivers_Vechicles_VechicleId",
                        column: x => x.VechicleId,
                        principalTable: "Vechicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Drivers_Vechicles_VechicleId1",
                        column: x => x.VechicleId1,
                        principalTable: "Vechicles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoutePoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CoordinateId = table.Column<int>(type: "integer", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    VechicleId = table.Column<int>(type: "integer", nullable: false),
                    CoordinatesId = table.Column<int>(type: "integer", nullable: true),
                    VechicleId1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoutePoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoutePoints_Coordinates_CoordinateId",
                        column: x => x.CoordinateId,
                        principalTable: "Coordinates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoutePoints_Coordinates_CoordinatesId",
                        column: x => x.CoordinatesId,
                        principalTable: "Coordinates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RoutePoints_Vechicles_VechicleId",
                        column: x => x.VechicleId,
                        principalTable: "Vechicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoutePoints_Vechicles_VechicleId1",
                        column: x => x.VechicleId1,
                        principalTable: "Vechicles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_VechicleId",
                table: "Drivers",
                column: "VechicleId");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_VechicleId1",
                table: "Drivers",
                column: "VechicleId1");

            migrationBuilder.CreateIndex(
                name: "IX_RoutePoints_CoordinateId",
                table: "RoutePoints",
                column: "CoordinateId");

            migrationBuilder.CreateIndex(
                name: "IX_RoutePoints_CoordinatesId",
                table: "RoutePoints",
                column: "CoordinatesId");

            migrationBuilder.CreateIndex(
                name: "IX_RoutePoints_VechicleId",
                table: "RoutePoints",
                column: "VechicleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoutePoints_VechicleId1",
                table: "RoutePoints",
                column: "VechicleId1");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_ScheduleId",
                table: "Routes",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_ScheduleId1",
                table: "Routes",
                column: "ScheduleId1");

            migrationBuilder.CreateIndex(
                name: "IX_Vechicles_CoordinatesId",
                table: "Vechicles",
                column: "CoordinatesId");

            migrationBuilder.CreateIndex(
                name: "IX_Vechicles_LocationId",
                table: "Vechicles",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Vechicles_RouteId",
                table: "Vechicles",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Vechicles_RouteId1",
                table: "Vechicles",
                column: "RouteId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "RoutePoints");

            migrationBuilder.DropTable(
                name: "Vechicles");

            migrationBuilder.DropTable(
                name: "Coordinates");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Schedules");
        }
    }
}
