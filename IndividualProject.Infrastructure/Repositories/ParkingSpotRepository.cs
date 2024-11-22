using IndividualProject.Domain.Entities;
using IndividualProject.Infrastructure.Data;
using IndividualProject.Infrastructure.Interfaces;

namespace IndividualProject.Infrastructure.Repositories
{
    public class ParkingSpotRepository : GenericRepository<ParkingSpot>, IParkingSpotRepository
    {
        public ParkingSpotRepository(IndividualProjectDbContext context) : base(context) { }
    }
}
