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

namespace Papamamaya
{
    /// <summary>
    /// Логика взаимодействия для Просмотр_изделия.xaml
    /// </summary>
    public partial class Просмотр_изделия : Window
    {
        private tovari currentizdeliya = new tovari();
        public Просмотр_изделия(tovari selectedizdeliya)
        {
            InitializeComponent();
            if (selectedizdeliya != null)
                currentizdeliya=selectedizdeliya;
            DataContext = currentizdeliya;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nextWindow = new Экран_заказчика();
            nextWindow.Owner = this;
            nextWindow.Show();
            this.Hide();
        }
    }
}
