using Microsoft.EntityFrameworkCore;
using SynthManiaAPI.Models;

namespace SynthManiaAPI.Data;

public static class ModelBuilderExtensions
{

    public static ModelBuilder Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "SynthMaster Pro",
                Description = "Professional-grade analog synthesizer with versatile sound shaping",
                Price = 999.99m,
                ImageName = "ImageMissing.jpeg"
            },
            new Product
            {
                Id = 2,
                Name = "Modular Madness",
                Description = "A modular analog synthesizer for experimental sound design",
                Price = 1499.99m,
                ImageName = "ImageMissing.jpeg"
            },
            new Product
            {
                Id = 3,
                Name = "Vintage Vibe 3000",
                Description = "Recreates the classic analog sounds of the 70s and 80s",
                Price = 799.99m,
                ImageName = "ImageMissing.jpeg"
            },
            new Product
            {
                Id = 4,
                Name = "Analog Dreamer Pro",
                Description = "Dreamy analog synth with a wide range of atmospheric tones",
                Price = 1299.99m,
                ImageName = "ImageMissing.jpeg"
            },
            new Product
            {
                Id = 5,
                Name = "Digital Fusion 5000",
                Description = "Blends analog warmth with digital precision for a unique sonic experience",
                Price = 1699.99m,
                ImageName = "ImageMissing.jpeg"
            },
            new Product
            {
                Id = 6,
                Name = "Neo Wave Explorer",
                Description = "Cutting-edge analog synthesizer with innovative wave exploration features",
                Price = 1499.99m,
                ImageName = "ImageMissing.jpeg"
            },
            new Product
            {
                Id = 7,
                Name = "Retro Synth Wizard",
                Description = "Takes you back in time with its authentic retro analog sounds",
                Price = 1099.99m,
                ImageName = "ImageMissing.jpeg"
            },
            new Product
            {
                Id = 8,
                Name = "Polyphonic Powerhouse",
                Description = "Powerful analog polyphonic synthesizer for lush and layered compositions",
                Price = 1999.99m,
                ImageName = "ImageMissing.jpeg"
            },
            new Product
            {
                Id = 9,
                Name = "Dark Ambient Drifter",
                Description = "Crafts eerie and haunting analog textures for ambient music",
                Price = 1399.99m,
                ImageName = "ImageMissing.jpeg"
            },
            new Product
            {
                Id = 10,
                Name = "Funky Filter Freak",
                Description = "Analog synthesizer with funky filter effects for groovy soundscapes",
                Price = 1199.99m,
                ImageName = "ImageMissing.jpeg"
            });
        return modelBuilder;    
    }
}