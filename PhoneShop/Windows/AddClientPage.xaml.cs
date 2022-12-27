using PhoneShop.DB;
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

namespace PhoneShop.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddClientPage.xaml
    /// </summary>
    public partial class AddClientPage : Window
    {
        web24Entities db = new web24Entities();
        public AddClientPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Clients clients = new Clients();
            clients.Login = LoginTB.Text;
            clients.Id_Phone = Convert.ToInt32(IdPhoneTB.Text);
            clients.Id_User = Convert.ToInt32(IdAdminTB.Text);
            db.Clients.Add(clients);
            db.SaveChanges();
            MessageBox.Show("Выполнено");
            AdminPage adminPage = new AdminPage();
            adminPage.Show();
            Close();
        }
    }
}
