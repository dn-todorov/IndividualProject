using IndividualProject.Domain.Entities;
using IndividualProject.Infrastructure.Data;
using IndividualProject.Infrastructure.Interfaces;

namespace IndividualProject.Infrastructure.Repositories
{
    public class TeamRepository : GenericRepository<Team>, ITeamRepository
    {
        public TeamRepository(IndividualProjectDbContext context) : base(context) { }
    }
}
