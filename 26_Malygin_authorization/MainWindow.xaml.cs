using System;
using System.Collections.Generic;
using System.Data;
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

namespace _26_Malygin_authorization
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                string login = txtbLogin.Text;
                string password = pswbPassword.Password;
                var user = Helper.GetContext().Users.Where(x => x.Login == login).FirstOrDefault();

                if (user != null)
                {
                    if (user.Password == password)
                    {
                        string role = Helper.GetContext().Roles.Where(x => x.roleID == user.roleID).FirstOrDefault().role;
                        MessageBox.Show($"Добро пожаловать. Ваша роль: {role}.");
                    }
                    else
                    {
                        MessageBox.Show($"Неверный пароль.");
                    }
                }
                else
                {
                    MessageBox.Show($"Пользователя с таким логином не существует.");
                }
            }
            catch 
            {
                MessageBox.Show("Непредвиденная ошибка.");
            }
        }
    }
}
