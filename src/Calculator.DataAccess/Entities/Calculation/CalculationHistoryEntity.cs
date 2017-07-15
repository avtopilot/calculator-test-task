using System;

namespace Calculator.DataAccess.Entities.Calculation
{
    public class CalculationHistoryEntity : IEntity
    {
        public CalculationHistoryEntity(string input, int result, string errorMessage = null)
        {
            Id = Guid.NewGuid().ToString();
            Input = input;
            Result = result;
            ErrorMessage = errorMessage;
        }

        public string Id { get; private set; }
        public int Result { get; set; }
        public string Input { get; set; }
        public string ErrorMessage { get; set; }
    }
}