using AutoMapper;
using IndividualProject.Application.Dtos.ParkingSpots;
using IndividualProject.Application.Interfaces;
using IndividualProject.Common.ResultPattern;
using IndividualProject.Infrastructure.Interfaces;

namespace IndividualProject.Application.Services
{
    public class ParkingSpotService : IParkingSpotService
    {
        private readonly IParkingSpotRepository _pakingSpotRepository;
        private readonly IMapper _mapper;

        public ParkingSpotService(IParkingSpotRepository parkingSpot, IMapper mapper)
        {
            _pakingSpotRepository = parkingSpot;
            _mapper = mapper;
        }

        public async Task<ResultT<IEnumerable<ParkingSpotResponseModel>>> GetAsync()
        {
            var result = await _pakingSpotRepository.GetAllAsync();

            var temp = _mapper.Map<IEnumerable<ParkingSpotResponseModel>>(result.ToList());
            return ResultT<ParkingSpotResponseModel>.Success(temp);
        }
    }
}
