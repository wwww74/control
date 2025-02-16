using System.Windows.Controls;
using TextXAMLProject.Base;

namespace TextXAMLProject.Model
{
    public class UserControlModel<T> where T : ViewModelBase, new()
    {
        public UserControl View { get; set; }
        public T ViewModel { get; set; }
    }
}
