using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace TextXAMLProject.Converters
{
    public class IndexToColorMultiConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null || values.Length != 2)
                return Brushes.Gray;

            if (values[0] is int currentIndex && values[1] is int itemIndex)
            {
                return (currentIndex == itemIndex) ? Brushes.Red : Brushes.Blue;
            }

            return Brushes.Gray;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
