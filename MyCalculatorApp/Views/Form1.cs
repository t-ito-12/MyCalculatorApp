using MyCalculatorApp.Models.Operators;
using MyCalculatorApp.Models.Specials;
using MyCalculatorApp.ViewModels;

namespace MyCalculatorApp.Views
{
    /// <summary>
    /// メイン画面のView
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// このViewのViewModel
        /// </summary>
        protected MainViewModel MainViewModel { get; private set; } = new MainViewModel();

        /// <summary>
        /// <see cref="Form1"/>クラスのコンストラクタ
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            // コンソール
            _ = mainConsole.DataBindings.Add(nameof(mainConsole.Text), MainViewModel, nameof(MainViewModel.MainConsoleText));

            // 演算子キー
            // ボタン +
            operatorKey_add.Command = MainViewModel.InputOperatorCommand;
            operatorKey_add.CommandParameter = new AddOperator();

            // ボタン -
            operatorKey_sub.Command = MainViewModel.InputOperatorCommand;
            operatorKey_sub.CommandParameter = new SubOperator();

            // ボタン ×
            operatorKey_mul.Command = MainViewModel.InputOperatorCommand;
            operatorKey_mul.CommandParameter = new MulOperator();

            // ボタン ÷
            operatorKey_div.Command = MainViewModel.InputOperatorCommand;
            operatorKey_div.CommandParameter = new DivOperator();

            // ボタン =
            operatorKey_eq.Command = MainViewModel.InputOperatorCommand;
            operatorKey_eq.CommandParameter = new EqualOperator();

            // 数字キー
            // ボタン 0
            numKey_0.Command = MainViewModel.InputNumCommand;
            numKey_0.CommandParameter = numKey_0.Text;

            // ボタン 1
            numKey_1.Command = MainViewModel.InputNumCommand;
            numKey_1.CommandParameter = numKey_1.Text;

            // ボタン 2
            numKey_2.Command = MainViewModel.InputNumCommand;
            numKey_2.CommandParameter = numKey_2.Text;

            // ボタン 3
            numKey_3.Command = MainViewModel.InputNumCommand;
            numKey_3.CommandParameter = numKey_3.Text;

            // ボタン 4
            numKey_4.Command = MainViewModel.InputNumCommand;
            numKey_4.CommandParameter = numKey_4.Text;

            // ボタン 5
            numKey_5.Command = MainViewModel.InputNumCommand;
            numKey_5.CommandParameter = numKey_5.Text;

            // ボタン 6
            numKey_6.Command = MainViewModel.InputNumCommand;
            numKey_6.CommandParameter = numKey_6.Text;

            // ボタン 7
            numKey_7.Command = MainViewModel.InputNumCommand;
            numKey_7.CommandParameter = numKey_7.Text;

            // ボタン 8
            numKey_8.Command = MainViewModel.InputNumCommand;
            numKey_8.CommandParameter = numKey_8.Text;

            // ボタン 9
            numKey_9.Command = MainViewModel.InputNumCommand;
            numKey_9.CommandParameter = numKey_9.Text;

            // 特殊キー
            // ボタン C
            specialKey_C.Command = MainViewModel.InputSpecialCommand;
            specialKey_C.CommandParameter = new Clear();

            // ボタン CE
            specialKey_CE.Command = MainViewModel.InputSpecialCommand;
            specialKey_CE.CommandParameter = new ClearEntry();

            // ボタン ←
            specialKey_bk.Command = MainViewModel.InputSpecialCommand;
            specialKey_bk.CommandParameter = new BackSpace();

            // ボタン+/-
            specialKey_pm.Command = MainViewModel.InputSpecialCommand;
            specialKey_pm.CommandParameter = new PlusMinus();

            // ボタン.
            specialKey_dot.Command = MainViewModel.InputSpecialCommand;
            specialKey_dot.CommandParameter = new Dot();
        }
    }
}
