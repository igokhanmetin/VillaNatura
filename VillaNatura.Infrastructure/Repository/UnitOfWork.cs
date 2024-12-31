using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillaNatura.Application.Common.Interfaces;
using VillaNatura.Infrastructure.Data;

namespace VillaNatura.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IVillaRepository Villa {  get; private set; }
        public IVillaNumberRepository VillaNumber {  get; private set; }
        public IApplicationUserRepository ApplicationUser {  get; private set; }
        public IBookingRepository Booking {  get; private set; }
        public IAmenityRepository Amenity {  get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Villa =new VillaRepository(_db);
            Booking =new BookingRepository(_db);
            VillaNumber =new VillaNumberRepository(_db);
            ApplicationUser =new ApplicationUserRepository(_db);
            Amenity =new AmenityRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
