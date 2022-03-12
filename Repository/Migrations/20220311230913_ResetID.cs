using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class ResetID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelFacilities_Facilities_FacilityId1",
                table: "HotelFacilities");

            migrationBuilder.DropIndex(
                name: "IX_HotelFacilities_FacilityId1",
                table: "HotelFacilities");

            migrationBuilder.DropColumn(
                name: "FacilityId1",
                table: "HotelFacilities");

            migrationBuilder.AlterColumn<Guid>(
                name: "FacilityId",
                table: "HotelFacilities",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_HotelFacilities_FacilityId",
                table: "HotelFacilities",
                column: "FacilityId");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelFacilities_Facilities_FacilityId",
                table: "HotelFacilities",
                column: "FacilityId",
                principalTable: "Facilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelFacilities_Facilities_FacilityId",
                table: "HotelFacilities");

            migrationBuilder.DropIndex(
                name: "IX_HotelFacilities_FacilityId",
                table: "HotelFacilities");

            migrationBuilder.AlterColumn<int>(
                name: "FacilityId",
                table: "HotelFacilities",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "FacilityId1",
                table: "HotelFacilities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_HotelFacilities_FacilityId1",
                table: "HotelFacilities",
                column: "FacilityId1");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelFacilities_Facilities_FacilityId1",
                table: "HotelFacilities",
                column: "FacilityId1",
                principalTable: "Facilities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
