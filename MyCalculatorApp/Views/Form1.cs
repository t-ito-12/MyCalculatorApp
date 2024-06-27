using MyCalculatorApp.Models.Operators;
using MyCalculatorApp.Models.Specials;
using MyCalculatorApp.ViewModels;

namespace MyCalculatorApp.Views
{
    /// <summary>
    /// ���C����ʂ�View
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// ����View��ViewModel
        /// </summary>
        protected MainViewModel MainViewModel { get; private set; } = new MainViewModel();

        /// <summary>
        /// <see cref="Form1"/>�N���X�̃R���X�g���N�^
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            // �R���\�[��
            _ = mainConsole.DataBindings.Add(nameof(mainConsole.Text), MainViewModel, nameof(MainViewModel.MainConsoleText));

            // ���Z�q�L�[
            // �{�^�� +
            operatorKey_add.Command = MainViewModel.InputOperatorCommand;
            operatorKey_add.CommandParameter = new AddOperator();

            // �{�^�� -
            operatorKey_sub.Command = MainViewModel.InputOperatorCommand;
            operatorKey_sub.CommandParameter = new SubOperator();

            // �{�^�� �~
            operatorKey_mul.Command = MainViewModel.InputOperatorCommand;
            operatorKey_mul.CommandParameter = new MulOperator();

            // �{�^�� ��
            operatorKey_div.Command = MainViewModel.InputOperatorCommand;
            operatorKey_div.CommandParameter = new DivOperator();

            // �{�^�� =
            operatorKey_eq.Command = MainViewModel.InputOperatorCommand;
            operatorKey_eq.CommandParameter = new EqualOperator();

            // �����L�[
            // �{�^�� 0
            numKey_0.Command = MainViewModel.InputNumCommand;
            numKey_0.CommandParameter = numKey_0.Text;

            // �{�^�� 1
            numKey_1.Command = MainViewModel.InputNumCommand;
            numKey_1.CommandParameter = numKey_1.Text;

            // �{�^�� 2
            numKey_2.Command = MainViewModel.InputNumCommand;
            numKey_2.CommandParameter = numKey_2.Text;

            // �{�^�� 3
            numKey_3.Command = MainViewModel.InputNumCommand;
            numKey_3.CommandParameter = numKey_3.Text;

            // �{�^�� 4
            numKey_4.Command = MainViewModel.InputNumCommand;
            numKey_4.CommandParameter = numKey_4.Text;

            // �{�^�� 5
            numKey_5.Command = MainViewModel.InputNumCommand;
            numKey_5.CommandParameter = numKey_5.Text;

            // �{�^�� 6
            numKey_6.Command = MainViewModel.InputNumCommand;
            numKey_6.CommandParameter = numKey_6.Text;

            // �{�^�� 7
            numKey_7.Command = MainViewModel.InputNumCommand;
            numKey_7.CommandParameter = numKey_7.Text;

            // �{�^�� 8
            numKey_8.Command = MainViewModel.InputNumCommand;
            numKey_8.CommandParameter = numKey_8.Text;

            // �{�^�� 9
            numKey_9.Command = MainViewModel.InputNumCommand;
            numKey_9.CommandParameter = numKey_9.Text;

            // ����L�[
            // �{�^�� C
            specialKey_C.Command = MainViewModel.InputSpecialCommand;
            specialKey_C.CommandParameter = new Clear();

            // �{�^�� CE
            specialKey_CE.Command = MainViewModel.InputSpecialCommand;
            specialKey_CE.CommandParameter = new ClearEntry();

            // �{�^�� ��
            specialKey_bk.Command = MainViewModel.InputSpecialCommand;
            specialKey_bk.CommandParameter = new BackSpace();

            // �{�^��+/-
            specialKey_pm.Command = MainViewModel.InputSpecialCommand;
            specialKey_pm.CommandParameter = new PlusMinus();

            // �{�^��.
            specialKey_dot.Command = MainViewModel.InputSpecialCommand;
            specialKey_dot.CommandParameter = new Dot();
        }
    }
}
