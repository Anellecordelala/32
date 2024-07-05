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

namespace Экзамен2
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
        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void Количество_чисел_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
        private void Результат_TextChanged(object sender, TextChangedEventArgs e)
        {
          Random random = new Random();


        }

        private void Сгенерировать_Click(object sender, RoutedEventArgs e)
        {
           
        }
        private void Вводный_тест_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
