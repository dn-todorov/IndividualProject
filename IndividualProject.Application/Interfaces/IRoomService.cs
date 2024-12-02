using IndividualProject.Application.Dtos.Rooms;
using IndividualProject.Common.ResultPattern;

namespace IndividualProject.Application.Interfaces
{
    public interface IRoomService
    {
        Task<ResultT<IEnumerable<RoomResponseModel>>> GetAsync();
    }
}
