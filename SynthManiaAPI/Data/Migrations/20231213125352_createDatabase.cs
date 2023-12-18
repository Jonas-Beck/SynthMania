using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SynthManiaAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class createDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageFileName", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Professional-grade analog synthesizer with versatile sound shaping", "ImageMissing.jpeg", "SynthMaster Pro", 999.99m },
                    { 2, "A modular analog synthesizer for experimental sound design", "ImageMissing.jpeg", "Modular Madness", 1499.99m },
                    { 3, "Recreates the classic analog sounds of the 70s and 80s", "ImageMissing.jpeg", "Vintage Vibe 3000", 799.99m },
                    { 4, "Dreamy analog synth with a wide range of atmospheric tones", "ImageMissing.jpeg", "Analog Dreamer Pro", 1299.99m },
                    { 5, "Blends analog warmth with digital precision for a unique sonic experience", "ImageMissing.jpeg", "Digital Fusion 5000", 1699.99m },
                    { 6, "Cutting-edge analog synthesizer with innovative wave exploration features", "ImageMissing.jpeg", "Neo Wave Explorer", 1499.99m },
                    { 7, "Takes you back in time with its authentic retro analog sounds", "ImageMissing.jpeg", "Retro Synth Wizard", 1099.99m },
                    { 8, "Powerful analog polyphonic synthesizer for lush and layered compositions", "ImageMissing.jpeg", "Polyphonic Powerhouse", 1999.99m },
                    { 9, "Crafts eerie and haunting analog textures for ambient music", "ImageMissing.jpeg", "Dark Ambient Drifter", 1399.99m },
                    { 10, "Analog synthesizer with funky filter effects for groovy soundscapes", "ImageMissing.jpeg", "Funky Filter Freak", 1199.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
