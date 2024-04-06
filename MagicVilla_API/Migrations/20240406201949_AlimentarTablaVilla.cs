using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la villa", new DateTime(2024, 4, 6, 17, 19, 49, 42, DateTimeKind.Local).AddTicks(2247), new DateTime(2024, 4, 6, 17, 19, 49, 42, DateTimeKind.Local).AddTicks(2234), "", 50, "Villa Real", 5, 200.0 },
                    { 2, "", "Detalle de la villa premium", new DateTime(2024, 4, 6, 17, 19, 49, 42, DateTimeKind.Local).AddTicks(2250), new DateTime(2024, 4, 6, 17, 19, 49, 42, DateTimeKind.Local).AddTicks(2250), "", 70, "Premium Villa", 7, 400.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
