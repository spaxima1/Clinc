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

namespace Clinic
{
    /// <summary>
    /// Interaction logic for UserControlRegister.xaml
    /// </summary>
    public partial class UserControlRegister : UserControl
    {
        public UserControlRegister()
        {
            InitializeComponent();
            UserNameTxt.Focus();
        }

        private void UserNameTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
                UserFamilyTxt.Focus();
        }

        private void UserFamilyTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
                NationalCodeTxt.Focus();
        }

        private void NationalCodeTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
                DateBirthTxt.Focus();
        }

        

        private void DateBirthTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
                RegistrationBtn_Click(RegistrationBtn, new RoutedEventArgs());
        }
        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ثبت نام");
        }
    }
}
