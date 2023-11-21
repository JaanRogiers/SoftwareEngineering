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

namespace DemoInClassTwo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {        
        public MainWindow()
        {
            InitializeComponent();

            verticalSlider.Maximum = paperCanvas.Height;
            horizontalSlider.Maximum = paperCanvas.Width;

            verticalLabel.Content = verticalSlider.Value.ToString();
            horizontalLabel.Content = horizontalSlider.Value.ToString();

            verticalSlider.ValueChanged += VerticalSlider_ValueChanged;
            horizontalSlider.ValueChanged += HorizontalSlider_ValueChanged;

            /*verticalSlider.Value = paperCanvas.Height / 2;
            horizontalSlider.Value = paperCanvas.Width / 2;*/
        }

        private void DrawEllipse()
        {
            paperCanvas.Children.Clear();

            paperCanvas.Children.Add(new Ellipse()
            {
                Margin = new Thickness(0, 0, 0, 0),
                Stroke = new SolidColorBrush(Colors.Black),
                Fill = new SolidColorBrush(Colors.Red),
                Height = verticalSlider.Value,
                Width = horizontalSlider.Value
            });
        }

        private void VerticalSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            verticalLabel.Content = Convert.ToInt32(e.NewValue).ToString();
            DrawEllipse();
        }

        private void HorizontalSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            horizontalLabel.Content = Convert.ToInt32(e.NewValue).ToString();
            DrawEllipse();
        }
    }
}
