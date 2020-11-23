using Domain.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Abstractions.Services
{
    public interface IRX_JobService
    {
        Task<GetAllRXJobsQueryResult> GetAllRXJobsQueryHandler();
    }
}
