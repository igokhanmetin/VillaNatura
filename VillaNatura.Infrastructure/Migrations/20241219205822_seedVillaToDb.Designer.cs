﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VillaNatura.Infrastructure.Data;

#nullable disable

namespace VillaNatura.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241219205822_seedVillaToDb")]
    partial class seedVillaToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VillaNatura.Domain.Entities.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Created_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Updated_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Doğa içinde eşsiz bir tatil imkanı sunan Villa Taş Konak’ın içerisinde 8 kişi konaklama kapasiteli,4 yatak odası yer almaktadır. Villamızın 3. Yatak odası ek binada bulunmaktadır.",
                            ImageUrl = "https://placehold.co/600x400",
                            Name = "Taş Villa",
                            Occupancy = 4,
                            Price = 5000.0,
                            Sqft = 550
                        },
                        new
                        {
                            Id = 2,
                            Description = "Dayalı döşeli villamızda tüm ev dekorasyon eşyaları ve beyaz eşyalar mevcuttur. Havuz terasımızda 13 x 4 metre ebatlarında özel havuz, 5 x 3 metre ebatlarında jakuzi özellikli kapalı havuz ve 3.5 x 3 metre ebatlarında ise, sığ havuz/çocuk yüzme havuzu bulunmaktadır. ",
                            ImageUrl = "https://placehold.co/600x401",
                            Name = "Havuzlu Villa",
                            Occupancy = 4,
                            Price = 7000.0,
                            Sqft = 550
                        },
                        new
                        {
                            Id = 3,
                            Description = " Bahçe içerisinde en 4 m; boy sığ havuz dahil 11.5 m; ve derinlik 1.40 m ölçülerinde korunaklı özel yüzme havuzu bulunmaktadır. Havuz ve bahçe bakımı günde 1 kez sabah veya akşam yapılmaktadır.",
                            ImageUrl = "https://placehold.co/600x402",
                            Name = "Lüx Havuzlu Villa",
                            Occupancy = 4,
                            Price = 10000.0,
                            Sqft = 750
                        });
                });
#pragma warning restore 612, 618
        }
    }
}