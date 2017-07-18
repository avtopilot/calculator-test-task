using System.Collections.Generic;
using Calculator.WebApi.ActionHandlers;
using Calculator.WebApi.Controllers;
using Calculator.WebApi.Dtos.Calculation;
using NSubstitute;
using Xunit;

namespace Calculator.WebApi.Tests.Controllers
{
    public class CalculationControllerTests
    {
        [Fact]
        public void Get_Expression_Should_Return_CalculationResultDto()
        {
            //Arrange
            var expectedResultDto = new CalculationResultDto();
            var sut = new CalculationControllerSut();

            sut.CalculationActionHandler.GetCalculationResult(Arg.Any<string>()).Returns(expectedResultDto);

            //Act
            var result = sut.Get("1");

            //Assert
            Assert.Equal(expectedResultDto, result);
        }
        
        [Fact]
        public void Get_History_Should_Return_List_Of_CalculationResultDto()
        {
            //Arrange
            var expectedResultDto = new List<CalculationResultDto>();
            var sut = new CalculationControllerSut();

            sut.CalculationActionHandler.GetHistory().Returns(expectedResultDto);

            //Act
            var result = sut.Get();

            //Assert
            Assert.Equal(expectedResultDto, result);
        }
    }

    public class CalculationControllerSut : CalculationController
    {
        public ICalculationActionHandler CalculationActionHandler { get; private set; } 
        
        public CalculationControllerSut(ICalculationActionHandler calculationActionHandler) : base(calculationActionHandler)
        {
            CalculationActionHandler = calculationActionHandler;
        }
        
        public CalculationControllerSut() : this(Substitute.For<ICalculationActionHandler>())
        {}
    }
}