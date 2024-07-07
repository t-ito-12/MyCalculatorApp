namespace MyCalculatorApp.Keys
{
    /// <summary>
    /// 数字キークラス
    /// </summary>
    public partial class NumKey : Button
    {
        /// <summary>
        /// <see cref="NumKey"/>クラスのコンストラクタ
        /// </summary>
        public NumKey()
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
