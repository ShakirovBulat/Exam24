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
    /// Логика взаимодействия для AddPhonePage.xaml
    /// </summary>
    public partial class AddPhonePage : Window
    {
        web24Entities db = new web24Entities();
        public AddPhonePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Phones phones = new Phones();
            phones.NamePhone = NamePhoneTB.Text;
            phones.Id_MaterialPhone = Convert.ToInt32(TypeMaterialsTB.Text);
            phones.Id_TypeErrors = Convert.ToInt32(TypeErrorTB.Text);
            phones.Id_TypePhone = Convert.ToInt32(TypePhoneTB.Text);
            db.Phones.Add(phones);
            db.SaveChanges();
            MessageBox.Show("Выполнено!");
            VladelecPage vladelecPage = new VladelecPage();
            vladelecPage.Show();
            Close();
        }
    }
}
