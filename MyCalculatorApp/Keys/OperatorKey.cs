namespace MyCalculatorApp.Keys
{
    /// <summary>
    /// 演算子キークラス
    /// </summary>
    public partial class OperatorKey : Button
    {
        /// <summary>
        /// <see cref="OperatorKey"/>クラスのコンストラクタ
        /// </summary>
        public OperatorKey()
        {
            InitializeComponent();
        }

        /// <inheritdoc/>
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
