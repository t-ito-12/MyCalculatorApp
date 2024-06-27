using MyCalculatorApp.Models.Evals;

namespace MyCalculatorApp.Models.Specials
{
    /// <summary>
    /// エントリ削除
    /// </summary>
    public class ClearEntry : ISpecial
    {
        /// <inheritdoc/>
        public string Symbol { get; } = "";

        /// <inheritdoc/>
        public string Execute(IEvalStatus status)
        {
            status.TempVal = string.Empty;
            return "0";
        }
    }
}
