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
    /// Логика взаимодействия для RabMastPage.xaml
    /// </summary>
    public partial class RabMastPage : Window
    {
        web24Entities db = new web24Entities();
        public RabMastPage()
        {
            InitializeComponent();
            Grof.ItemsSource = db.Clients.ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var gg = (Clients)Grof.SelectedItem;
            MessageBox.Show($"{gg.Phones.NamePhone} готов!");
        }

        private void AddMaterials_Click(object sender, RoutedEventArgs e)
        {
            AddMaterialsPage addMaterials = new AddMaterialsPage();
            addMaterials.Show();
            Close();
        }
    }
}
