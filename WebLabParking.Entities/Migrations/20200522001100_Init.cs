using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebLabParking.Entities.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Parkings",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParkingName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parkings", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ClientCars",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Clientid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientCars", x => x.id);
                    table.ForeignKey(
                        name: "FK_ClientCars_Clients_Clientid",
                        column: x => x.Clientid,
                        principalTable: "Clients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ClientCarsid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.id);
                    table.ForeignKey(
                        name: "FK_Cars_ClientCars_ClientCarsid",
                        column: x => x.ClientCarsid,
                        principalTable: "ClientCars",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ParkingTickets",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeavingTime = table.Column<DateTime>(nullable: false),
                    TakingTime = table.Column<DateTime>(nullable: false),
                    Carid = table.Column<int>(nullable: true),
                    Clientid = table.Column<int>(nullable: true),
                    Parkingid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingTickets", x => x.id);
                    table.ForeignKey(
                        name: "FK_ParkingTickets_Cars_Carid",
                        column: x => x.Carid,
                        principalTable: "Cars",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParkingTickets_Clients_Clientid",
                        column: x => x.Clientid,
                        principalTable: "Clients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParkingTickets_Parkings_Parkingid",
                        column: x => x.Parkingid,
                        principalTable: "Parkings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ParkingPlaces",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(nullable: false),
                    Ticketid = table.Column<int>(nullable: true),
                    Parkingid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingPlaces", x => x.id);
                    table.ForeignKey(
                        name: "FK_ParkingPlaces_Parkings_Parkingid",
                        column: x => x.Parkingid,
                        principalTable: "Parkings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParkingPlaces_ParkingTickets_Ticketid",
                        column: x => x.Ticketid,
                        principalTable: "ParkingTickets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ClientCarsid",
                table: "Cars",
                column: "ClientCarsid");

            migrationBuilder.CreateIndex(
                name: "IX_ClientCars_Clientid",
                table: "ClientCars",
                column: "Clientid");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingPlaces_Parkingid",
                table: "ParkingPlaces",
                column: "Parkingid");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingPlaces_Ticketid",
                table: "ParkingPlaces",
                column: "Ticketid");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingTickets_Carid",
                table: "ParkingTickets",
                column: "Carid");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingTickets_Clientid",
                table: "ParkingTickets",
                column: "Clientid");

            migrationBuilder.CreateIndex(
                name: "IX_ParkingTickets_Parkingid",
                table: "ParkingTickets",
                column: "Parkingid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParkingPlaces");

            migrationBuilder.DropTable(
                name: "ParkingTickets");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Parkings");

            migrationBuilder.DropTable(
                name: "ClientCars");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
