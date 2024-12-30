using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillaNatura.Domain.Entities;

namespace VillaNatura.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Villa>().HasData(
                  new Villa
                  {
                      Id = 1,
                      Name = "Taş Villa",
                      Description = "Doğa içinde eşsiz bir tatil imkanı sunan Villa Taş Konak’ın içerisinde 8 kişi konaklama kapasiteli,4 yatak odası yer almaktadır. Villamızın 3. Yatak odası ek binada bulunmaktadır.",
                      ImageUrl = "https://placehold.co/600x400",
                      Occupancy = 4,
                      Price = 5000,
                      Sqft = 550,
                  },
                  new Villa
                  {
                      Id = 2,
                      Name = "Havuzlu Villa",
                      Description = "Dayalı döşeli villamızda tüm ev dekorasyon eşyaları ve beyaz eşyalar mevcuttur. Havuz terasımızda 13 x 4 metre ebatlarında özel havuz, 5 x 3 metre ebatlarında jakuzi özellikli kapalı havuz ve 3.5 x 3 metre ebatlarında ise, sığ havuz/çocuk yüzme havuzu bulunmaktadır. ",
                      ImageUrl = "https://placehold.co/600x401",
                      Occupancy = 4,
                      Price = 7000,
                      Sqft = 550,
                  },
                  new Villa
                  {
                      Id = 3,
                      Name = "Lüx Havuzlu Villa",
                      Description = " Bahçe içerisinde en 4 m; boy sığ havuz dahil 11.5 m; ve derinlik 1.40 m ölçülerinde korunaklı özel yüzme havuzu bulunmaktadır. Havuz ve bahçe bakımı günde 1 kez sabah veya akşam yapılmaktadır.",
                      ImageUrl = "https://placehold.co/600x402",
                      Occupancy = 4,
                      Price = 10000,
                      Sqft = 750,
                  });
            modelBuilder.Entity<VillaNumber>().HasData(
                new VillaNumber
                {
                    Villa_Number = 101,
                    VillaId = 1,
                },
                new VillaNumber
                {
                    Villa_Number = 102,
                    VillaId = 1,
                },
                new VillaNumber
                {
                    Villa_Number = 103,
                    VillaId = 1,
                },
                new VillaNumber
                {
                    Villa_Number = 104,
                    VillaId = 1,
                },
                new VillaNumber
                {
                    Villa_Number = 201,
                    VillaId = 2,
                },
                new VillaNumber
                {
                    Villa_Number = 202,
                    VillaId = 2,
                }, 
                new VillaNumber
                {
                    Villa_Number = 203,
                    VillaId = 2,
                }, 
                
                new VillaNumber
                {
                    Villa_Number = 301,
                    VillaId = 3,
                }, 
                new VillaNumber
                {
                    Villa_Number = 302,
                    VillaId = 3,
                }
                );
            modelBuilder.Entity<Amenity>().HasData(
          new Amenity
          {
              Id = 1,
              VillaId = 1,
              Name = "Özel Havuz"
          }, new Amenity
          {
              Id = 2,
              VillaId = 1,
              Name = "Fırın"
          }, new Amenity
          {
              Id = 3,
              VillaId = 1,
              Name = "Özel Balkon"
          }, new Amenity
          {
              Id = 4,
              VillaId = 1,
              Name = "1 Büyük Yatak ve 1 Kanepe Yatak"
          },

          new Amenity
          {
              Id = 5,
              VillaId = 2,
              Name = "Villa İçi Küçük Havuz"
          }, new Amenity
          {
              Id = 6,
              VillaId = 2,
              Name = "Fırın ve Derin Dondurucu"
          }, new Amenity
          {
              Id = 7,
              VillaId = 2,
              Name = "Özel Balkon"
          }, new Amenity
          {
              Id = 8,
              VillaId = 2,
              Name = "Büyük Yatak veya İki Kişilik Yatak"
          },

          new Amenity
          {
              Id = 9,
              VillaId = 3,
              Name = "Özel Havuz"
          }, new Amenity
          {
              Id = 10,
              VillaId = 3,
              Name = "Jakuzi"
          }, new Amenity
          {
              Id = 11,
              VillaId = 3,
              Name = "Özel Balkon"
          });

        }
    }
}
