using IndividualProject.Application.Interfaces;
using IndividualProject.Common.ResultPattern;
using IndividualProject.Domain.Entities;
using IndividualProject.Errors;
using IndividualProject.Infrastructure.Interfaces;


namespace IndividualProject.Application.Services
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _teamRepository;

        public TeamService(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }

        public Task<ResultT<Team>> AddAsync(Team request, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<Result> DeleteAsync(int id, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<ResultT<IEnumerable<Team>>> GetAsync(CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultT<Team>> GetByIdAsync(int id, CancellationToken ct)
        {
            var team = await _teamRepository.GetByIdAsync(id);

            if (team == null)
                return ConfigurationErrors.NotFound(id.ToString());

            return ResultT<Team>.Success(team);
        }

        public Task<Result> UpdateAsync(int id, Team request, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
