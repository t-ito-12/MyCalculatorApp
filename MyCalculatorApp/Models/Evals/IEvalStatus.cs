using MyCalculatorApp.Models.Operators;

namespace MyCalculatorApp.Models.Evals
{
    /// <summary>
    /// 評価の状態を提供するインターフェイス
    /// </summary>
    public interface IEvalStatus
    {
        /// <summary>
        /// 項1
        /// </summary>
        string Val1 { get; set; }

        /// <summary>
        /// 項2
        /// </summary>
        string Val2 { get; set; }

        /// <summary>
        /// 現在の入力値
        /// </summary>
        string TempVal { get; set; }

        /// <summary>
        /// 演算子
        /// </summary>
        IOperator<string, string>? Operator { get; set; }

        /// <summary>
        /// 式が等号で評価されたか
        /// </summary>
        bool EqualExist { get; set; }

        /// <summary>
        /// 評価式
        /// </summary>
        IEvalFormula EvalFormula { get; }

        /// <summary>
        /// 各プロパティを初期化
        /// </summary>
        void Initialize();
    }
}
