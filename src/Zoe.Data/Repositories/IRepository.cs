using System;
using System.Threading.Tasks;
using Zoe.Domain.Models;

namespace Zoe.Data.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity<TEntity>, IAggregateRoot
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(Guid id);

        Task<TEntity> GetByIdAsync(Guid id);

        Task<int> SaveChangesAsync();
    }
}
