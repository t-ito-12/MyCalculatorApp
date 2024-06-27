using MyCalculatorApp.Models.Evals;

namespace MyCalculatorApp.Models.Specials
{
    /// <summary>
    /// 小数点
    /// </summary>
    public class Dot : ISpecial
    {
        /// <inheritdoc/>
        public string Symbol { get; } = ".";

        /// <inheritdoc/>
        public string Execute(IEvalStatus status)
        {
            if (status.TempVal.Contains("."))
            {
                return status.TempVal;
            }

            if (string.IsNullOrEmpty(status.TempVal))
            {
                if (!string.IsNullOrEmpty(status.Val1))
                {
                    status.TempVal = status.Val1.Contains(".") ? status.Val1 : status.Val1 + ".";
                    if (!string.IsNullOrEmpty(status.Val2))
                    {
                        status.Val1 = string.Empty;
                    }
                    return status.TempVal;
                }

                status.TempVal = "0.";
                return status.TempVal;
            }

            status.TempVal += ".";
            return status.TempVal;
        }
    }
}
