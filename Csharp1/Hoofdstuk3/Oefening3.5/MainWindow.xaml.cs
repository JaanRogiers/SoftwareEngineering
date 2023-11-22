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

namespace Oefening3._5
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

        private void Canvas_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                canvas.Children.Add(new Ellipse()
                {
                    Margin = new Thickness(-225 + (i * 25), -225 + (i * 25), 0, 0),
                    Fill = (i % 2 == 0) ? new SolidColorBrush(Colors.Red) : new SolidColorBrush(Colors.Black),
                    Width = 450 - (i*50),
                    Height = 450 - (i * 50)
                });
            }
        }
    }
}
