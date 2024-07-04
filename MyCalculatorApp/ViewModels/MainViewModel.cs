using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using log4net;
using MyCalculatorApp.Models.Evals;
using MyCalculatorApp.Models.Operators;
using MyCalculatorApp.Models.Specials;

namespace MyCalculatorApp.ViewModels
{
    /// <summary>
    /// メイン画面のViewModel
    /// </summary>
    public partial class MainViewModel : ObservableObject
    {
        /// <summary>
        /// ロガーインスタンス
        /// </summary>
        private ILog Log { get; } = Logger.GetLogger();

        /// <summary>
        /// 計算評価モデル
        /// </summary>
        private EvalModel EvalModel { get; }

        /// <summary>
        /// メインコンソールのテキスト
        /// </summary>
        [ObservableProperty]
        public string _mainConsoleText = "0";

        /// <summary>
        /// 数字キー入力コマンド
        /// </summary>
        /// <param name="num"></param>
        /// <exception cref="ArgumentNullException"></exception>
        [RelayCommand]
        public void InputNum(string num)
        {
            if (string.IsNullOrEmpty(num))
            {
                throw new ArgumentNullException(nameof(num));
            }
            Log.Info($"Input : {num}");
            MainConsoleText = MainConsoleFormat(EvalModel.InputNumber(num));
        }

        /// <summary>
        /// 演算子キー入力コマンド
        /// </summary>
        /// <param name="ope"></param>
        /// <exception cref="AbandonedMutexException"></exception>
        [RelayCommand]
        public void InputOperator(IOperator<string, string> ope)
        {
            if (ope == null)
            {
                throw new AbandonedMutexException(nameof(ope));
            }
            Log.Info($"Input : {ope.Symbol}");
            MainConsoleText = MainConsoleFormat(EvalModel.InputOperator(ope));
        }

        /// <summary>
        /// 特殊キー入力コマンド
        /// </summary>
        /// <param name="special"></param>
        /// <exception cref="ArgumentNullException"></exception>
        [RelayCommand]
        public void InputSpecial(ISpecial special)
        {
            if (special == null)
            {
                throw new ArgumentNullException(nameof(special));
            }
            Log.Info($"Input : {special.Symbol}");
            MainConsoleText = MainConsoleFormat(EvalModel.InputSpecialOperator(special));
            if (string.IsNullOrEmpty(MainConsoleText)) { MainConsoleText = "0"; }
        }

        /// <summary>
        /// <see cref="MainViewModel"/>のコンストラクタ
        /// </summary>
        public MainViewModel()
        {
            EvalModel = new EvalModel();
        }

        /// <summary>
        /// メインコンソールのフォーマット
        /// </summary>
        /// <param name="value">フォーマットしたい文字列</param>
        /// <returns>フォーマット後の文字列</returns>
        /// <remarks>小数点以下5桁まで操作可能</remarks>
        private string MainConsoleFormat(string value)
        {
            string[] number = value.Split(".");
            if (number.Length == 2)
            {
                if (number[1].Length > 5)
                {
                    number[1] = number[1].Substring(0, 5);
                    return $"{number[0]}.{number[1]}";

                }
            }
            return value;
        }
    }
}
