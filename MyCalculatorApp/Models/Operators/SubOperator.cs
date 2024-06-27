namespace MyCalculatorApp.Models.Operators
{
    /// <summary>
    /// 減算
    /// </summary>
    public class SubOperator : IOperator<string, string>
    {
        /// <inheritdoc/>
        public string Symbol { get; } = "-";

        /// <inheritdoc/>
        public string Execute(string val1, string val2)
        {
            return (Decimal.Parse(val1) - Decimal.Parse(val2)).ToString();
        }
    }
}
