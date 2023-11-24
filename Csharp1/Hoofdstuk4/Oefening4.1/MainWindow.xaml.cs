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

namespace Oefening4._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            canvas.LayoutTransform = new ScaleTransform(1, -1, .5, .5);

            z1TextBox.TextChanged += Z1TextBox_TextChanged;
            z2TextBox.TextChanged += Z2TextBox_TextChanged;
            z3TextBox.TextChanged += Z3TextBox_TextChanged;
        }

        private void Z1TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (z1TextBox.Text == "") z1TextBox.Text = "0";

            double z1 = Convert.ToDouble(z1TextBox.Text);
            double z2 = Convert.ToDouble(z2TextBox.Text);
            double z3 = Convert.ToDouble(z3TextBox.Text);

            UpdateVolume(z1, z2, z3);
            UpdateCube(z1, z2, z3);
        }

        private void Z2TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (z2TextBox.Text == "") z2TextBox.Text = "0";

            double z1 = Convert.ToDouble(z1TextBox.Text);
            double z2 = Convert.ToDouble(z2TextBox.Text);
            double z3 = Convert.ToDouble(z3TextBox.Text);

            UpdateVolume(z1, z2, z3);
            UpdateCube(z1, z2, z3);
        }

        private void Z3TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (z3TextBox.Text == "") z3TextBox.Text = "0";

            double z1 = Convert.ToDouble(z1TextBox.Text);
            double z2 = Convert.ToDouble(z2TextBox.Text);
            double z3 = Convert.ToDouble(z3TextBox.Text);

            UpdateVolume(z1, z2, z3);
            UpdateCube(z1, z2, z3);
        }

        public void UpdateVolume(double z1, double z2, double z3)
        {
            volumeLabel.Content = $"Volume: {Convert.ToString(z1 * z2 * z3)}";
        }

        public void UpdateCube(double z1, double z2, double z3)
        {
            canvas.Children.Clear();

            (double x, double y) c1 = (0, z1);
            (double x, double y) c2 = (0, 0);
            (double x, double y) c3 = (z1, z2);
            (double x, double y) c4 = (z1, 0);
            (double x, double y) c5 = ((z3 / Math.Sqrt(2)), z2 + (z3 / Math.Sqrt(2)));
            (double x, double y) c6 = (z1 + (z3 / Math.Sqrt(2)), z2 + (z3 / Math.Sqrt(2)));
            (double x, double y) c7 = (z1 + (z3 / Math.Sqrt(2)), (z3 / Math.Sqrt(2)));

            List<((double x, double y) p1, (double x, double y) p2)> lines = new()
            {
                (c1, c2),
                (c1, c3),
                (c1, c5),
                (c4, c2),
                (c4, c3),
                (c4, c7),
                (c6, c3),
                (c6, c5),
                (c6, c7),
            };

            foreach (var line in lines)
            {
                canvas.Children.Add(new Line()
                {
                    X1 = line.p1.x,
                    Y1 = line.p1.y,
                    X2 = line.p2.x,
                    Y2 = line.p2.y,
                    Stroke = Brushes.Black,
                    StrokeThickness = 1,
                    Margin = new Thickness(10, 10, 0, 0)
                });
            }
        }
    }
}
