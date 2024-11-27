using AutoMapper;
using IndividualProject.Application.Dtos.Tracks;
using IndividualProject.Application.Errors;
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

        //TODO
        //Add queery checking
        public async Task<ResultT<IEnumerable<TracksResponseModel>>> SearchAsync(string querry)
        {
            var result = await _trackrepository
                .GetAllAsync(x => x.Include(x => x.Employee)
                .ThenInclude(x => x.Team)
                .Include(x => x.OfficeRoom)
                .Include(x => x.ParkingSpot));

            var mappedToList = _mapper.Map<IEnumerable<TracksResponseModel>>(result.ToList());

            var querryed = mappedToList
                .Where(x => x.Employee.FirstName.Contains(querry, StringComparison.OrdinalIgnoreCase)
                || x.Employee.LastName.Contains(querry, StringComparison.OrdinalIgnoreCase)
                || x.Employee.Team.TeamName.Contains(querry, StringComparison.OrdinalIgnoreCase));
            return ResultT<TracksResponseModel>.Success(querryed);
        }

        public async Task<ResultT<IEnumerable<TracksResponseModel>>> GetAsync(CancellationToken ct)
        {
            var result = await _trackrepository
                .GetAllAsync(x => x.Include(x => x.Employee)
                .ThenInclude(x => x.Team)
                .Include(x => x.OfficeRoom)
                .Include(x => x.ParkingSpot));

            var temp = _mapper.Map<IEnumerable<TracksResponseModel>>(result.ToList());
            return ResultT<TracksResponseModel>.Success(temp);
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

        //Fix The Request Model Adds all data again
        public async Task<Result> CreateOrUpdateAsync(int? id, TracksRequestModel model, CancellationToken ct)
        {
            Track entity = null;

            if (id != null)
            {
                entity = await _trackrepository
                    .FindAsync(x => x.Id == id);
                model.Id = (int)entity.Id;
            }

            entity = _mapper.Map<Track>(model);

            if (entity?.Id != null && id != null)
            {
                _trackrepository.Update(entity);
            }
            else
            {
                await _trackrepository.AddAsync(entity);
            }

            await _trackrepository.SaveAsync();
            return Result.Success();
        }

        public async Task<Result> DeleteAsync(int id, CancellationToken ct)
        {
            if (id == null)
            {
                return TrackingErrors.NotFound(id.ToString());
            }

            var result = await _trackrepository.FindAsync(x => x.Id == id);

            if (result != null)
            {
                await _trackrepository.DeleteAsync(result);
                await _trackrepository.SaveAsync();
            }
            else
            {
                return TrackingErrors.NotFound(id.ToString());
            }

            return Result.Success();
        }
    }
}
