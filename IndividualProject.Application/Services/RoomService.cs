using AutoMapper;
using IndividualProject.Application.Dtos.Rooms;
using IndividualProject.Application.Interfaces;
using IndividualProject.Common.ResultPattern;
using IndividualProject.Infrastructure.Interfaces;

namespace IndividualProject.Application.Services
{
    public class RoomService : IRoomService
    {
        private readonly IOfficeRoomRepository _roomRepository;
        private readonly IMapper _mapper;

        public RoomService(IOfficeRoomRepository officeRoomRepository, IMapper mapper)
        {
            _roomRepository = officeRoomRepository;
            _mapper = mapper;
        }

        public async Task<ResultT<IEnumerable<RoomResponseModel>>> GetAsync()
        {
            var result = await _roomRepository.GetAllAsync();

            var temp = _mapper.Map<IEnumerable<RoomResponseModel>>(result.ToList());
            return ResultT<RoomResponseModel>.Success(temp);
        }
    }
}
