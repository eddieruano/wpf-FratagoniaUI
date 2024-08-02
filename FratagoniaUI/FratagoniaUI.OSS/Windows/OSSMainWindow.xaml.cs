using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FratagoniaUI.OSS.Windows
{
  /// <summary>
  /// Interaction logic for OSSMainWindow.xaml
  /// </summary>
  public partial class OSSMainWindow : Window
  {
    public OSSMainWindow()
    {
      InitializeComponent();
    }

    private void UniProgressBarSample_Loaded(object sender, RoutedEventArgs e)
    {
      UniProgressBarControl.UniProgressBar uniProgressBar = sender as UniProgressBarControl.UniProgressBar;
      if (uniProgressBar != null)
      {
        uniProgressBar.UniProgressBar_StartLoaded(sender, e);
      }

    }
  }
}