using MyCalculatorApp.Models.Evals;

namespace MyCalculatorApp.Models.Specials
{
    /// <summary>
    /// バックスペース
    /// </summary>
    public class BackSpace : ISpecial
    {
        /// <inheritdoc/>
        public string Symbol { get; } = "←";

        /// <inheritdoc/>
        public string Execute(IEvalStatus status)
        {
            if (status.EqualExist)
            {
                status.TempVal = status.Val1;
                status.Val1 = string.Empty;
                status.Val2 = string.Empty;
                status.Operator = null;
                return status.TempVal;
            }
            if (string.IsNullOrEmpty(status.TempVal))
            {
                if (!string.IsNullOrEmpty(status.Val1)) 
                {
                    status.TempVal = status.Val1.Remove(status.Val1.Length - 1);
                    if (string.IsNullOrEmpty(status.TempVal))
                    {
                        return "0";
                    }
                }
                return status.TempVal;
            }
            status.TempVal = status.TempVal.Remove(status.TempVal.Length - 1);
            if (string.IsNullOrEmpty(status.TempVal))
            {
                return "0";
            }
            return status.TempVal;
        }
    }
}
