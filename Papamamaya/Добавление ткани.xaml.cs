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
using static System.Net.Mime.MediaTypeNames;

namespace Papamamaya
{
    /// <summary>
    /// Логика взаимодействия для Добавление_ткани.xaml
    /// </summary>
    public partial class Добавление_ткани : Window
    {
        private tovari curtk = new tovari();
        public Добавление_ткани()
        {
            InitializeComponent();
            DataContext = curtk;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (curtk.articul == 40)
                stEntities3.GetContext().tovari.Add(curtk);
            try
            {
           
                int a = 0;
                MainWindow mainWindow = new MainWindow();
                using (stEntities3 db = new stEntities3())
                {
                    IList<tovari> tovari = db.tovari.ToList();
                    
                    if (a != 1)
                    {
                        db.tovari.Add(new tovari() { 
                            articul = int.Parse(articul.Text), 
                            name = name.Text,
                            size = size.Text,
                            cvet = cvet.Text,
                            sostav = sostav.Text,
                            prod = prod.Text,
                            cena = int.Parse(cena.Text) });
                        db.SaveChanges();
                     
                    }

                }

                stEntities3.GetContext().SaveChanges();
                var doc = $"Отчет о поступлении товара.\nАртикул: {articul.Text}\nНазвание: {name.Text}\nПроизводитель: {prod.Text}\nЦена: {cena.Text}";
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == true)
                    File.WriteAllText(saveFileDialog.FileName, doc);
                MessageBox.Show("Информация сохранена!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            
        }



        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var nextWindow = new Добавление_ткани();
            nextWindow.Owner = this;
            nextWindow.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nextWindow = new Экран_кладовщика();
            nextWindow.Owner = this;
            nextWindow.Show();
            this.Hide();
        }
    }
}
