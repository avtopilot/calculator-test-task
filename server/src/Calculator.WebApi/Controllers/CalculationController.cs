using System.Collections.Generic;
using Calculator.WebApi.ActionHandlers;
using Calculator.WebApi.Dtos.Calculation;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class CalculationController : Controller
    {
        private readonly ICalculationActionHandler _calculationActionHandler;

        public CalculationController(ICalculationActionHandler calculationActionHandler)
        {
            _calculationActionHandler = calculationActionHandler;
        }

        // GET api/calculation
        [HttpGet]
        public IEnumerable<CalculationResultDto> Get()
        {
            return _calculationActionHandler.GetHistory();
        }

        // GET api/calculation/5
        [HttpGet("{input}")]
        public CalculationResultDto Get(string input)
        {
            return _calculationActionHandler.GetCalculationResult(input);
        }
    }
}