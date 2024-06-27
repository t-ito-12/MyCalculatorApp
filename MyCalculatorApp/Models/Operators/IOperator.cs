namespace MyCalculatorApp.Models.Operators
{
    /// <summary>
    /// 演算子とその処理のインターフェイス
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    public interface IOperator<T1, T2>
    {
        /// <summary>
        /// 演算子の記号
        /// </summary>
        string Symbol { get; }

        /// <summary>
        /// 処理を実行する
        /// </summary>
        /// <param name="val1">入力値1</param>
        /// <param name="val2">入力値2</param>
        /// <returns>出力値</returns>
        string Execute(T1 val1, T2 val2);
    }
}
