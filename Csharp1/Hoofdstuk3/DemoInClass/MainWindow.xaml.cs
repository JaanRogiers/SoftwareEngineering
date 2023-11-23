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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DrawButton_Click(object sender, RoutedEventArgs e)
        {
            Rectangle middleLeftRectangle = new()
            {
                Width = 100,
                Height = 50,
                Margin = new Thickness(120, 10, 0, 0),
                Stroke = new SolidColorBrush(Colors.Black),
            };

            Line lineInRectangle = new()
            {
                X1 = 10,
                Y1 = 10,
                X2 = 110,
                Y2 = 60,
                Stroke = new SolidColorBrush(Colors.Black),
            };

            Ellipse ellipseInRectangle = new()
            {
                Width = 100,
                Height = 50,
                Margin = new Thickness(120, 10, 0, 0),
                Stroke = new SolidColorBrush(Colors.Black),
            };

            BitmapImage bitmapImage = new();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri("imagedemo.jpg", UriKind.Relative);
            bitmapImage.EndInit();

            Image rightImage = new()
            {
                Source = bitmapImage,
                Width = 150,
                Height = 150,
                Margin = new Thickness(10, 70, 0, 0),
            };

            canvas.Children.Add(middleLeftRectangle);
            canvas.Children.Add(lineInRectangle);
            canvas.Children.Add(ellipseInRectangle);
            canvas.Children.Add(rightImage);
        }
    }
}
