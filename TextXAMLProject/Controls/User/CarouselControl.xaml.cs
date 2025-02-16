using System.Collections.ObjectModel;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Shapes;

namespace TextXAMLProject.Controls.User
{
    public partial class CarouselControl : UserControl, INotifyPropertyChanged
    {
        private ObservableCollection<ImageSource> _imageSources = new ObservableCollection<ImageSource>();
        private int _currentIndex = 0;

        public CarouselControl()
        {
            InitializeComponent();

            ImageSources.Add(LoadImage("Images/cat_1.jpg"));
            ImageSources.Add(LoadImage("Images/cat_2.png"));
            ImageSources.Add(LoadImage("Images/cat_3.jpg"));

            DataContext = this;
        }

        public ObservableCollection<ImageSource> ImageSources
        {
            get { return _imageSources; }
            set
            {
                _imageSources = value;
                OnPropertyChanged();
                if (_imageSources.Count > 0)
                {
                    CurrentIndex = 0;
                }
            }
        }

        public int CurrentIndex
        {
            get { return _currentIndex; }
            set
            {
                if (_currentIndex != value)
                {
                    _currentIndex = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(CurrentImage));
                }
            }
        }

        public ImageSource CurrentImage
        {
            get
            {
                if (_imageSources.Count > 0)
                {
                    return _imageSources[_currentIndex];
                }
                return null;
            }
        }
        private void PreviousButton_Click(object sender, RoutedEventArgs e) => CurrentIndex = (CurrentIndex - 1 + ImageSources.Count) % ImageSources.Count;
        private void NextButton_Click(object sender, RoutedEventArgs e) => CurrentIndex = (CurrentIndex + 1) % ImageSources.Count;
        private ImageSource LoadImage(string relativePath)
        {
            try
            {
                Uri resourceUri = new Uri($"pack://application:,,,/{GetType().Assembly.GetName().Name};component/{relativePath}", UriKind.Absolute);
                return new BitmapImage(resourceUri);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {relativePath}.  Details: {ex.Message}", "Image Load Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return null;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void EventTrigger_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var ellipse = (Ellipse)sender;
            var itemsControl = ItemsControl.ItemsControlFromItemContainer(ellipse);
            if (itemsControl != null)
            {
                int index = itemsControl.ItemContainerGenerator.IndexFromContainer(ellipse);
                CurrentIndex = index;
            }
        }
    }
}