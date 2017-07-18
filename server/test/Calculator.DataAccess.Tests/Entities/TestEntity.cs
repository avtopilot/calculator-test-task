using Calculator.DataAccess.Entities;

namespace Calculator.DataAccess.Tests.Entities
{
    public class TestEntity : IEntity
    {
        public string Id { get; private set; }

        public TestEntity(string id)
        {
            Id = id;
        }
    }
}