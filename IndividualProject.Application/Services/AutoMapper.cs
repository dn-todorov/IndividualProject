using AutoMapper;
using IndividualProject.Application.Dtos;
using IndividualProject.Domain.Entities;

namespace IndividualProject.Application.Services
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Track, TrackDTO>();
        }
    }
}
