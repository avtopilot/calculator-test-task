using AutoMapper;
using Xunit;

namespace Calculator.CQRS.Tests.Mappings
{
    public class MappingTests
    {
        [Fact]
        public void AutoMapper_Configuration_IsValid()
        {
            //Arrange
            Mapper.Initialize(cfg => cfg.AddProfile(new AutoMapperConfig()));

            //Act

            //Assert
            Mapper.AssertConfigurationIsValid();
        }
    }
}