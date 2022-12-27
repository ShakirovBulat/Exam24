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
    /// Логика взаимодействия для AddMaterialsPage.xaml
    /// </summary>
    public partial class AddMaterialsPage : Window
    {
        web24Entities db = new web24Entities();
        public AddMaterialsPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MaterialPhone material = new MaterialPhone();
            material.NameMaterial = MatTB.Text;
            material.Count = KolTB.Text.Length;
            db.MaterialPhone.Add(material);
            db.SaveChanges();
        }
    }
}
