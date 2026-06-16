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

namespace WPFLayoutDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStackPanel_Click(object sender, RoutedEventArgs e)
        {
            Window window = new StackPanelDemo();
            window.Show();
        }

        private void btnWrapPanel_Click(object sender, RoutedEventArgs e)
        {
            Window window = new WrapPanelDemo();
            window.Show();
        }

        private void btnCanvasPanel_Click(object sender, RoutedEventArgs e)
        {
            Window window = new CanvasDemo();
            window.Show();
        }

        private void btnDockPanel_Click(object sender, RoutedEventArgs e)
        {
            Window window = new DockPanelDemo();
            window.Show();
        }

        private void btnGridPanel_Click(object sender, RoutedEventArgs e)
        {
            Window window = new GridDemo();
            window.Show();
        }
    }
}