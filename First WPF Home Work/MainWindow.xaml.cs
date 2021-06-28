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

namespace First_WPF_Home_Work
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
        Random r = new Random();
        private void Six_Btn_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
              (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            Six_Btn.Background = brush;
            MessageBox.Show("I am Sixth");
        }

        private void Five_Btn_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
              (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            Five_Btn.Background = brush;
            MessageBox.Show("I am Fiveth");
        }

        private void Four_Btn_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
              (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            Four_Btn.Background = brush;
            MessageBox.Show("I am Fourth");
        }

        private void Thir_Btn_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
              (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            Thir_Btn.Background = brush;
            MessageBox.Show("I am Third");
        }

        private void Sec_Btn_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
              (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            Sec_Btn.Background = brush;
            MessageBox.Show("I am Second");
        }

        private void First_Btn_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = new SolidColorBrush(Color.FromRgb((byte)r.Next(1, 255),
              (byte)r.Next(1, 255), (byte)r.Next(1, 233)));
            First_Btn.Background = brush;
            MessageBox.Show("I am First");
        }
    }
}
