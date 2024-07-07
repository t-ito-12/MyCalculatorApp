using MyCalculatorApp.Models.Operators;

namespace MyCalculatorApp.Models.Evals
{
    /// <summary>
    /// 評価式の状態を提供するインターフェイス
    /// </summary>
    public interface IEvalFormula
    {
        /// <summary>
        /// 項1
        /// </summary>
        string Val1 { get; }

        /// <summary>
        /// 項2
        /// </summary>
        string Val2 { get; }

        /// <summary>
        /// 演算子
        /// </summary>
        IOperator<string, string>? Operator { get;}

        /// <summary>
        /// 式が等号で評価されたか
        /// </summary>
        bool EqualExist { get; }

        /// <summary>
        /// 初期化
        /// </summary>
        public void Initialize();

        /// <summary>
        /// 評価式を設定する
        /// </summary>
        /// <param name="val1">項1</param>
        /// <param name="val2">項2</param>
        /// <param name="ope">演算子</param>
        /// <param name="equalExist">式が等号で評価されたか</param>
        public void SetFormula(string val1, string val2, IOperator<string, string>? ope, bool equalExist);
    }
}
