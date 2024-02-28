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
    /// Логика взаимодействия для Регистрация.xaml
    /// </summary>
    public partial class Регистрация : Window
    {
        public Регистрация()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nextWindow = new MainWindow();
            nextWindow.Owner = this;
            nextWindow.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        int a = 0;
            MainWindow mainWindow = new MainWindow();
            using (stEntities3 db = new stEntities3())
            {
                IList<user> user = db.user.ToList();
                foreach (var item in user)
                {
                    if ((item.login == login2.Text))
                    {

                        MessageBox.Show("Такой логин или Email уже используются");
                        mainWindow.Show();
                        this.Hide();
                        a = 1;
                        break;


                    }
                }
                if (a != 1)
                {
                    db.user.Add(new user() { login = login2.Text, password = password2.Password, role = "Заказчик" });
                    db.SaveChanges();
                    MessageBox.Show("Аккаунт создан");
                    mainWindow.Show();
                    this.Hide();
                }

            }

            mainWindow.Show();
            this.Hide();
        }
    }
}
