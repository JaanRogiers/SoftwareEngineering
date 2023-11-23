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

namespace Oefening2._1
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

        private void ButtonOne_Click(object sender, RoutedEventArgs e)
        {
            labelA.Content = "Ja";
            labelB.Content = "Ja";
            labelC.Content = "Ja";
        }

        private void ButtonTwo_Click(object sender, RoutedEventArgs e)
        {
            labelA.Content = "Nee";
            labelB.Content = "Nee";
            labelC.Content = "Nee";
        }

        private void ButtonThree_Click(object sender, RoutedEventArgs e)
        {
            labelA.Content = "A";
            labelB.Content = "B";
            labelC.Content = "C";
        }
    }
}
