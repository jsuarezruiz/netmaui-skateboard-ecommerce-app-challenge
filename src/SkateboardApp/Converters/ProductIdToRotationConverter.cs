using System.Globalization;

namespace SkateboardApp.Converters
{
    public class ProductIdToRotationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var productId = (int)value;

            if (productId % 2 == 0)
                return 8;
            else
                return -8;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}