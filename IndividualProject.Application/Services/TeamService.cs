using AutoMapper;
using IndividualProject.Application.Dtos.Teams;
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
        private readonly IMapper _mapper;

        public TeamService(ITeamRepository teamRepository, IMapper mapper)
        {
            _teamRepository = teamRepository;
            _mapper = mapper;
        }

        public Task<ResultT<Team>> AddAsync(Team request, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public Task<Result> DeleteAsync(int id, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultT<IEnumerable<TeamResponseModel>>> GetAsync(CancellationToken ct)
        {
            //var teams = await _teamRepository.GetAllAsync();
            //var temp = _mapper.Map<TeamResponseModel>(teams);

            //return ResultT<TeamResponseModel>.Success(temp);
            throw new NotImplementedException();
        }

        public async Task<ResultT<TeamResponseModel>> GetByIdAsync(int id, CancellationToken ct)
        {
            var team = await _teamRepository.GetAsync(id);

            if (team == null)
                return ConfigurationErrors.NotFound(id.ToString());

            var temp = _mapper.Map<TeamResponseModel>(team);

            return ResultT<TeamResponseModel>.Success(temp);
        }

        public Task<Result> UpdateAsync(int id, Team request, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
