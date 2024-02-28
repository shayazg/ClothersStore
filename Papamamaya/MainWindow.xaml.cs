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

namespace Papamamaya
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                var nextWindow = new Регистрация();
                nextWindow.Owner = this;
                nextWindow.Show();
                this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //var login = login1.Text;
            //var password = password1.Password;
            //var user = new user();

            if (login1.Text == String.Empty || password1.Password == String.Empty)
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            using (var db = new stEntities3())
            {
                    foreach (var item in db.user)
                    {
                        if (item.login == login1.Text && item.password == password1.Password && item.role == "Заказчик")
                        {
                            var nextWindow = new Экран_заказчика();
                            nextWindow.Owner = this;
                            nextWindow.Show();
                            this.Hide();
                        }
                        //else if (item.login == login1.Text && item.password == password1.Password && item.role == "Директор")
                        //{
                        //    var nextWindow = new Экран_директора();
                        //    nextWindow.Owner = this;
                        //    nextWindow.Show();
                        //    this.Hide();
                        //}
                        else if (item.login == login1.Text && item.password == password1.Password && item.role == "Кладовщик")
                        {
                            var nextWindow = new Экран_кладовщика();
                            nextWindow.Owner = this;
                            nextWindow.Show();
                            this.Hide();
                        }
                        else if (item.login == login1.Text && item.password == password1.Password && item.role == "Менеджер")
                        {
                            var nextWindow = new Экран_менеджера();
                            nextWindow.Owner = this;
                            nextWindow.Show();
                            this.Hide();
                        }



                    }
                



            }

           
        }
    }
}
