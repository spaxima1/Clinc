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
using DataModelLayer;
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
                PhonenumberTxt.Focus();
        }

        private void NationalCodeTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
                BirhDateclc.Focus();
        }

        

    
        ClinicDBEntities database = new ClinicDBEntities();

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            int gender;
           
          
            if(UserNameTxt.Text.Trim()==""|| UserFamilyTxt.Text.Trim()==""|| PhonenumberTxt.Text.Trim() == "")
            {
                UserNameTxt.Focus();
                MessageBox.Show("لطفا اطلاعات را کامل و درست وارد کنید");
                return;
            }
            if (GenderComBox.SelectedIndex >= 0)
            {
                gender = GenderComBox.SelectedIndex + 1;
            }
            else
            {
                GenderComBox.Focus();
                MessageBox.Show("لطفا جنسیت را وارد کنید");
                return;
            }
            DateTime BD;
            try
            {
                BD = BirhDateclc.SelectedDate.Value.Date;

            }
            catch (Exception)
            {
                MessageBox.Show("لطفا اطلاعات را کامل و درست وارد کنید");
                return;
            }

            database.Patients.Add(new Patient
            {
                PatientName = UserNameTxt.Text.Trim(),
                PatientFamily = UserFamilyTxt.Text.Trim(),
                PatientPhoneNumber = PhonenumberTxt.Text.Trim(),
                PatientGender=Convert.ToByte(gender),
                PatientDateBirth=BD,
                PatientAddress= Addresstxt.Text,
                


            });
            database.SaveChanges();
            MessageBox.Show("ثبت نام انجام شد");
        }
    }
}
