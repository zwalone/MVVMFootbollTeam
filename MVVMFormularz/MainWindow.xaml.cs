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

namespace MVVMFormularz
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Surname_tb_GotFocus(object sender, RoutedEventArgs e)
        {
            surname_tb.BorderBrush = Brushes.Black;
        }

        private void Surname_tb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(surname_tb.Text))
            {
                surname_tb.BorderBrush = Brushes.Red;
            }
        }

        private void Name_tb_GotFocus(object sender, RoutedEventArgs e)
        {
            name_tb.BorderBrush = Brushes.Black;
        }

        private void Name_tb_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name_tb.Text))
            {
                name_tb.BorderBrush = Brushes.Red;
            }
        }
    }
}
