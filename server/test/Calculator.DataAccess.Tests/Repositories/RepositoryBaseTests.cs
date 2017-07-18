using System.Linq;
using Calculator.DataAccess.Entities;
using Calculator.DataAccess.Entities.Calculation;
using Calculator.DataAccess.Repositories;
using Calculator.DataAccess.Tests.Entities;
using Xunit;

namespace Calculator.DataAccess.Tests.Repositories
{
    public class RepositoryBaseTests
    {
        [Fact]
        public void RepositoryBase_Should_Save_All_Items()
        {
            // Arrange
            var sut = new RepositoryBase<TestEntity>();
            
            // Act
            sut.Insert(new TestEntity("1"));
            sut.Insert(new TestEntity("2"));
            
            // Assert
            Assert.Equal(2, sut.GetAll().Count());
        }
    }
}