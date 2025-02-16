using System;
using System.Windows.Data;
using System.Windows.Media;

namespace TextXAMLProject.Converters
{
    public class IndexToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value is int currentIndex && parameter is int itemIndex)
                return (currentIndex == itemIndex) ? Brushes.Red : Brushes.Blue;

            return Brushes.Gray;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
