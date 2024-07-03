namespace MyCalculatorApp.Models.Operators
{
    /// <summary>
    /// 等号
    /// </summary>
    public class EqualOperator : IOperator<string, string>
    {
        /// <inheritdoc/>
        public string Symbol { get; } = "=";

        /// <inheritdoc/>
        public string Execute(string val1, string val2)
        {
            return val1;
        }
    }
}
