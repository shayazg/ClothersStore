using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для Экран_менеджера.xaml
    /// </summary>
    public partial class Экран_менеджера : Window
    {
        public Экран_менеджера()
        {
            InitializeComponent();
            TextileDataGrid.ItemsSource = stEntities3.GetContext().tovari.ToList();
            ZakazDataGrid.ItemsSource = stEntities3.GetContext().zakaz.ToList();
            UserDataGrid.ItemsSource = stEntities3.GetContext().user.ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var nextWindow = new MainWindow();
            nextWindow.Owner = this;
            nextWindow.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nextWindow = new MainWindow();
            nextWindow.Owner = this;
            nextWindow.Show();
            this.Hide();
        }

        private void Prosmotr_Click(object sender, RoutedEventArgs e)
        {
            var nextWindow = new Просмотр_мен((sender as Button).DataContext as tovari);
            nextWindow.Owner = this;
            nextWindow.Show();
            this.Hide();
        }

        public user zakazchik1 { get; set; }
        //private izdeliya currentizdeliya = new izdeliya();
        
        private void TabItem_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                //stEntities2.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                ZakazDataGrid.ItemsSource = stEntities3.GetContext().zakaz.ToList();
            }
        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                txtEditor.Text = File.ReadAllText(openFileDialog.FileName);
        }
    }
}
