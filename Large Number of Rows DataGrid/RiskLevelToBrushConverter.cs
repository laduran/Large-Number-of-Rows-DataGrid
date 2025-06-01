using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Large_Number_of_Rows_DataGrid.converters
{
    // Create a IValueConverter that will convert a RiskLevel to a SolidColorBrush
    public class RiskLevelToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return new SolidColorBrush(Colors.Black);

            RiskLevel level = (RiskLevel)value;

            switch (level)
            {
                case RiskLevel.Critical:
                    return new SolidColorBrush(Colors.Red);
                case RiskLevel.High:
                    return new SolidColorBrush(Colors.Orange);
                case RiskLevel.Medium:
                    return new SolidColorBrush(Colors.Yellow);
                case RiskLevel.Low:
                    return new SolidColorBrush(Colors.Green);
                default:
                    return new SolidColorBrush(Colors.Black);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
