using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoCatEmbalses.Migrations
{
    /// <inheritdoc />
    public partial class Embalses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Embalses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estacio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NivellAbsolut = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PercentatgeVolumEmbassat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VolumEmbassat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Embalses", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Embalses");
        }
    }
}
