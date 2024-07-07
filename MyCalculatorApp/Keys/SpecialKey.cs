namespace MyCalculatorApp.Keys
{
    /// <summary>
    /// 特殊キー
    /// </summary>
    public partial class SpecialKey : Button
    {
        /// <summary>
        /// <see cref="SpecialKey"/>クラスのコンストラクタ
        /// </summary>
        public SpecialKey()
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
