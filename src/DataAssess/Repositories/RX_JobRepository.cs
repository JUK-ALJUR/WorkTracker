using Core.Abstractions.Repositories;
using Domain.DataModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class RX_JobRepository : BaseRepository<Guid, RX_Job, RX_JobRepository>, IRX_JobRepository
    {
        public Task<RX_Job> ByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteBulkAsync(IEnumerable<int> ids, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteRecordAsync(int id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(int id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> PatchRecordAsync(int id, string data, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        IRX_JobRepository IBaseRepository<int, RX_Job, IRX_JobRepository>.NoTrack()
        {
            throw new NotImplementedException();
        }

        IRX_JobRepository IBaseRepository<int, RX_Job, IRX_JobRepository>.Reset()
        {
            throw new NotImplementedException();
        }
    }
}
