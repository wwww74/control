using System;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using TextXAMLProject.Base;
using TextXAMLProject.Model;
using TextXAMLProject.Service;

namespace TextXAMLProject.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private bool _visibilityMenu;
        private bool _visibilityHistory;
        private UserControl _currentView;
        public ObservableCollection<HistoryItemModel> Operations { get; set; }

        public MainWindowViewModel()
        {
            ShowMenuCommand = new RelayCommand(OpenMenuButton_Click);
            ShowHistoryCommand = new RelayCommand(OpenHistoryButton_Click);
            ClearHistoryCommand = new RelayCommand(ClearHistoryButton_Click);
            OpenStandartCalcCommand = new RelayCommand(OpenStandartCalc_Click);
            OpenEngCalcCommand = new RelayCommand(OpenEngineeringCalc_Click);
            OpenCarouselPageCommand = new RelayCommand(OpenCarouselPage_Click);

            VisibilityPanel = false;
            VisibilityMenu = false;

            Operations = new ObservableCollection<HistoryItemModel>();
        }

        #region CommandButton
        public ICommand ShowHistoryCommand { get; }
        public ICommand ClearHistoryCommand { get; }
        public ICommand ShowMenuCommand { get; }
        public ICommand OpenStandartCalcCommand { get; }
        public ICommand OpenEngCalcCommand { get; }
        public ICommand OpenCarouselPageCommand { get; }
        #endregion

        #region ViewProperty
        public bool VisibilityMenu
        {
            get { return _visibilityMenu; }
            set
            {
                _visibilityMenu = value;
                OnPropertyChanged(nameof(VisibilityMenu));
            }
        }
        public bool VisibilityPanel
        {
            get { return _visibilityHistory; }
            set
            {
                _visibilityHistory = value;
                OnPropertyChanged(nameof(VisibilityPanel));
            }
        }
        public UserControl CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }

        #endregion

        #region Methods
        private void MenuVisible()
        {
            if (VisibilityMenu == false)
            {
                DoubleAnimation openAnimation = new DoubleAnimation();
                openAnimation.From = 0;
                openAnimation.To = 180;
                openAnimation.Duration = TimeSpan.FromSeconds(0.5);


                VisibilityMenu = true;
                VisibilityPanel = false;
            }
            else
                VisibilityMenu = false;
        }
        private void HistoryVisible()
        {
            if (VisibilityPanel == false)
            {
                VisibilityPanel = true;
                VisibilityMenu = false;
            }
            else
                VisibilityPanel = false;
        }
        private void OpenMenuButton_Click(object parameter) => MenuVisible();
        private void OpenHistoryButton_Click(object parameter)
        {
            LocalDatabase.Instance.GetAllHistoryItems().ForEach(p =>
            {
                if (!Operations.Contains(p))
                    Operations.Insert(0, p);
            });
            HistoryVisible();
        }
        private void ClearHistoryButton_Click(object parameter)
        {
            Operations.Clear();
            LocalDatabase.Instance.RemoveHistoryItem();
        }
        private void OpenStandartCalc_Click(object parameter)
        {
            VisibilityMenu = false;
            WindowService.Instance.ShowView<StandartCalculatorViewModel>();
        }
        private void OpenEngineeringCalc_Click(object parameter)
        {
            VisibilityMenu = false;
            WindowService.Instance.ShowView<EngineeringCalculatorViewModel>();
        }
        private void OpenCarouselPage_Click(object parameter)
        {
            VisibilityMenu = false;
            WindowService.Instance.ShowView<CarouselPageViewModel>();
        }
        #endregion
    }
}
