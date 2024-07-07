using MyCalculatorApp.Models.Operators;

namespace MyCalculatorApp.Models.Evals
{
    /// <summary>
    /// 評価式の状態を保持するクラス
    /// </summary>
    public class EvalFormula : IEvalFormula
    {
        /// <inheritdoc/>
        public string Val1 { get; private set; } = string.Empty;

        /// <inheritdoc/>
        public string Val2 { get; private set; } = string.Empty;

        /// <inheritdoc/>
        public IOperator<string, string>? Operator { get; private set; } = null;

        /// <inheritdoc/>
        public bool EqualExist { get; private set; } = false;

        /// <inheritdoc/>
        public void Initialize()
        {
            Val1 = string.Empty;
            Val2 = string.Empty;
            Operator = null;
            EqualExist = false;
        }

        /// <inheritdoc/>
        public void SetFormula(string val1, string val2, IOperator<string, string>? ope, bool equalExist)
        {
            Val1 = val1;
            Val2 = val2;
            Operator = ope;
            EqualExist = equalExist;
        }
    }
}
