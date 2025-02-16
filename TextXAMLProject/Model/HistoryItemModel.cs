using TextXAMLProject.Base;

namespace TextXAMLProject.Model
{
    public class HistoryItemModel : ViewModelBase
    {
        private int _id;
        private string _operation;
        private string _result;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }
        public string Operation
        {
            get => _operation;
            set
            {
                _operation = value;
                OnPropertyChanged(nameof(Operation));
            }
        }
        public string Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged(nameof(Operation));
            }
        }
    }
}
