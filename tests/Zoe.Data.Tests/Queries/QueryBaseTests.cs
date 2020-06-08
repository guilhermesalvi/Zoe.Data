using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Zoe.Data.Queries;
using Zoe.Domain.Models;

namespace Zoe.Data.Tests.Queries
{
    public class QueryBaseTests
    {
        [Fact]
        public void Should_Get_One_By_Id()
        {
            var id = new Guid("9849b256-b308-43c0-8794-0066c5443e98");
            var firstEntities = this.GetEntities().AsQueryable().Where(FirstEntityQueries.ById(id));

            Assert.Equal(1, firstEntities.Count());
            Assert.Equal(id, firstEntities.FirstOrDefault().Id);
        }

        private List<FirstEntity> GetEntities()
        {
            return new List<FirstEntity>
            {
                new FirstEntity(new Guid("9849b256-b308-43c0-8794-0066c5443e98")),
                new FirstEntity(new Guid("eac56d2a-57d4-4d11-8060-b1c74ec3b94b")),
                new FirstEntity(new Guid("fedc4b0d-33a8-4115-b06f-a43bde083e5f"))
            };
        }

        private class FirstEntity : Entity<FirstEntity>, IAggregateRoot
        {
            public bool IsValid => true;

            public FirstEntity(Guid id)
            {
                base.Id = id;
            }
        }

        private class FirstEntityQueries : QueryBase<FirstEntity> { }
    }
}
