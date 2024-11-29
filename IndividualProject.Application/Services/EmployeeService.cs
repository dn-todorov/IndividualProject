﻿using AutoMapper;
using IndividualProject.Application.Dtos.Employees;
using IndividualProject.Application.Interfaces;
using IndividualProject.Common.ResultPattern;
using IndividualProject.Domain.Entities;
using IndividualProject.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace IndividualProject.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
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

        public async Task<ResultT<IEnumerable<EmployeeResponseModel>>> SearchAsync(string querry)
        {
            var querryParts = querry.Split(' ');
            string firstName = querryParts[0];
            string lastName = querryParts.Length > 1 ? querryParts[1] : string.Empty;

            var result = await _employeeRepository
                .GetAllAsync(x => x.Include(x => x.Team));

            var mappedToList = _mapper.Map<IEnumerable<EmployeeResponseModel>>(result.ToList());

            var querryed = mappedToList
                .Where(x => x.FirstName.Contains(firstName, StringComparison.OrdinalIgnoreCase)
                && x.LastName.Contains(lastName, StringComparison.OrdinalIgnoreCase));
            return ResultT<EmployeeResponseModel>.Success(querryed);
        }

        public async Task<ResultT<IEnumerable<EmployeeWithCarResponseModel>>> GetAsync(CancellationToken ct)
        {
            var result = await _employeeRepository.GetAllAsync(x => x.Include(x => x.Car));

            var temp = _mapper.Map<IEnumerable<EmployeeWithCarResponseModel>>(result.ToList());
            return ResultT<EmployeeWithCarResponseModel>.Success(temp);
        }

        public async Task<ResultT<EmployeeWithCarResponseModel>> GetByIdAsync(int id, CancellationToken ct)
        {
            var result = await _employeeRepository
                .GetAsync(id
                , x => x.Include(x => x.Car));

            var temp = _mapper.Map<EmployeeWithCarResponseModel>(result);
            return ResultT<EmployeeWithCarResponseModel>.Success(temp);
        }

        public Task<Result> UpdateAsync(int id, Team request, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
