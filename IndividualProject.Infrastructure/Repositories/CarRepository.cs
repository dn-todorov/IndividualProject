using IndividualProject.Domain.Entities;
using IndividualProject.Infrastructure.Data;
using IndividualProject.Infrastructure.Interfaces;

namespace IndividualProject.Infrastructure.Repositories
{
    public class CarRepository : GenericRepository<Car>, ICarReopsitory
    {
        public CarRepository(IndividualProjectDbContext context) : base(context)
        { }
    }
}
