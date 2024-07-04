using MyCalculatorApp.Models.Evals;

namespace MyCalculatorApp.Models.Specials
{
    /// <summary>
    /// プラス・マイナス
    /// </summary>
    public class PlusMinus : ISpecial
    {
        /// <inheritdoc/>
        public string Symbol { get; } = "+/-";

        /// <inheritdoc/>
        public string Execute(IEvalStatus status)
        {
            if (string.IsNullOrEmpty(status.TempVal))
            {
                if (!string.IsNullOrEmpty(status.Val1))
                {
                    status.TempVal = (Decimal.Parse(status.Val1) * -1).ToString();
                    if (!string.IsNullOrEmpty(status.Val2))
                    {
                        status.Val1 = string.Empty;
                    }
                    return status.TempVal;
                }

                return "0";
            }

            status.TempVal = (Decimal.Parse(status.TempVal) * -1).ToString();
            return status.TempVal;
        }
    }
}
