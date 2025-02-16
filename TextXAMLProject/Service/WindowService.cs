using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using TextXAMLProject.Base;
using TextXAMLProject.Model;
using TextXAMLProject.ViewModel;

namespace TextXAMLProject.Service
{
    public class WindowService
    {
        private static readonly WindowService _instance = new WindowService();
        private WindowModel<MainWindowViewModel> _main = new WindowModel<MainWindowViewModel>();
        private readonly List<UserControlModel<ViewModelBase>> _views = new List<UserControlModel<ViewModelBase>>();
        public static WindowService Instance => _instance;

        WindowService()
        {
            _main.ViewModel = new MainWindowViewModel();
            _main.Window = new MainWindowView { DataContext = _main.ViewModel };
        }
        public void CreateView<TView, TViewModel>()
            where TView : UserControl, new()
            where TViewModel : ViewModelBase, new()
        {
            var viewModel = new TViewModel();
            var view = new TView { DataContext = viewModel };

            _views.Add(new UserControlModel<ViewModelBase> { View = view, ViewModel = viewModel });
        }

        public void SetFirstView() => _main.ViewModel.CurrentView = _views.First().View;

        public void ShowMain() => _main.Window.Show();
        public void ShowView<TViewModel>() where TViewModel : ViewModelBase, new()
        {
            var userControl = _views.FirstOrDefault(p => p.ViewModel.GetType() == typeof(TViewModel));
            if (userControl == null)
            {
                userControl = new UserControlModel<ViewModelBase>();
                var type = typeof(TViewModel);
                var viewType = Type.GetType($"{type.Namespace.Replace("ViewModel", "View")}.{type.Name.Replace("ViewModel", "View")}");
                userControl.ViewModel = (TViewModel)Activator.CreateInstance(type);
                userControl.View = Activator.CreateInstance(viewType) as UserControl;
                userControl.View.DataContext = userControl.ViewModel;
            }

            _views.RemoveAll(p => p.View.GetType() == _main.ViewModel.CurrentView.GetType());
            _main.ViewModel.CurrentView = userControl.View;
        }
    }
}
