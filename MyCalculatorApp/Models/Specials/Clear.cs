using MyCalculatorApp.Models.Evals;

namespace MyCalculatorApp.Models.Specials
{
    /// <summary>
    /// 削除
    /// </summary>
    public class Clear : ISpecial
    {
        /// <inheritdoc/>
        public string Symbol { get; } = "C";

        /// <inheritdoc/>
        public string Execute(IEvalStatus status)
        {
            status.Initialize();
            return "0";
        }
    }
}
