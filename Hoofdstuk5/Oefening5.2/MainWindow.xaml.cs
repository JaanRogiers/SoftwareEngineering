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

namespace Oefening5._2
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

        private void ShowNameButton_Click(object sender, RoutedEventArgs e)
        {
            ShowNames(
                    firstname: firstnameTextBox.Text,
                    lastname: lastnameTextBox.Text
                );
        }

        private void ShowNames(string firstname, string lastname)
        {
            MessageBox.Show($"Firstname: {firstname}");
            MessageBox.Show($"Lastname: {lastname}");
        }
    }
}
