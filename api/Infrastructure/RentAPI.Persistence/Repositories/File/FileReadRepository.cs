using RentAPI.Application.Repositories;
using RentAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAPI.Persistence.Repositories
{
    public class FileReadRepository : ReadRepository<RentAPI.Domain.Entities.File>, IFileReadRepository
    {
        public FileReadRepository(RentAPIDbContext context) : base(context)
        {
        }
    }
}
