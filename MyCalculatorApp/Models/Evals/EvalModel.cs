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
                EvalStatus.EqualExist = false;
                return EvalStatus.Val1;
            }

            if (EvalStatus.Operator == null)
            {
                // ここに来ることはない
                throw new NullReferenceException(nameof(EvalStatus.Operator));
            }

            if (EvalStatus.EqualExist)
            {
                EvalStatus.Operator = ope;
                EvalStatus.Val2 = string.Empty;
                EvalStatus.EqualExist = false;
                return EvalStatus.Val1;
            }

            try
            {
                EvalStatus.Val1 = EvalStatus.Operator.Execute(EvalStatus.Val1, EvalStatus.Val2);
            }
            catch (DivideByZeroException)
            {
                throw;
            }
            catch (OverflowException)
            {
                throw;
            }
            EvalStatus.Operator = ope;
            EvalStatus.Val2 = string.Empty;
            EvalStatus.EqualExist = false;
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
                EvalStatus.Val1 = EvalStatus.Operator.Execute(EvalStatus.Val1, EvalStatus.Val2);
            }
            catch (DivideByZeroException)
            {
                throw;
            }
            catch (OverflowException)
            {
                throw;
            }
            EvalStatus.EqualExist = true;
            return EvalStatus.Val1;
        }

        /// <inheritdoc/>
        public string InputSpecialOperator(ISpecial special)
        {
            return special.Execute(EvalStatus);
        }

        public EvalModel()
        {
            EvalStatus = new EvalStatus();
        }
    }
}
