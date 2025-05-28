using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Globalization;

namespace Chess_Prototype.Converters;

public class SquareColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        bool isLight = value is bool b && b;
        return isLight ? Brushes.Beige : Brushes.SaddleBrown;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        => throw new NotImplementedException();
}