using log4net;

namespace MyCalculatorApp
{
    /// <summary>
    /// ロガークラス
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// ロガーインスタンス
        /// </summary>
        private static readonly ILog _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType);

        /// <summary>
        /// ロガーを取得する
        /// </summary>
        /// <returns></returns>
        public static ILog GetLogger()
        {
            return _log;
        }
    }
}
