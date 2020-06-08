using System;
using System.Threading.Tasks;

namespace Zoe.Data.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> CommitAsync();
    }
}
