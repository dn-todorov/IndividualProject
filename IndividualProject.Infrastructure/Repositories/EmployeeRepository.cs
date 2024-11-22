using IndividualProject.Domain.Entities;
using IndividualProject.Infrastructure.Data;
using IndividualProject.Infrastructure.Interfaces;

namespace IndividualProject.Infrastructure.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IndividualProjectDbContext context) : base(context)
        { }
    }
}
