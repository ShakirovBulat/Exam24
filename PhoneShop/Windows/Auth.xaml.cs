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
using PhoneShop.DB;

namespace PhoneShop.Windows
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        web24Entities db = new web24Entities();
        public Auth()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTB.Text.Trim() == "" || PasswordTB.Password.Trim() == "")
            {
                MessageBox.Show("Заполните поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else foreach (var user in db.User)
                {
                    if (user.Login == LoginTB.Text.Trim())
                    {
                        if (user.Password == PasswordTB.Password.Trim() && user.Id_Role == 1)
                        {
                            MessageBox.Show($"С возвращением,ваша роль : {user.Role.NameRole}", "Добро пожаловать!", MessageBoxButton.OK, MessageBoxImage.Information);
                            AdminPage admin = new AdminPage();
                            admin.Show();
                            Close();
                        }
                    }
                    if (user.Login == LoginTB.Text.Trim())
                    {
                        if (user.Password == PasswordTB.Password.Trim() && user.Id_Role == 3)
                        {
                            MessageBox.Show($"С возвращением,ваша роль : {user.Role.NameRole} ", "Добро пожаловать!", MessageBoxButton.OK, MessageBoxImage.Information);
                            RabSkladPage rab = new RabSkladPage();
                            rab.Show();
                            Close();
                        }
                    }
                    if (user.Login == LoginTB.Text.Trim())
                    {
                        if (user.Password == PasswordTB.Password.Trim() && user.Id_Role == 4)
                        {
                            MessageBox.Show($"С возвращением,ваша роль : {user.Role.NameRole} ", "Добро пожаловать!", MessageBoxButton.OK, MessageBoxImage.Information);
                            RabMastPage rab1 = new RabMastPage();
                            rab1.Show();
                            Close();
                        }
                    }
                    if (user.Login == LoginTB.Text.Trim())
                    {
                        if (user.Password == PasswordTB.Password.Trim() && user.Id_Role == 2)
                        {
                            MessageBox.Show($"С возвращением,ваша роль : {user.Role.NameRole} ", "Добро пожаловать!", MessageBoxButton.OK, MessageBoxImage.Information);
                            VladelecPage vladelec = new VladelecPage();
                            vladelec.Show();
                            Close();
                        }
                    }
                }
            if (db.User == null)
            {
                MessageBox.Show("Такой User не существует", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                LoginTB.Clear();
                PasswordTB.Clear();
                return;

            }
        }
    }
}
