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

namespace Oefening2._6
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

        // Keys that are being held down
        List<Key> keysDown = new();

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Remove text from textBlock
            textBlock.Text = string.Empty;

            // Put the pressed key in a variable
            Key keyDown = e.Key;

            // Add the presse key to keysDown
            if (!keysDown.Contains(keyDown)) keysDown.Add(keyDown);

            // Check if N was pressed and if ALT is being held down
            if (keyDown.Equals(Key.N) && keysDown.Contains(Key.RightAlt))
            {
                textBlock.Text = "\"ALT + N\" was pressed.";
            }

            // Samee check but also checking the order
/*          if (keyDown.Equals(Key.N) && keysDown.Contains(Key.RightAlt)
                && keysDown.IndexOf(Key.RightAlt) < keysDown.IndexOf(keyDown))
            {
                textBlock.Text = "\"ALT + N\" was pressed.";
            }¨*/
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            Key keyUp = e.Key;

            if (keysDown.Contains(keyUp)) keysDown.Remove(keyUp);

            /* Debug code
            Debug.WriteLine("");
            Debug.WriteLine($"Keys down: {string.Join(" | ", keysDown)}");
            Debug.WriteLine($"key up: {keyUp}");
            */
        }

        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {
        }
    }
}
