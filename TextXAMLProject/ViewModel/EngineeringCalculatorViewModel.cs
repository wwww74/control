using System;
using System.Windows.Input;
using TextXAMLProject.Base;
using TextXAMLProject.Model;

namespace TextXAMLProject.ViewModel
{
    public class EngineeringCalculatorViewModel : ViewModelBase
    {
        private string _text;
        private string _lastOutputText;
        private double _lastValue;
        private string _operation;
        public EngineeringCalculatorViewModel()
        {
            #region Init Command
            ProcentCommand = new RelayCommand(PercentButton_Click);
            DelCommand = new RelayCommand(DelButton_Click);
            CECommand = new RelayCommand(CE_Button_Click);
            CComand = new RelayCommand(C_Button_Click);
            EquallyCommand = new RelayCommand(EquallyButton_Click);
            DivisionCommand = new RelayCommand(DivisionButton_Click);
            MultiplicationCommand = new RelayCommand(MultiplicationButton_Click);
            SubtractionCommand = new RelayCommand(SubtractionButton_Click);
            SumCommand = new RelayCommand(SumButton_Click);
            PlusMinusCommand = new RelayCommand(PlusMinusButton_Click);
            OneDelXCommand = new RelayCommand(OneDelButton);
            XPowCommand = new RelayCommand(DegreeButton);
            SqrtCommand = new RelayCommand(SqrtButton);
            CommCommand = new RelayCommand(CommaButton_Click);
            Num0Command = new RelayCommand(Num0Button_Click);
            Num1Command = new RelayCommand(Num1Button_Click);
            Num2Command = new RelayCommand(Num2Button_Click);
            Num3Command = new RelayCommand(Num3Button_Click);
            Num4Command = new RelayCommand(Num4Button_Click);
            Num5Command = new RelayCommand(Num5Button_Click);
            Num6Command = new RelayCommand(Num6Button_Click);
            Num7Command = new RelayCommand(Num7Button_Click);
            Num8Command = new RelayCommand(Num8Button_Click);
            Num9Command = new RelayCommand(Num9Button_Click);
            #endregion
        }

        #region CommandButton
        public ICommand ProcentCommand { get; }
        public ICommand DelCommand { get; }
        public ICommand CECommand { get; }
        public ICommand CComand { get; }
        public ICommand DegreeCommand { get; }
        public ICommand EquallyCommand { get; }
        public ICommand DivisionCommand { get; }
        public ICommand MultiplicationCommand { get; }
        public ICommand SubtractionCommand { get; }
        public ICommand PlusMinusCommand { get; }
        public ICommand OneDelXCommand { get; }
        public ICommand CommCommand { get; }
        public ICommand XPowCommand { get; }
        public ICommand SqrtCommand { get; }
        public ICommand SumCommand { get; }
        public ICommand Num0Command { get; }
        public ICommand Num1Command { get; }
        public ICommand Num2Command { get; }
        public ICommand Num3Command { get; }
        public ICommand Num4Command { get; }
        public ICommand Num5Command { get; }
        public ICommand Num6Command { get; }
        public ICommand Num7Command { get; }
        public ICommand Num8Command { get; }
        public ICommand Num9Command { get; }
        #endregion

        #region NumberButton
        private void Num0Button_Click(object parameter) => Text = GetOutputValue(0);
        private void Num1Button_Click(object parameter) => Text = GetOutputValue(1);
        private void Num2Button_Click(object parameter) => Text = GetOutputValue(2);
        private void Num3Button_Click(object parameter) => Text = GetOutputValue(3);
        private void Num4Button_Click(object parameter) => Text = GetOutputValue(4);
        private void Num5Button_Click(object parameter) => Text = GetOutputValue(5);
        private void Num6Button_Click(object parameter) => Text = GetOutputValue(6);
        private void Num7Button_Click(object parameter) => Text = GetOutputValue(7);
        private void Num8Button_Click(object parameter) => Text = GetOutputValue(8);
        private void Num9Button_Click(object parameter) => Text = GetOutputValue(9);
        private void PlusMinusButton_Click(object parameter) => Text = GetDenial();
        #endregion

        #region OperationButton
        private void DivisionButton_Click(object parameter) => SetOperation("/");
        private void MultiplicationButton_Click(object parameter) => SetOperation("*");
        private void SubtractionButton_Click(object parameter) => SetOperation("-");
        private void SumButton_Click(object parameter) => SetOperation("+");
        private void PercentButton_Click(object parameter) => Text = $"0,{Text}";
        private void DegreeButton(object parameter)
        {
            var val = GetValue();
            val = Math.Pow(val, 2);
            Text = val.ToString();
        }
        private void OneDelButton(object parameter)
        {
            var val = GetValue();
            val = 1 / val;
            Text = val.ToString();
        }
        private void SqrtButton(object parameter)
        {
            var val = GetValue();
            val = Math.Sqrt(val);
            Text = val.ToString();
        }
        private void EquallyButton_Click(object parameter)
        {
            var val = GetValue();

            switch (_operation)
            {
                case "/":
                    Text = (_lastValue / val).ToString();
                    break;
                case "*":
                    Text = (_lastValue * val).ToString();
                    break;
                case "+":
                    Text = (_lastValue + val).ToString();
                    break;
                case "-":
                    Text = (_lastValue - val).ToString();
                    break;
            }

            if (!LastOutputText.Contains("="))
            {
                LastOutputText = $"{LastOutputText} {val} =";
                _lastValue = val;
            }
            else LastOutputText = $"{val} {_operation} {_lastValue} =";

            LocalDatabase.Instance.AddHistoryItem(new HistoryItemModel { Id = LocalDatabase.Instance.GetHistoryItemCount() + 1, Operation = LastOutputText, Result = Text });
        }
        #endregion

        #region FormatButton
        private void DelButton_Click(object parameter)
        {
            if (Text == "0") return;
            if (Text.Length == 1) Text = "0";
            else Text = Text.Remove(Text.Length - 1);
        }
        private void CE_Button_Click(object parameter)
        {
            _lastValue = 0;
            _operation = "";
            LastOutputText = "";
            Text = "0";
        }
        private void C_Button_Click(object parameter) => Text = "0";
        private void CommaButton_Click(object parameter) => Text = GetComma();
        private double GetValue()
        {
            double val = 0;
            double.TryParse(Text, out val);
            return val;
        }
        private string GetOutputValue(int i)
        {
            var val = GetValue();
            if (val == _lastValue) return i.ToString();
            if (Text.Contains(",")) return Text + i;
            return val == 0 ? (i).ToString() : val.ToString() + i.ToString();
        }
        private string GetDenial()
        {
            double val = 0;
            double.TryParse(Text, out val);
            if (val == 0) return val.ToString();
            return (val * -1).ToString();
        }
        private string GetComma()
        {
            var val = Text;
            if (val.Contains(",")) return val;
            return val + ',';
        }
        private void SetOperation(string operation)
        {
            _operation = operation;
            _lastValue = GetValue();
            LastOutputText = $"{_lastValue} {operation}";
            Text = _lastValue.ToString();
        }
        #endregion

        #region ViewProperty
        public string Text
        {
            get { return _text; }
            set
            {
                if (_text != value)
                {
                    _text = value;
                    OnPropertyChanged(nameof(Text));
                }
            }
        }
        public string LastOutputText
        {
            get { return _lastOutputText; }
            set
            {
                if (_lastOutputText != value)
                {
                    _lastOutputText = value;
                    OnPropertyChanged(nameof(LastOutputText));
                }
            }
        }
        #endregion
    }
}
