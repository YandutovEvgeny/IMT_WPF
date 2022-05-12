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
    /// Interaction logic for SquareCircle.xaml
    /// </summary>
    public partial class SquareCircle : Window
    {
        public SquareCircle()
        {
            InitializeComponent();
        }


        private void circleTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            string result = "";
            TextBox textBox = new TextBox();
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
                //double result = 0;
                double radius = Convert.ToDouble(circleTB.Text);
                double result = Math.PI * (radius * radius);
                MessageBox.Show($"Площадь круга равна {result} квадратных сантиметров");
            }
            catch (Exception)
            {
                MessageBox.Show("Введите корректные данные");
            }
        }
    }
}
