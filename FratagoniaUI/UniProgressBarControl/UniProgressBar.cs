using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UniProgressBarControl
{
  /// <summary>
  /// Follow steps 1a or 1b and then 2 to use this custom control in a XAML file.
  ///
  /// Step 1a) Using this custom control in a XAML file that exists in the current project.
  /// Add this XmlNamespace attribute to the root element of the markup file where it is 
  /// to be used:
  ///
  ///     xmlns:MyNamespace="clr-namespace:UniProgressBarControl"
  ///
  ///
  /// Step 1b) Using this custom control in a XAML file that exists in a different project.
  /// Add this XmlNamespace attribute to the root element of the markup file where it is 
  /// to be used:
  ///
  ///     xmlns:MyNamespace="clr-namespace:UniProgressBarControl;assembly=UniProgressBarControl"
  ///
  /// You will also need to add a project reference from the project where the XAML file lives
  /// to this project and Rebuild to avoid compilation errors:
  ///
  ///     Right click on the target project in the Solution Explorer and
  ///     "Add Reference"->"Projects"->[Select this project]
  ///
  ///
  /// Step 2)
  /// Go ahead and use your control in the XAML file.
  ///
  ///     <MyNamespace:UniProgressBarControl/>
  ///
  /// </summary>
  public class UniProgressBar : UserControl
  {
    /// <summary>
    /// Building out dependency properties for the UniProgressBar
    /// </summary>
    #region DepenedencyProperties

    public double CornerRadiusForFill
    {
      get { return (double)GetValue(CornerRadiusForFillProperty); }
      set { SetValue(CornerRadiusForFillProperty, value); }
    }

    public static readonly DependencyProperty CornerRadiusForFillProperty =
        DependencyProperty.Register(
          "CornerRadiusForFill", 
          typeof(double), 
          typeof(UniProgressBar), 
          new PropertyMetadata(0.0));

    public string DisplayProgressValue
    {
      get { return (string)GetValue(ProgressValueProperty); }
      set { SetValue(DisplayProgressValueProperty, value); }
    }

    // Using a DependencyProperty as the backing store for DisplayProgressValue.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty DisplayProgressValueProperty =
        DependencyProperty.Register(
          "DisplayProgressValue",
          typeof(string),
          typeof(UniProgressBar),
          new PropertyMetadata("0.0"));

    public int DisplayTextHeight
    {
      get { return (int)GetValue(DisplayTextHeightProperty); }
      set { SetValue(DisplayTextHeightProperty, value); }
    }

    public static readonly DependencyProperty DisplayTextHeightProperty =
        DependencyProperty.Register(
          "DisplayTextHeight", 
          typeof(int), 
          typeof(UniProgressBar), 
          new PropertyMetadata(0)); // Default value of 0 int

    public double ProgressValue
    {
      get { return (double)GetValue(ProgressValueProperty); }
      set 
      {
        SetValue(ProgressValueProperty, value);
        SetValue(DisplayProgressValueProperty, value.ToString());
      }
    }

    public static readonly DependencyProperty ProgressValueProperty =
        DependencyProperty.Register(
          "ProgressValue", 
          typeof(double), 
          typeof(UniProgressBar), 
          new PropertyMetadata(0.0)); // Default value of 0.0

    public double MaximumValue
    {
      get { return (double)GetValue(MaximumValueProperty); }
      set { SetValue(MaximumValueProperty, value); }
    }

    public static readonly DependencyProperty MaximumValueProperty =
        DependencyProperty.Register(
          "MaximumValue",
          typeof(double),
          typeof(UniProgressBar),
          new PropertyMetadata(100.0)); // Default value of 100.0


    public bool IsLoaded
    {
      get { return (bool)GetValue(IsLoadedProperty); }
      set { SetValue(IsLoadedProperty, value); }
    }

    public static readonly DependencyProperty IsLoadedProperty =
        DependencyProperty.Register(
          "IsLoaded", 
          typeof(bool),
          typeof(UniProgressBar), 
          new PropertyMetadata(false)); // Default value of false


    public Duration FillTimeDuration
    {
      get { return (Duration)GetValue(FillTimeDurationProperty); }
      set { SetValue(FillTimeDurationProperty, value); }
    }

    public static readonly DependencyProperty FillTimeDurationProperty =
        DependencyProperty.Register(
          "FillTimeDuration", 
          typeof(Duration), 
          typeof(UniProgressBar),
          new PropertyMetadata(Duration.Automatic)); // Default value of Auto, no animation



    #endregion DepenedencyProperties

    #region NativeMethods
    public void UniProgressBar_StartLoaded(object sender, RoutedEventArgs e)
    {
      /// Guard checks
      if (sender== null) { return; }
      if (sender is ProgressBar == false) { return; }

      // Set the progress bar value in easing
      ProgressBar progBar = sender as ProgressBar;
      if (progBar.Value > 0)
      {
        DoubleAnimation animation = new DoubleAnimation
        {
          From = 0.0,
          To = progBar.Value,
          Duration = FillTimeDuration,
          EasingFunction = new CubicEase { EasingMode = EasingMode.EaseOut },
          FillBehavior = FillBehavior.Stop
        };
        // Start the animation
        progBar.BeginAnimation(ProgressBar.ValueProperty, animation);
        // Set _isLoaded
        IsLoaded = true;
      }
    }
    #endregion NativeMethods

    static UniProgressBar()
    {
      DefaultStyleKeyProperty.OverrideMetadata(typeof(UniProgressBar), new FrameworkPropertyMetadata(typeof(UniProgressBar)));
      /// Lets set the value out of the gate
    }
  }
}