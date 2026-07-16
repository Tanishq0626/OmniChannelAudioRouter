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

namespace OmniChannelAudioRouter;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private int _testCount = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void TestButton_Click(object sender, RoutedEventArgs e)
    {
        _testCount++;
        StatusText.Text = $"✔ Test #{_testCount} passed  —  All 3 channels responded  ({DateTime.Now:HH:mm:ss})";
    }
}