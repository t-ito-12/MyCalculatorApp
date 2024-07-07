using log4net;
using MyCalculatorApp.Models.Operators;
using MyCalculatorApp.Models.Specials;

namespace MyCalculatorApp.Models.Evals
{
    /// <summary>
    /// 評価・計算を行うクラス
    /// </summary>
    public class EvalModel : IEvaluable
    {
        /// <summary>
        /// ロガーインスタンス
        /// </summary>
        private ILog Log { get; } = Logger.GetLogger();

        /// <summary>
        /// このクラスの評価状態
        /// </summary>
        private IEvalStatus EvalStatus { get; }

        /// <inheritdoc/>
        public string InputNumber(string value)
        {
            if (string.IsNullOrEmpty(EvalStatus.TempVal))
            {
                EvalStatus.TempVal = value;
                return EvalStatus.TempVal;
            }

            EvalStatus.TempVal += value;
            return EvalStatus.TempVal;
        }

        /// <inheritdoc/>
        public string InputOperator(IOperator<string, string>? ope)
        {
            if (ope == null)
            {
                throw new ArgumentNullException(nameof(ope));
            }

            if (ope is EqualOperator)
            {
                return InputEqualOperator();
            }

            EvalStatus.EqualExist = false;

            if (string.IsNullOrEmpty(EvalStatus.Val1))
            {
                EvalStatus.Val1 = string.IsNullOrEmpty(EvalStatus.TempVal) ? "0" : EvalStatus.TempVal;
                EvalStatus.TempVal = string.Empty;
            }

            if (!string.IsNullOrEmpty(EvalStatus.TempVal))
            {
                EvalStatus.Val2 = EvalStatus.TempVal;
                EvalStatus.TempVal = string.Empty;
            }

            if (string.IsNullOrEmpty(EvalStatus.Val2))
            {
                EvalStatus.Operator = ope;
                SetFormula();
                return EvalStatus.Val1;
            }

            if (EvalStatus.Operator == null)
            {
                EvalStatus.Operator = ope;
                EvalStatus.Val1 = EvalStatus.Val2;
                EvalStatus.Val2 = string.Empty;
                return EvalStatus.Val1;
            }

            if (EvalStatus.EqualExist)
            {
                EvalStatus.Operator = ope;
                EvalStatus.Val2 = string.Empty;
                return EvalStatus.Val1;
            }

            try
            {
                Log.Info($"Evaluate : {EvalStatus.Val1} {EvalStatus.Operator.Symbol} {EvalStatus.Val2}");
                SetFormula();
                EvalStatus.Val1 = EvalStatus.Operator.Execute(EvalStatus.Val1, EvalStatus.Val2);
                Log.Info($"Evaluation Results : {EvalStatus.Val1}");
            }
            catch (DivideByZeroException)
            {
                Log.Info("Error : Cannot be Divided by 0");
                EvalStatus.Initialize();
                return "Error";
            }
            catch (OverflowException ex)
            {
                Log.Error(ex);
                EvalStatus.Initialize();
                return "Error";
            }
            EvalStatus.Operator = ope;
            EvalStatus.Val2 = string.Empty;
            return EvalStatus.Val1;
        }

        /// <summary>
        /// 等号入力
        /// </summary>
        /// <returns>結果</returns>
        private string InputEqualOperator()
        {
            if (string.IsNullOrEmpty(EvalStatus.Val1))
            {
                EvalStatus.Val1 = string.IsNullOrEmpty(EvalStatus.TempVal) ? "0" : EvalStatus.TempVal;
                EvalStatus.TempVal = string.Empty;
            }

            if (EvalStatus.Operator == null)
            {
                return EvalStatus.Val1;
            }

            if (!string.IsNullOrEmpty(EvalStatus.TempVal))
            {
                if (!string.IsNullOrEmpty(EvalStatus.Val2))
                {
                    EvalStatus.Val1 = EvalStatus.TempVal;
                }
                else
                {
                    EvalStatus.Val2 = EvalStatus.TempVal;
                }
                EvalStatus.TempVal = string.Empty;
            }

            if (string.IsNullOrEmpty(EvalStatus.Val2)) { EvalStatus.Val2 = EvalStatus.Val1; }

            try
            {
                EvalStatus.EqualExist = true;
                Log.Info($"Evaluate : {EvalStatus.Val1} {EvalStatus.Operator.Symbol} {EvalStatus.Val2}");
                SetFormula();
                EvalStatus.Val1 = EvalStatus.Operator.Execute(EvalStatus.Val1, EvalStatus.Val2);
                Log.Info($"Evaluation Results : {EvalStatus.Val1}");
            }
            catch (DivideByZeroException)
            {
                Log.Info("Error : Cannot be Divided by 0");
                EvalStatus.Initialize();
                return "Error";
            }
            catch (OverflowException ex)
            {
                Log.Error(ex);
                EvalStatus.Initialize();
                return "Error";
            }
            return EvalStatus.Val1;
        }

        /// <summary>
        /// 式の状態を取得する
        /// </summary>
        /// <returns></returns>
        public string GetFormula()
        {
            return EvalStatus.Formula;
        }

        /// <summary>
        /// 式の状態を設定する
        /// </summary>
        private void SetFormula()
        {
            EvalStatus.Formula = $"{EvalStatus.Val1} {EvalStatus.Operator?.Symbol} {EvalStatus.Val2} {(EvalStatus.EqualExist ? "=" : "")}";
        }

        /// <inheritdoc/>
        public string InputSpecialOperator(ISpecial special)
        {
            return special.Execute(EvalStatus);
        }

        /// <summary>
        /// <see cref="EvalModel"/>クラスのコンストラクタ
        /// </summary>
        public EvalModel()
        {
            EvalStatus = new EvalStatus();
        }
    }
}
