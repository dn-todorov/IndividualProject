using IndividualProject.Domain.Entities;
using IndividualProject.Infrastructure.Data;
using IndividualProject.Infrastructure.Interfaces;

namespace IndividualProject.Infrastructure.Repositories
{
    public class TrackRepository : GenericRepository<Track>, ITrackRepository
    {
        public TrackRepository(IndividualProjectDbContext context) : base(context) { }
    }
}
