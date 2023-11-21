using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace Oefening5._4
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

        private void XTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private bool CheckInput()
        {
            // Check if all input is valid
            try
            {
                int x =
            }
            catch
            {

            }
        }

        private bool CheckOutOfBound()
        {

        }

        private void DrawCircle
            (
                Canvas drawArea,
                SolidColorBrush brush,
                double xCentre,
                double yCentre,
                double radius
            )
        {
            

            // Check if circle is out of bounds

            // Draw circle
        }

        private void Canvas_Loaded(object sender, RoutedEventArgs e)
        {
            // Draw x/y axis
            canvas.Children.Add(new Line()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                X1 = 10,
                Y1 = 500 - 15,
                X2 = 30,
                Y2 = 500 - 15,
            });

            canvas.Children.Add(new Line()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                X1 = 30,
                Y1 = 500 - 15,
                X2 = 25,
                Y2 = 500 - 10,
            });

            canvas.Children.Add(new Line()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                X1 = 30,
                Y1 = 500 - 15,
                X2 = 25,
                Y2 = 500 - 20,
            });

            canvas.Children.Add(new Line()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                X1 = 10,
                Y1 = 500 - 15,
                X2 = 10,
                Y2 = 500 - 35,
            });

            canvas.Children.Add(new Line()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                X1 = 10,
                Y1 = 500 - 35,
                X2 = 5,
                Y2 = 500 - 30,
            });

            canvas.Children.Add(new Line()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                X1 = 10,
                Y1 = 500 - 35,
                X2 = 15,
                Y2 = 500 - 30,
            });
        }
    }
}
