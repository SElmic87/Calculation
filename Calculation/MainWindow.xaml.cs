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

namespace Calculation
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
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Minus(int a, int b)
        {
            return a - b;
        }
        public int Ymnozenie(int a, int b)
        {
            return a * b;
        }
        public double Delenie(int a, int b)
        {
            return a / b;
        }

        private void vivod_Click(object sender, RoutedEventArgs e)
        {
            if(deistvie.Text=="+")
            {
                otvet.Content = Sum(Convert.ToInt32(text_a.Text), Convert.ToInt32(text_b.Text));
            }
            if (deistvie.Text == "-")
            {
                otvet.Content = Minus(Convert.ToInt32(text_a.Text), Convert.ToInt32(text_b.Text));
            }
            if (deistvie.Text == "*")
            {
                otvet.Content = Ymnozenie(Convert.ToInt32(text_a.Text), Convert.ToInt32(text_b.Text));
            }
            if (deistvie.Text == "/")
            {
                otvet.Content = Delenie(Convert.ToInt32(text_a.Text), Convert.ToInt32(text_b.Text));
            }
        }
    }
}
