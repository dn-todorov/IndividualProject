using IndividualProject.Application.Dtos.Tracks;
using IndividualProject.Common.ResultPattern;

namespace IndividualProject.Application.Interfaces
{
    public interface ITrackService
    {
        Task<ResultT<IEnumerable<TracksResponseModel>>> SearchAsync(string querry);

        Task<ResultT<IEnumerable<TracksResponseModel>>> GetAsync(CancellationToken ct);

        Task<ResultT<TracksResponseModel>> GetByIdAsync(int id, CancellationToken ct);

        Task<Result> CreateOrUpdateAsync(int? id, TracksRequestModel model, CancellationToken ct);

        Task<Result> DeleteAsync(int id, CancellationToken ct);
    }
}
