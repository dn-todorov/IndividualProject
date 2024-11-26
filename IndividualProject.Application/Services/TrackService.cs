using IndividualProject.Application.Interfaces;
using IndividualProject.Common.ResultPattern;
using IndividualProject.Domain.Entities;
using IndividualProject.Infrastructure.Interfaces;

namespace IndividualProject.Application.Services
{
    public class TrackService : ITrackService
    {
        private readonly ITrackRepository _trackrepository;

        public TrackService(ITrackRepository trackRepository)
        {
            _trackrepository = trackRepository;
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

        public async Task<ResultT<Track>> GetByIdAsync(int id, CancellationToken ct)
        {
            //var track = await _trackrepository.GetByIdAsync(id);

            //if (track == null)
            //    return ConfigurationErrors.NotFound(id.ToString());

            //return ResultT<Track>.Success(track);
            throw new NotImplementedException();
        }

        public Task<Result> UpdateAsync(int id, Team request, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
