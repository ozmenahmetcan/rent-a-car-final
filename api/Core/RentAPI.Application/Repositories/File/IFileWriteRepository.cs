using F = RentAPI.Domain.Entities;

namespace RentAPI.Application.Repositories
{
    public interface IFileWriteRepository : IWriteRepository<F::File>
    {
    }
}
