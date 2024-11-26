using AutoMapper;
using IndividualProject.Application.Dtos.Tracks;
using IndividualProject.Application.Interfaces;
using IndividualProject.Common.ResultPattern;
using IndividualProject.Domain.Entities;
using IndividualProject.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IndividualProject.Application.Services
{
    public class TrackService : ITrackService
    {
        private readonly ITrackRepository _trackrepository;
        private readonly IMapper _mapper;

        public TrackService(ITrackRepository trackRepository, IMapper mapper)
        {
            _trackrepository = trackRepository;
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

        public async Task<ResultT<IEnumerable<Track>>> GetAsync(CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultT<TracksResponseModel>> GetByIdAsync(int id, CancellationToken ct)
        {
            var result = await _trackrepository
                .GetAsync(id
                , x => x.Include(x => x.Employee)
                .ThenInclude(x => x.Team)
                .Include(x => x.OfficeRoom)
                .Include(x => x.ParkingSpot));
            var temp = _mapper.Map<TracksResponseModel>(result);
            return ResultT<TracksResponseModel>.Success(temp);
        }

        public Task<Result> UpdateAsync(int id, Team request, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
