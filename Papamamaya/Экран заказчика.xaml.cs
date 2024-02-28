using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
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
    /// Логика взаимодействия для Экран_заказчика.xaml
    /// </summary>
    public partial class Экран_заказчика : Window
    {
        public Экран_заказчика()
        {
            InitializeComponent();
            TextileDataGrid.ItemsSource = stEntities3.GetContext().tovari.ToList();
            TextileDataGrid2.ItemsSource = stEntities3.GetContext().tovari.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nextWindow = new MainWindow();
            nextWindow.Owner = this;
            nextWindow.Show();
            this.Hide();
        }

        

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var nextWindow = new MainWindow();
            nextWindow.Owner = this;
            nextWindow.Show();
            this.Hide();
        }

        private void Prosmotr_Click(object sender, RoutedEventArgs e)
        {
            var nextWindow = new Просмотр_изделия((sender as Button).DataContext as tovari);
            nextWindow.Owner = this;
            nextWindow.Show();
            this.Hide();
        }

       
        public user zakazchik1 { get; set; }
        //private izdeliya currentizdeliya = new izdeliya();
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           DateTime d = DateTime.Now;


            using (stEntities3 db = new stEntities3())
            {
                zakaz zakaz = new zakaz()
                {
                    data = d,
                    status = "Новый",
                    zakazchik = "4",
                    manager = "Язгуль"
                };
                db.zakaz.Add(zakaz);
                MessageBox.Show("Заказ принят");
                db.SaveChanges();
               
            }
        }

        private void TabItem_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                stEntities3.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            }
        }
    }
}
