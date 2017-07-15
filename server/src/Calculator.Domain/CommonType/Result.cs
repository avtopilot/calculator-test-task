namespace Calculator.Domain.CommonType
{
    public class Result<T>
    {
        public T Value { get; set; }
        public bool IsError { get; set; }
        public string ErrorText { get; set; }

        public Result(T value, bool isError = false, string errorText = null)
        {
            Value = value;
            IsError = isError;
            ErrorText = errorText;
        }
        
        public Result(bool isError = false, string errorText = null)
        {
            Value = default(T);
            IsError = isError;
            ErrorText = errorText;
        }
    }
}