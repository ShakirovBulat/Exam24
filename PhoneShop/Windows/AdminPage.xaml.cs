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
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Window
    {
        web24Entities db = new web24Entities();
        public AdminPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Grof.ItemsSource = db.Phones.ToList();
        }

        private void AddBTN_Click(object sender, RoutedEventArgs e)
        {
            AddClientPage add = new AddClientPage();
            add.Show();
            Close();
        }

        private void Vozvrat_Click(object sender, RoutedEventArgs e)
        {
            var gg = (Phones)Grof.SelectedItem;
            MessageBox.Show($"{gg.NamePhone} возврат!");
        }
    }
}
