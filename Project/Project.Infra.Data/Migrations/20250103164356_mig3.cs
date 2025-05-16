using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 1L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 2L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 3L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 4L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 5L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 6L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 7L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 8L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 9L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 10L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 11L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 12L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 13L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 14L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 15L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 16L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 17L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 18L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 19L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 20L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 21L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 22L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 23L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 24L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 25L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 26L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 27L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 28L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 29L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 30L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Provinces",
                keyColumn: "Id",
                keyValue: 31L,
                column: "InsertTime",
                value: new DateTime(2025, 1, 3, 20, 13, 49, 854, DateTimeKind.Local).AddTicks(3045));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
