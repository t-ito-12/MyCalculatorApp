namespace MyCalculatorApp.Models.Operators
{
    /// <summary>
    /// 加算
    /// </summary>
    public class AddOperator : IOperator<string, string>
    {
        /// <inheritdoc/>
        public string Symbol { get; } = "+";

        /// <inheritdoc/>
        public string Execute(string val1, string val2)
        {
            return (Decimal.Parse(val1) + Decimal.Parse(val2)).ToString();
        }
    }
}
