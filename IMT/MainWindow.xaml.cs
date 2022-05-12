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

namespace IMT
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

        int count = 0;

        private void WeightTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
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
            count++;
            if(count % 3 == 0)
            {
                Window1 window = new Window1();
                //window.ShowDialog();    //открывает новое модальное окно
                window.Show();    //открывает новое НЕмодальное окно и мы можем взаимодействовать
                //и с главным окном и с вновь открывшемся
            }
            try
            {
                string result = "";
                double h = Convert.ToInt32(HeightTB.Text);
                double w = Convert.ToInt32(WeightTB.Text);
                h = h / 100;
                double imt = w / (h * h);
                if (imt < 15.99)
                    result = "Выраженный дефицит массы тела";
                else if (imt >= 16 && imt < 18.49)
                    result = "Недостаточная (дефицит) массы тела";
                else if (imt >= 18.49 && imt < 24.99)
                    result = "Норма";
                else if (imt >= 24.99 && imt < 29.99)
                    result = "Избыточная масса тела (предожирение)";
                else if (imt >= 29.99 && imt < 34.99)
                    result = "Ожирение первой степени";
                else if (imt >= 34.99 && imt < 39.99)
                    result = "Ожирение второй степени";
                else
                    result = "Ожирение третьей степени";
                MessageBox.Show(result);
            }
            catch 
            {
                MessageBox.Show("Некорректный ввод данных");
            }
        }
    }
}
