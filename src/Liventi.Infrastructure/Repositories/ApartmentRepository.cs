using Liventi.Domain.Apartments;

namespace Liventi.Infrastructure.Repositories;

internal sealed class ApartmentRepository : Repository<Apartment>, IApartmentRepository
{
    public ApartmentRepository(ApplicationDbContext dbContext)
        : base(dbContext)
    {
    }
}