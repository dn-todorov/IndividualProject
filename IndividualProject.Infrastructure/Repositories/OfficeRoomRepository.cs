using IndividualProject.Domain.Entities;
using IndividualProject.Infrastructure.Data;
using IndividualProject.Infrastructure.Interfaces;

namespace IndividualProject.Infrastructure.Repositories
{
    public class OfficeRoomRepository : GenericRepository<OfficeRoom>, IOfficeRoomRepository
    {
        public OfficeRoomRepository(IndividualProjectDbContext context) : base(context) { }
    }
}
