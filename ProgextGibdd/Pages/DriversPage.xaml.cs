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
using ProgextGibdd.Entities;
using ProgextGibdd.Utilities;

namespace ProgextGibdd.Pages
{
    /// <summary>
    /// Логика взаимодействия для DriversPage.xaml
    /// </summary>
    public partial class DriversPage : Page
    {
        public DriversPage()
        {
            InitializeComponent();

            ListDrivers.ItemsSource = DBContext.Context.Drivers.ToList();
        }

        private void Addbtn_Click(object sender, RoutedEventArgs e)
        {
            FrameManeger.frmMain.Navigate(new AddDriversPage(null));
            ListDrivers.ItemsSource = DBContext.Context.Drivers.ToList();
        }

        private void Editbtn_Click(object sender, RoutedEventArgs e)
        {
            var item = ListDrivers.SelectedItem as Drivers;
            FrameManeger.frmMain.Navigate(new AddDriversPage(item as Drivers));
            ListDrivers.ItemsSource=DBContext.Context.Drivers.ToList();
        }

        private void Deletbtn_Click(object sender, RoutedEventArgs e)
        {
            var delet = ListDrivers.SelectedItem as Drivers;
            if (MessageBox.Show($"Вы хотите удалить продукт №{delet.ID} ?", "Удаление данных", MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    DBContext.Context.Drivers.Remove(delet);
                    DBContext.Context.SaveChanges();
                    MessageBox.Show("Данные удалены");
                    ListDrivers.ItemsSource = DBContext.Context.Drivers.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ListDrivers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Editbtn.Visibility = Visibility.Visible;
            Deletbtn.Visibility = Visibility.Visible;
        }
    }
}
