using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace OmniChannelAudioRouter.Controls;

/// <summary>
/// Reusable UserControl representing a single audio channel block.
/// Exposes ChannelTitle and TitleColor as dependency properties so each
/// instance can be configured declaratively from MainWindow.xaml.
/// </summary>
public partial class ChannelBlockControl : UserControl
{
    #region Dependency Properties

    public static readonly DependencyProperty ChannelTitleProperty =
        DependencyProperty.Register(
            nameof(ChannelTitle),
            typeof(string),
            typeof(ChannelBlockControl),
            new PropertyMetadata("Audio Channel", OnChannelTitleChanged));

    public static readonly DependencyProperty TitleColorProperty =
        DependencyProperty.Register(
            nameof(TitleColor),
            typeof(Brush),
            typeof(ChannelBlockControl),
            new PropertyMetadata(Brushes.White, OnTitleColorChanged));

    public static readonly DependencyProperty DefaultVolumeProperty =
        DependencyProperty.Register(
            nameof(DefaultVolume),
            typeof(double),
            typeof(ChannelBlockControl),
            new PropertyMetadata(50.0, OnDefaultVolumeChanged));

    public static readonly DependencyProperty DefaultLatencyProperty =
        DependencyProperty.Register(
            nameof(DefaultLatency),
            typeof(string),
            typeof(ChannelBlockControl),
            new PropertyMetadata("0", OnDefaultLatencyChanged));

    public string ChannelTitle
    {
        get => (string)GetValue(ChannelTitleProperty);
        set => SetValue(ChannelTitleProperty, value);
    }

    public Brush TitleColor
    {
        get => (Brush)GetValue(TitleColorProperty);
        set => SetValue(TitleColorProperty, value);
    }

    public double DefaultVolume
    {
        get => (double)GetValue(DefaultVolumeProperty);
        set => SetValue(DefaultVolumeProperty, value);
    }

    public string DefaultLatency
    {
        get => (string)GetValue(DefaultLatencyProperty);
        set => SetValue(DefaultLatencyProperty, value);
    }

    #endregion

    public ChannelBlockControl()
    {
        InitializeComponent();
    }

    #region Property Changed Callbacks

    private static void OnChannelTitleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is ChannelBlockControl control)
            control.TitleText.Text = (string)e.NewValue;
    }

    private static void OnTitleColorChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is ChannelBlockControl control)
            control.TitleText.Foreground = (Brush)e.NewValue;
    }

    private static void OnDefaultVolumeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is ChannelBlockControl control)
        {
            control.VolumeSlider.Value = (double)e.NewValue;
            control.VolumePercentText.Text = $"{(int)(double)e.NewValue}%";
        }
    }

    private static void OnDefaultLatencyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is ChannelBlockControl control)
            control.LatencyTextBox.Text = (string)e.NewValue;
    }

    #endregion

    private void VolumeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
    {
        if (VolumePercentText != null)
        {
            VolumePercentText.Text = $"{(int)e.NewValue}%";
        }
    }
}
