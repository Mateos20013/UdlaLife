using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace UdlaLife.Converters
{
    public class BoolToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isPresent)
            {
                return isPresent ? "Está en la lista" : "No está en la lista";
            }
            return "Desconocido";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
