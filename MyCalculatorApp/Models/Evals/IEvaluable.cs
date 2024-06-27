using MyCalculatorApp.Models.Operators;
using MyCalculatorApp.Models.Specials;

namespace MyCalculatorApp.Models.Evals
{
    /// <summary>
    /// 評価・計算に必要な処理のインターフェイス
    /// </summary>
    public interface IEvaluable
    {
        /// <summary>
        /// 数字入力
        /// </summary>
        /// <param name="value">数字</param>
        /// <returns>結果</returns>
        string InputNumber(string value);

        /// <summary>
        /// 演算子入力
        /// </summary>
        /// <param name="ope">演算子</param>
        /// <returns>結果</returns>
        string InputOperator(IOperator<string, string> ope);

        /// <summary>
        /// 特殊記号入力
        /// </summary>
        /// <param name="special">特殊記号</param>
        /// <returns>結果</returns>
        string InputSpecialOperator(ISpecial special);
    }
}
