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

namespace Oefening3._6
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
            // Create the head ellipse
            canvas.Children.Add(new Ellipse()
            {
                Margin = new Thickness(-100, -150, 0, 0),
                Width = 200,
                Height = 300,
                Fill = Brushes.SandyBrown
            });

            // Create left eye ellipse
            canvas.Children.Add(new Ellipse()
            {
                Margin = new Thickness(-10 - 50 - 20, -10 - 100, 0, 0),
                Width = 20,
                Height = 20,
                Fill = Brushes.Black
            });

            // Create right eye ellipse
            canvas.Children.Add(new Ellipse()
            {
                Margin = new Thickness(-10 + 50, -10 - 100, 0, 0),
                Width = 20,
                Height = 20,
                Fill = Brushes.Black
            });

            // Create mouth ellipse
            canvas.Children.Add(new Ellipse()
            {
                Margin = new Thickness(-50, -25 + 50, 0, 0),
                Width = 100,
                Height = 50,
                Fill = Brushes.Red,
                Stroke = Brushes.Black,
                StrokeThickness = 2,
            });
        }
    }
}
