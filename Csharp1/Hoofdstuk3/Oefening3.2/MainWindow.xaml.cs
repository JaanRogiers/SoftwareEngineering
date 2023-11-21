using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Oefening3._2
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
            int rows = 3;
            int columns = 3;

            // Draw the rows
            for (int row = 1; row <= (rows + 1); row++)
            {
                Debug.WriteLine($"new horizontal line: pos1({100}, {row * 50}) pos2({(columns * 100) + 100}, {row * 50})");

                canvas.Children.Add(new Line()
                {
                    X1 = 100,
                    Y1 = row * 50,
                    X2 = (columns * 100) + 100,
                    Y2 = row * 50,
                    Stroke = new SolidColorBrush(Colors.Black),
                });
            }

            // Draw the columns
            for (int column = 1; column <= (columns + 1); column++)
            {
                Debug.WriteLine($"new vertical line: pos1({column * 100}, {50}) pos2({columns * 100}, {(rows * 50) + 50})");

                canvas.Children.Add(new Line()
                {
                    X1 = column * 100,
                    Y1 = 50,
                    X2 = column * 100,
                    Y2 = (rows * 50) + 50,
                    Stroke = new SolidColorBrush(Colors.Black),
                });
            }
        }
    }
}
