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

namespace Oefening3._3
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Create a binding between canvas Width and grid Width
            canvas.SetBinding(Canvas.WidthProperty, new Binding("ActualWidth")
            {
                Source = grid,
                Mode = BindingMode.OneWay
            });

            // Create a binding between canvas height and grid height
            canvas.SetBinding(Canvas.HeightProperty, new Binding("ActualHeight")
            {
                Source = grid,
                Mode = BindingMode.OneWay
            });
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // Draw house
            DrawHouse(canvasBorderOffset: 20);
        }

        private void Canvas_Loaded(object sender, RoutedEventArgs e)
        {
            // Draw house
            DrawHouse(canvasBorderOffset: 20);
        }

        public void ResizeCanvas(double width, double height, bool withCaption = false)
        {
            canvas.Width = width;
            canvas.Height = withCaption ? height - SystemParameters.WindowCaptionButtonHeight : height;
        }

        private void DrawCross(double x, double y, Color color, double width = 5, double height = 5)
        {
            // Draw horizontal line
            canvas.Children.Add(new Line()
            {
                Stroke = new SolidColorBrush(color),
                X1 = x - (width / 2),
                Y1 = y,
                X2 = x + (width / 2),
                Y2 = y,
            });

            // Draw vertical line
            canvas.Children.Add(new Line()
            {
                Stroke = new SolidColorBrush(color),
                X1 = x,
                Y1 = y - (height / 2),
                X2 = x,
                Y2 = y + (height / 2),
            });
        }

        private void DrawHouse(int canvasBorderOffset)
        {
            if (canvas.Height.ToString().Equals("NaN")) return;

            // Clear the canvas
            canvas.Children.Clear();

            // Draw outline
            canvas.Children.Add(new Polygon()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                Points = new PointCollection()
                {
                    new Point(
                        x: canvasBorderOffset,
                        y: canvas.Height - canvasBorderOffset
                    ),
                    new Point(
                        x: canvasBorderOffset,
                        y: canvas.Height - canvasBorderOffset - ((canvas.Height - (canvasBorderOffset * 2)) / 2)
                    ),
                    new Point(
                        x: canvasBorderOffset + ((canvas.Width - (canvasBorderOffset * 2)) / 4),
                        y: canvasBorderOffset
                    ),
                    new Point(
                        x: canvasBorderOffset + ((canvas.Width - (canvasBorderOffset * 2)) / 2),
                        y: canvas.Height - canvasBorderOffset - ((canvas.Height - (canvasBorderOffset * 2)) / 2)
                    ),
                    new Point(
                        x: canvasBorderOffset + (canvas.Width - (canvasBorderOffset * 2)),
                        y: canvas.Height - canvasBorderOffset - ((canvas.Height - (canvasBorderOffset * 2)) / 2)
                    ),
                    new Point(
                        x: canvasBorderOffset + (canvas.Width - (canvasBorderOffset * 2)),
                        y: canvas.Height - canvasBorderOffset
                    ),
                },
            });

            // Draw windows
            canvas.Children.Add(new Rectangle()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                Width = ((canvas.Width - (canvasBorderOffset * 2)) / 2) - (canvasBorderOffset * 2),
                Height = canvasBorderOffset * 2,
                Margin = new Thickness(canvasBorderOffset * 2, (canvasBorderOffset * 2) + ((canvas.Height - (canvasBorderOffset * 2)) / 2), 0, 0),
            });

            double ellipseMidX = canvasBorderOffset + ((canvas.Width - (canvasBorderOffset * 2)) / 4);
            double ellipseMidY = canvasBorderOffset + ((canvas.Height - (canvasBorderOffset * 2)) * 0.1);
            double ellipseWidth = ((canvas.Width - (canvasBorderOffset * 2)) * 0.03) * 2;
            double ellipseHeight = ((canvas.Height - (canvasBorderOffset * 2)) * 0.03) * 2;
            canvas.Children.Add(new Ellipse()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                Width = ellipseWidth,
                Height = ellipseHeight,
                Margin = new Thickness(ellipseMidX - (ellipseWidth / 2), ellipseMidY - (ellipseHeight / 2), 0, 0),
            });
            DrawCross(ellipseMidX, ellipseMidY, Colors.Black, ellipseWidth, ellipseHeight);

            // Draw door
            canvas.Children.Add(new Line()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                X1 = canvasBorderOffset,
                Y1 = canvas.Height - canvasBorderOffset - ((canvas.Height - (canvasBorderOffset * 2)) * 0.2),
                X2 = canvasBorderOffset + ((canvas.Width - (canvasBorderOffset * 2)) * 0.1),
                Y2 = canvas.Height - canvasBorderOffset - ((canvas.Height - (canvasBorderOffset * 2)) * 0.2)
            });
            canvas.Children.Add(new Line()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                X1 = canvasBorderOffset + ((canvas.Width - (canvasBorderOffset * 2)) * 0.1),
                Y1 = canvas.Height - canvasBorderOffset - ((canvas.Height - (canvasBorderOffset * 2)) * 0.2),
                X2 = canvasBorderOffset + ((canvas.Width - (canvasBorderOffset * 2)) * 0.1),
                Y2 = canvas.Height - canvasBorderOffset
            });
            double doorHeight = (canvas.Height - canvasBorderOffset) - (canvas.Height - canvasBorderOffset - ((canvas.Height - (canvasBorderOffset * 2)) * 0.2));
            canvas.Children.Add(new Line()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                X1 = canvasBorderOffset + ((canvas.Width - (canvasBorderOffset * 2)) * 0.09),
                Y1 = canvas.Height - canvasBorderOffset - ((canvas.Height - (canvasBorderOffset * 2)) * 0.2) + (doorHeight / 2) - (doorHeight / 9),
                X2 = canvasBorderOffset + ((canvas.Width - (canvasBorderOffset * 2)) * 0.09),
                Y2 = canvas.Height - canvasBorderOffset - ((canvas.Height - (canvasBorderOffset * 2)) * 0.2) + (doorHeight / 2) + (doorHeight / 9)
            });

            // Draw garage
            canvas.Children.Add(new Line()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                X1 = canvasBorderOffset + ((canvas.Width - (canvasBorderOffset * 1.1)) / 2),
                Y1 = canvas.Height - canvasBorderOffset - ((canvas.Height - (canvasBorderOffset * 2)) / 2),
                X2 = canvasBorderOffset + ((canvas.Width - (canvasBorderOffset * 1.1)) / 2),
                Y2 = canvas.Height - canvasBorderOffset
            });
            double garageHeight = (canvasBorderOffset + (canvas.Height - (canvasBorderOffset * 2))) - (canvas.Height - canvasBorderOffset - ((canvas.Height - (canvasBorderOffset * 2)) / 2));
            double garageLineY1 = canvas.Height - canvasBorderOffset - (garageHeight * 0.25);
            double garageLineY2 = canvas.Height - canvasBorderOffset - (garageHeight * 0.5);
            double garageLineY3 = canvas.Height - canvasBorderOffset - (garageHeight * 0.75);
            canvas.Children.Add(new Line()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                X1 = canvasBorderOffset + ((canvas.Width - (canvasBorderOffset * 1.1)) / 2),
                Y1 = garageLineY1,
                X2 = canvasBorderOffset + (canvas.Width - (canvasBorderOffset * 2)),
                Y2 = garageLineY1,
            });
            canvas.Children.Add(new Line()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                X1 = canvasBorderOffset + ((canvas.Width - (canvasBorderOffset * 1.1)) / 2),
                Y1 = garageLineY2,
                X2 = canvasBorderOffset + (canvas.Width - (canvasBorderOffset * 2)),
                Y2 = garageLineY2,
            });
            canvas.Children.Add(new Line()
            {
                Stroke = new SolidColorBrush(Colors.Black),
                X1 = canvasBorderOffset + ((canvas.Width - (canvasBorderOffset * 1.1)) / 2),
                Y1 = garageLineY3,
                X2 = canvasBorderOffset + (canvas.Width - (canvasBorderOffset * 2)),
                Y2 = garageLineY3,
            });
        }
    }
}
