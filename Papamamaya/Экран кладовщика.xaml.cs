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
using System.IO;

namespace Papamamaya
{
    /// <summary>
    /// Логика взаимодействия для Экран_кладовщика.xaml
    /// </summary>
    public partial class Экран_кладовщика : Window
    {
        public int currentMultiplier = 0;
        //public List<tkan1> tkan1list { get; set; }
        public Экран_кладовщика()
        {
            InitializeComponent();
            TextileDataGrid.ItemsSource = stEntities3.GetContext().tovari.ToList();
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
            var spistk = TextileDataGrid.SelectedItems.Cast<tovari>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующие {spistk.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            { 
            try
                {
                    stEntities3.GetContext().tovari.RemoveRange(spistk);
                    stEntities3.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    TextileDataGrid.ItemsSource = stEntities3.GetContext().tovari.ToList();

                }
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());

                }

             }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var nextWindow = new MainWindow();
            nextWindow.Owner = this;
            nextWindow.Show();
            this.Hide();
        }
        class MyItem
        {
            public string Number { get; set; }
            public int A { get; set; }

            public override string ToString()
            {
                return Number;
            }
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TabItem_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                stEntities3.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                TextileDataGrid.ItemsSource = stEntities3.GetContext().tovari.ToList();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var nextWindow = new Добавление_ткани();
            nextWindow.Owner = this;
            nextWindow.Show();
            this.Hide();
        }


        //private void TabItem_IsVisibleChanged_1(object sender, DependencyPropertyChangedEventArgs e)
        //{
        //    if (Visibility == Visibility.Visible)
        //    {
        //        stEntities2.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
        //        TextileDataGrid.ItemsSource = stEntities2.GetContext().furnitura.ToList();
        //    }
        //}
    }
}
