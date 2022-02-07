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
using ProgextGibdd.Utilities;
using ProgextGibdd.Entities;
using ProgextGibdd.Pages;

namespace ProgextGibdd.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        List<UsingLogin> userlist = DBContext.Context.UsingLogin.ToList();
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Comebtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in userlist)
            {
                if (LogintxtBox.Text == item.Login.ToString() || PasswordtxtBox.Text.ToString() == item.Password.ToString())
                {
                    FrameManeger.frmMain.Navigate(new DriversPage());
                }
                else
                {
                    MessageBox.Show("Неверный логин или пороль");
                }
            }
        }
    }
}
