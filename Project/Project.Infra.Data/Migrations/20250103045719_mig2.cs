using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AppointmentDate",
                table: "Appointments",
                newName: "AppointmentDateStart");

            migrationBuilder.AddColumn<string>(
                name: "AdminId",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "AppointmentDateEnd",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 6L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 7L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 8L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 9L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 10L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 11L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 12L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 13L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 14L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 15L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 16L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 17L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 18L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 19L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 20L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 21L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 22L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 23L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 24L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 25L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 26L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 27L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 28L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 29L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 30L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 31L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 8, 27, 15, 160, DateTimeKind.Local).AddTicks(7233));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "AppointmentDateEnd",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "AppointmentDateStart",
                table: "Appointments",
                newName: "AppointmentDate");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 6L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 7L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 8L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 9L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 10L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 11L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 12L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 13L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 14L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 15L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 16L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 17L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 18L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 19L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 20L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 21L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 22L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 23L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 24L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 25L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 26L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 27L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 28L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 29L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 30L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 31L,
                column: "InsertTime",
                value: new DateTime(2024, 12, 29, 11, 40, 2, 832, DateTimeKind.Local).AddTicks(8606));
        }
    }
}
