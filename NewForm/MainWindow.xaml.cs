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

namespace NewForm
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

        private void circleBTN_Click(object sender, RoutedEventArgs e)
        {
            SquareCircle squareCircle = new SquareCircle();
            squareCircle.Show();
        }

        private void squareBTN_Click(object sender, RoutedEventArgs e)
        {
            SquareArea squareArea = new SquareArea();
            squareArea.Show();
        }
    }
}
