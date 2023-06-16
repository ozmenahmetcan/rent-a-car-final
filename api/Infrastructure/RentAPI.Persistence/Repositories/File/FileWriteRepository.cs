using RentAPI.Application.Repositories;
using RentAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentAPI.Persistence.Repositories
{
    public class FileWriteRepository : WriteRepository<RentAPI.Domain.Entities.File>, IFileWriteRepository
    {
        public FileWriteRepository(RentAPIDbContext context) : base(context)
        {
        }
    }
}
