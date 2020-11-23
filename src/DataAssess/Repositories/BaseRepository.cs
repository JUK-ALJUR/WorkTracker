using Core.Abstractions.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public abstract class BaseRepository<TIdentifier, TEntity, TRepository> : IBaseRepository<TIdentifier, TEntity, TRepository>
                where TEntity : class
                where TRepository : BaseRepository<TIdentifier, TEntity, TRepository>
    {
        public Task<TEntity> ByIdAsync(TIdentifier id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> CreateBulkAsync(IEnumerable<TEntity> records, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> CreateRecordAsync(TEntity record, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteBulkAsync(IEnumerable<TIdentifier> ids, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteRecordAsync(TIdentifier id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(TIdentifier id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public TRepository NoTrack()
        {
            throw new NotImplementedException();
        }

        public Task<int> PatchRecordAsync(TIdentifier id, string data, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public TRepository Reset()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> SelectFirstOrDefaultAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IEnumerable<TEntity>> ToListAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> ToSingleAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateRecordAsync(TEntity record, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
