using IndividualProject.Common.ResultPattern;
using IndividualProject.Domain.Entities;

namespace IndividualProject.Application.Interfaces
{
    public interface ITrackService
    {
        Task<ResultT<IEnumerable<Track>>> GetAsync(CancellationToken ct);

        Task<ResultT<Track>> GetByIdAsync(int id, CancellationToken ct);

        Task<ResultT<Team>> AddAsync(Team request, CancellationToken ct);

        Task<Result> UpdateAsync(int id, Team request, CancellationToken ct);

        Task<Result> DeleteAsync(int id, CancellationToken ct);
    }
}
