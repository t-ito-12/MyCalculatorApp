using MyCalculatorApp.Models.Evals;

namespace MyCalculatorApp.Models.Specials
{
    /// <summary>
    /// エントリ削除
    /// </summary>
    public class ClearEntry : ISpecial
    {
        /// <inheritdoc/>
        public string Symbol { get; } = "CE";

        /// <inheritdoc/>
        public string Execute(IEvalStatus status)
        {
            return "0";
        }
    }
}
