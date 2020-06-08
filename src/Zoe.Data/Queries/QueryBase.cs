using System;
using System.Linq.Expressions;
using Zoe.Domain.Models;

namespace Zoe.Data.Queries
{
    public class QueryBase<TEntity> where TEntity : Entity<TEntity>, IAggregateRoot
    {
        public static Expression<Func<TEntity, bool>> ById(Guid id)
        {
            return x => x.Id == id;
        }
    }
}
