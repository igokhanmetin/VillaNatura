using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VillaNatura.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAmenityToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Amenities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VillaId = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Amenities_Villas_VillaId",
                        column: x => x.VillaId,
                        principalTable: "Villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "Id", "Description", "Name", "SpecialDetails", "VillaId" },
                values: new object[,]
                {
                    { 1, null, "Özel Havuz", null, 1 },
                    { 2, null, "Fırın", null, 1 },
                    { 3, null, "Özel Balkon", null, 1 },
                    { 4, null, "1 Büyük Yatak ve 1 Kanepe Yatak", null, 1 },
                    { 5, null, "Villa İçi Küçük Havuz", null, 2 },
                    { 6, null, "Fırın ve Derin Dondurucu", null, 2 },
                    { 7, null, "Özel Balkon", null, 2 },
                    { 8, null, "Büyük Yatak veya İki Kişilik Yatak", null, 2 },
                    { 9, null, "Özel Havuz", null, 3 },
                    { 10, null, "Jakuzi", null, 3 },
                    { 11, null, "Özel Balkon", null, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Amenities_VillaId",
                table: "Amenities",
                column: "VillaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amenities");
        }
    }
}
