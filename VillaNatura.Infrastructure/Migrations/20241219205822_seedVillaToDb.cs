using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VillaNatura.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedVillaToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Created_Date", "Description", "ImageUrl", "Name", "Occupancy", "Price", "Sqft", "Updated_Date" },
                values: new object[,]
                {
                    { 1, null, "Doğa içinde eşsiz bir tatil imkanı sunan Villa Taş Konak’ın içerisinde 8 kişi konaklama kapasiteli,4 yatak odası yer almaktadır. Villamızın 3. Yatak odası ek binada bulunmaktadır.", "https://placehold.co/600x400", "Taş Villa", 4, 5000.0, 550, null },
                    { 2, null, "Dayalı döşeli villamızda tüm ev dekorasyon eşyaları ve beyaz eşyalar mevcuttur. Havuz terasımızda 13 x 4 metre ebatlarında özel havuz, 5 x 3 metre ebatlarında jakuzi özellikli kapalı havuz ve 3.5 x 3 metre ebatlarında ise, sığ havuz/çocuk yüzme havuzu bulunmaktadır. ", "https://placehold.co/600x401", "Havuzlu Villa", 4, 7000.0, 550, null },
                    { 3, null, " Bahçe içerisinde en 4 m; boy sığ havuz dahil 11.5 m; ve derinlik 1.40 m ölçülerinde korunaklı özel yüzme havuzu bulunmaktadır. Havuz ve bahçe bakımı günde 1 kez sabah veya akşam yapılmaktadır.", "https://placehold.co/600x402", "Lüx Havuzlu Villa", 4, 10000.0, 750, null }
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

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
