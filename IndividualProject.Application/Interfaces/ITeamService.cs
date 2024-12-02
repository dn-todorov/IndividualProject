using IndividualProject.Application.Dtos.Teams;
using IndividualProject.Common.ResultPattern;

namespace IndividualProject.Application.Interfaces
{
    public interface ITeamService
    {
        Task<ResultT<IEnumerable<TeamResponseModel>>> GetAsync();

        Task<ResultT<TeamResponseModel>> GetByIdAsync(int id);
    }
}
