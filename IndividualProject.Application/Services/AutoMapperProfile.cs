using AutoMapper;
using IndividualProject.Application.Dtos.Cars;
using IndividualProject.Application.Dtos.Employees;
using IndividualProject.Application.Dtos.ParkingSpots;
using IndividualProject.Application.Dtos.Rooms;
using IndividualProject.Application.Dtos.Teams;
using IndividualProject.Application.Dtos.Tracks;
using IndividualProject.Domain.Entities;

namespace IndividualProject.Application.Services
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Team, TeamResponseModel>().ForMember(x => x.Id, x => x.MapFrom(x => x.Id)).ReverseMap();

            CreateMap<Car, CarResponseModel>().ForMember(x => x.Id, x => x.MapFrom(x => x.Id)).ReverseMap();

            CreateMap<ParkingSpot, ParkingSpotResponseModel>().ReverseMap();

            CreateMap<OfficeRoom, RoomResponseModel>().ReverseMap();

            CreateMap<Employee, EmployeeWithCarResponseModel>()
                .ForPath(x => x.Car, x => x.MapFrom(x => x.Car))
                .ReverseMap();

            CreateMap<Employee, EmployeeResponseModel>()
                .ForPath(x => x.Team, x => x.MapFrom(x => x.Team))
                .ReverseMap();

            CreateMap<Track, TracksResponseModel>()
                .ForPath(x => x.Employee, x => x.MapFrom(x => x.Employee))
                .ForPath(x => x.ParkingSpot, x => x.MapFrom(x => x.ParkingSpot))
                .ForPath(x => x.Room, x => x.MapFrom(x => x.OfficeRoom))
                .ReverseMap();

            CreateMap<TracksRequestModel, Track>().ReverseMap();
        }
    }
}
