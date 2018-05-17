using System;
using System.Globalization;
using Xamarin.Forms;

namespace LolNerferino.ValueConverters
{
    internal class TimeSpanToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var timeSpan = (TimeSpan) value;
            return $"{timeSpan.Minutes}:{timeSpan.Seconds}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}