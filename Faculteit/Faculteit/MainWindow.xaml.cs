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

namespace Faculteit
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

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            numberTextBox.Clear();
            numberTextBox.Focus();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            double number;
            bool isValid = double.TryParse(numberTextBox.Text, out number);
            if (isValid)
            {

                for (double i = number; i >= 1; i--)
                {
                    number = number * i;
                    resultTextBox.Text = number.ToString();
                }
            }

            else
            {
                MessageBox.Show("Voer een geldig getal in.");
                numberTextBox.Clear();
                numberTextBox.Focus();
            }
        }
    }
}