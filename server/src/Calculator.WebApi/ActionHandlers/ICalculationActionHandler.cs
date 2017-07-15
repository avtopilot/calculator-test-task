using Calculator.WebApi.Dtos.Calculation;

namespace Calculator.WebApi.ActionHandlers
{
    public interface ICalculationActionHandler
    {
        CalculationResultDto GetCalculationResult(string input);
        CalculationHistoryDto GetHistory();
    }
}