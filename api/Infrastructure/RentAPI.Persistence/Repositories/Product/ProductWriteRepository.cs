using RentAPI.Application.Repositories;
using RentAPI.Domain.Entities;
using RentAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAPI.Persistence.Repositories
{
    public class ProductWriteRepository : WriteRepository<Products>, IProductWriteRepository
    {
        public ProductWriteRepository(RentAPIDbContext context) : base(context)
        {
        }
    }
}
