using System.Collections.Generic;

namespace Calculator.WebApi.Dtos.Calculation
{
    public class CalculationHistoryDto
    {
        public IEnumerable<CalculationResultDto> History { get; set; }
    }
}