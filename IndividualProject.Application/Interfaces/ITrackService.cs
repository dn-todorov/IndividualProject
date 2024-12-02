using IndividualProject.Application.Dtos.Tracks;
using IndividualProject.Common.ResultPattern;

namespace IndividualProject.Application.Interfaces
{
    public interface ITrackService
    {
        Task<ResultT<IEnumerable<TracksResponseModel>>> SearchAsync(string querry);

        Task<ResultT<IEnumerable<TracksResponseModel>>> GetAsync();

        Task<ResultT<TracksResponseModel>> GetByIdAsync(int id);

        Task<Result> CreateOrUpdateAsync(int? id, TracksRequestModel model);

        Task<Result> DeleteAsync(int id);
    }
}
