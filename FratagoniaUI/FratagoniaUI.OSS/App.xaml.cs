using System.Configuration;
using System.Data;
using System.Windows;
using FratagoniaUI.OSS.Windows;

namespace FratagoniaUI.OSS
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    protected override void OnStartup(StartupEventArgs e)
    {
      /// Need to set to Windows fold OSS
      MainWindow = new OSSMainWindow();
      MainWindow.Show();
      /// continue w/ base call
      base.OnStartup(e);
    }
  }

}
