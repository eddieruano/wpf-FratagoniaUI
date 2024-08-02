using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace UniProgressBarControl.Converters
{
  public class ProgressToColorConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      double progress = (double)value;
      byte red;
      byte green;

      if (progress <= 50)
      {
        red= 255;
        green = (byte)(255 * (progress / 50));
      }
      else
      {

       red = (byte)(255 * (2 - progress / 50));
       green = 255;
      }
      return new SolidColorBrush(Color.FromRgb(red, green, 0));
    }
    

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
