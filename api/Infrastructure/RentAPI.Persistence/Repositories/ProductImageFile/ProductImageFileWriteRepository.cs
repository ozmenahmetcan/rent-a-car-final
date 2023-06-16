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
    public class ProductImageFileWriteRepository : WriteRepository<ProductImageFile>, IProductImageFileWriteRepository
    {
        public ProductImageFileWriteRepository(RentAPIDbContext context) : base(context)
        {
        }
    }
}
