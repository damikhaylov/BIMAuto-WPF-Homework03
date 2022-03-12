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

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_FontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }
        }

        private void ComboBox_FontSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            double fontSize = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
            if (textBox != null)
            {
                textBox.FontSize = fontSize;
            }
        }

        private void Button_Bold_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.FontWeight = (textBox.FontWeight != FontWeights.Bold) ? FontWeights.Bold : FontWeights.Normal;
            }
        }

        private void Button_Italic_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.FontStyle = (textBox.FontStyle != FontStyles.Italic) ? FontStyles.Italic : FontStyles.Normal;
            }
        }

        private void Button_Underline_Click(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.TextDecorations = (textBox.TextDecorations != TextDecorations.Underline) ? TextDecorations.Underline : null;
            }
        }

        private void RadioButton_Black_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Black;
            }
        }

        private void RadioButton_Red_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Red;
            }
        }
    }
}
