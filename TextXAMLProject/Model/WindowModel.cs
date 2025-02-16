using System.Windows;
using TextXAMLProject.Base;

namespace TextXAMLProject.Model
{
    public class WindowModel<T> where T : ViewModelBase, new()
    {
        public Window Window { get; set; }
        public T ViewModel { get; set; }
    }
}
