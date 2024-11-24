﻿using IndividualProject.Common.ResultPattern;
using IndividualProject.Domain.Entities;

namespace IndividualProject.Application.Interfaces
{
    public interface ITeamService
    {
        Task<ResultT<IEnumerable<Team>>> GetAsync(CancellationToken ct);

        Task<ResultT<Team>> GetByIdAsync(int id, CancellationToken ct);

        Task<ResultT<Team>> AddAsync(Team request, CancellationToken ct);

        Task<Result> UpdateAsync(int id, Team request, CancellationToken ct);

        Task<Result> DeleteAsync(int id, CancellationToken ct);
    }
}
