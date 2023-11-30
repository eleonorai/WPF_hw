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

namespace Wpfhw
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         private int clickCount = 0;
        public MainWindow()
        {
            InitializeComponent();

            Button myButton = new Button();
            myButton.Content = "tap";
            myButton.HorizontalAlignment = HorizontalAlignment.Center;
            myButton.VerticalAlignment = VerticalAlignment.Center;

            myButton.Click += MyButton_Click;

            this.Content = myButton;

        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            clickCount++;
            MessageBox.Show($"Count of taps: {clickCount}");
        }
    }
}