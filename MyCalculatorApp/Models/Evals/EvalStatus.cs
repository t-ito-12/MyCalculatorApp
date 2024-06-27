using MyCalculatorApp.Models.Operators;

namespace MyCalculatorApp.Models.Evals
{
    /// <summary>
    /// 評価の状態
    /// </summary>
    public class EvalStatus : IEvalStatus
    {
        /// <inheritdoc/>
        public string Val1 
        {
            get => _val1;
            set => _val1 = Normalize(value);
        }
        private string _val1 = string.Empty;

        /// <inheritdoc/>
        public string Val2
        {
            get => _val2;
            set => _val2 = Normalize(value);
        }
        private string _val2 = string.Empty;

        /// <inheritdoc/>
        public string TempVal
        {
            get => _tempVal;
            set
            {
                if (value == "-0")
                {
                    // -0 は 0とする
                    value = "0";
                }
                _tempVal = value;
            }
        }
        private string _tempVal = string.Empty;

        /// <inheritdoc/>
        public IOperator<string, string>? Operator { get; set; } = null;

        /// <inheritdoc/>
        public bool EqualExist { get; set; } = false;

        /// <inheritdoc/>
        public void Initialize()
        {
            Val1 = string.Empty;
            Val2 = string.Empty;
            TempVal = string.Empty;
            Operator = null;
            EqualExist = false;
        }

        /// <summary>
        ///後置0を削除
        /// </summary>
        /// <param name="val1">値</param>
        /// <returns>後置0削除後の値</returns>
        private string Normalize(string val)
        {
            if (string.IsNullOrWhiteSpace(val)) { return val; }
            return (Decimal.Parse(val) / 1.000000000m).ToString();
        }

        /// <summary>
        /// <see cref="EvalStatus"/>クラスのコンストラクタ
        /// </summary>
        public EvalStatus()
        {
            Initialize();
        }
    }
}
