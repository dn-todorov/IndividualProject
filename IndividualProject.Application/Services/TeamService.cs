using AutoMapper;
using IndividualProject.Application.Dtos.Teams;
using IndividualProject.Application.Interfaces;
using IndividualProject.Common.ResultPattern;
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

        public async Task<ResultT<IEnumerable<TeamResponseModel>>> GetAsync()
        {
            var teams = await _teamRepository.GetAllAsync();
            var temp = _mapper.Map<IEnumerable<TeamResponseModel>>(teams.ToList());

            return ResultT<TeamResponseModel>.Success(temp);
        }

        public async Task<ResultT<TeamResponseModel>> GetByIdAsync(int id)
        {
            var team = await _teamRepository.GetAsync(id);

            if (team == null)
                return TeamErrors.NotFound(id.ToString());

            var temp = _mapper.Map<TeamResponseModel>(team);

            return ResultT<TeamResponseModel>.Success(temp);
        }
    }
}
