using MyCalculatorApp.Models.Evals;

namespace MyCalculatorApp.Models.Specials
{
    /// <summary>
    /// 特殊記号とその処理のインターフェイス
    /// </summary>
    public interface ISpecial
    {
        /// <summary>
        /// 演算子の記号
        /// </summary>
        string Symbol { get; }

        /// <summary>
        /// 処理を実行する
        /// </summary>
        /// <param name="status">評価の状態</param>
        /// <returns>出力</returns>
        string Execute(IEvalStatus status);
    }
}
