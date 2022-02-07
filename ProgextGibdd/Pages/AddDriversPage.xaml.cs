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
    /// Логика взаимодействия для AddDriversPage.xaml
    /// </summary>
    public partial class AddDriversPage : Page
    {
        private Drivers currentDriversl;
        public AddDriversPage(Drivers drivers)
        {
            InitializeComponent();
            currentDriversl = drivers ?? new Drivers();
            DataContext = currentDriversl;
        }

        private void Savebtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            if (string.IsNullOrWhiteSpace(currentDriversl.SurName))
                builder.Append("");
            if (string.IsNullOrWhiteSpace(currentDriversl.Name))
                builder.Append("");
            if (string.IsNullOrWhiteSpace(currentDriversl.MiddlName))
                builder.Append("");
            if (string.IsNullOrWhiteSpace(currentDriversl.Passport))
                builder.Append("");
            if (string.IsNullOrWhiteSpace(currentDriversl.Address))
                builder.Append("");
            if (string.IsNullOrWhiteSpace(currentDriversl.Company))
                builder.Append("");
            if (string.IsNullOrWhiteSpace(currentDriversl.PhoneNumber))
                builder.Append("");
            if (string.IsNullOrWhiteSpace(currentDriversl.Email))
                builder.Append("");
            if (string.IsNullOrWhiteSpace(currentDriversl.Photo))
                currentDriversl.Photo = "001-happy-18.png";

            if (builder.Length > 0)
            {
                MessageBox.Show(builder.ToString());
                return;
            }

            if(currentDriversl.ID == 0)
            {
                DBContext.Context.Drivers.Add(currentDriversl);
            }

            try
            {
                DBContext.Context.SaveChanges();
                MessageBox.Show("Данные сохранены");
                FrameManeger.frmMain.Navigate(new DriversPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Cleanbtn_Click(object sender, RoutedEventArgs e)
        {
            FrameManeger.frmMain.GoBack();
        }
    }
}
