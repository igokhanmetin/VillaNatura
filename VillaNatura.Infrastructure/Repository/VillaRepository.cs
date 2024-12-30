using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VillaNatura.Application.Common.Interfaces;
using VillaNatura.Domain.Entities;
using VillaNatura.Infrastructure.Data;

namespace VillaNatura.Infrastructure.Repository
{
    public class VillaRepository :Repository<Villa> , IVillaRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
       
        public void Update(Villa entity)
        {
            _db.Villas.Update(entity);
        }
    }
}
