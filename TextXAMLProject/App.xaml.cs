using System.Windows;
using TextXAMLProject.Service;
using TextXAMLProject.View;
using TextXAMLProject.ViewModel;

namespace TextXAMLProject
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            WindowService.Instance.CreateView<StandartCalculatorView, StandartCalculatorViewModel>();
            WindowService.Instance.SetFirstView();
            WindowService.Instance.ShowMain();
        }
    }
}
