namespace Calculator.WebApi.Dtos.Calculation
{
    public class CalculationResultDto
    {
        public string Expression { get; set; }
        public int Result { get; set; }
        public string ErrorText { get; set; }
    }
}