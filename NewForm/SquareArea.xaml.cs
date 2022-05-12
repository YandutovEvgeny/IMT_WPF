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
using System.Windows.Shapes;

namespace NewForm
{
    /// <summary>
    /// Interaction logic for SquareArea.xaml
    /// </summary>
    public partial class SquareArea : Window
    {
        public SquareArea()
        {
            InitializeComponent();
        }

        private void areaTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = new TextBox();
            string result = "";

            for (int i = 0; i < textBox.Text.Length; i++)
            {
                if(!(textBox.Text[i] < 48 || textBox.Text[i] > 57))
                {
                    result += textBox.Text[i];
                }
            }
            textBox.Text = result;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double side = Convert.ToDouble(areaTB.Text);
                double result = side * side;
                MessageBox.Show($"Площадь квадрата равна {result} квадратных сантиметров");
            }
            catch 
            {
                MessageBox.Show("Введите корректные данные");
            }
        }
    }
}
