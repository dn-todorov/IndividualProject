using IndividualProject.Application.Dtos.ParkingSpots;
using IndividualProject.Common.ResultPattern;

namespace IndividualProject.Application.Interfaces
{
    public interface IParkingSpotService
    {
        Task<ResultT<IEnumerable<ParkingSpotResponseModel>>> GetAsync();
    }
}
