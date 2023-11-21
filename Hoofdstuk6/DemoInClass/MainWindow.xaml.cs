using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoInClass
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _tries = 0;
        private Random _random = new();

        public MainWindow()
        {
            InitializeComponent();

            _tries++;
            guessLabel.Content = Convert.ToString(_random.Next(1, 110));
        }

        private void CorrectButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Number of tries was: {_tries}");

            _tries = 1;
            guessLabel.Content = Convert.ToString(_random.Next(1, 110));
        }

        private void WrongButton_Click(object sender, RoutedEventArgs e)
        {
            _tries++;
            guessLabel.Content = Convert.ToString(_random.Next(1, 110));
        }
    }
}
