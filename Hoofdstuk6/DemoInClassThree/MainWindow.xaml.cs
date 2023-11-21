using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace DemoInClassThree
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer = new();
        private Random _random = new();

        Dictionary<int, Ellipse> _snowflakes = new();
        private DispatcherTimer _secondTimer = new()
        {
            Interval = TimeSpan.FromSeconds(1)
        };

        public MainWindow()
        {
            InitializeComponent();

            gapLabel.Content = $"{Convert.ToString(Convert.ToInt32(gapSlider.Value))} ms";

            _timer.Interval = TimeSpan.FromMilliseconds(gapSlider.Value);

            gapSlider.ValueChanged += GapSlider_ValueChanged;
            _timer.Tick += _timer_Tick;
            startButton.Click += StartButton_Click;
            stopButton.Click += StopButton_Click;
            clearButton.Click += ClearButton_Click;

            _secondTimer.Tick += _secondTimer_Tick;
        }

        private void _secondTimer_Tick(object? sender, EventArgs e)
        {
            foreach (KeyValuePair<int, Ellipse> snowflake in _snowflakes)
            {
                int marginTop = Convert.ToInt32(snowflake.Value.Margin.Top);
                snowflake.Value.Margin = new Thickness(
                    snowflake.Value.Margin.Left,
                    marginTop += 10,
                    snowflake.Value.Margin.Right,
                    snowflake.Value.Margin.Bottom
                    );

                if (snowflake.Value.Margin.Top > 400)
                {
                    canvas.Children.Remove(snowflake.Value);
                    _snowflakes.Remove(snowflake.Key);
                }
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            _snowflakes.Clear();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            _timer.Start();
            _secondTimer.Start();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
            _secondTimer.Stop();
        }

        private void _timer_Tick(object? sender, EventArgs e)
        {
            int xpos = _random.Next(20, (Convert.ToInt32(canvas.Width) - 20) );
            int diameter = _random.Next(6, 11);

            int snowflakeId;
            while (true)
            {
                snowflakeId = _random.Next();
                if (!_snowflakes.Keys.Contains(snowflakeId)) break;
            }

            Ellipse snowflake = new()
            {
                Margin = new Thickness(xpos, 10, 0, 0),
                Stroke = new SolidColorBrush(Colors.Black),
                Fill = new SolidColorBrush(Colors.White),
                Height = diameter,
                Width = diameter
            };

            _snowflakes.Add(snowflakeId, snowflake);

            canvas.Children.Add(snowflake);
        }

        private void GapSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            gapLabel.Content = $"{Convert.ToString(Convert.ToInt32(gapSlider.Value))} ms";
            _timer.Interval = TimeSpan.FromMilliseconds(gapSlider.Value);
        }
    }
}
