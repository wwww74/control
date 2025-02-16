using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using System.Windows;

namespace TextXAMLProject.Base
{
    public class ImageSourceWrapper : INotifyPropertyChanged
    {
        private ImageSource _imageSource;
        private int _index;

        public ImageSourceWrapper(ImageSource imageSource, int index)
        {
            _imageSource = imageSource;
            _index = index;
        }
        public ImageSource Source
        {
            get { return _imageSource; }
            set
            {
                if (_imageSource != value)
                {
                    _imageSource = value;
                    OnPropertyChanged();
                }
            }
        }
        public int Index
        {
            get { return _index; }
            set
            {
                if (_index != value)
                {
                    _index = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
