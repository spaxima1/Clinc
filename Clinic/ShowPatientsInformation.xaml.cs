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
    /// Interaction logic for ShowPatientsInformation.xaml
    /// </summary>
    public partial class ShowPatientsInformation : UserControl
    {
        ClinicDBEntities database = new ClinicDBEntities();

        List<InformationTemplate> informationTemplatesItem;
        public ShowPatientsInformation()
        {
            InitializeComponent();
            dgridPatients.Children.Clear();
            foreach (var item in database.Vw_Patients.ToList())
            {
                var inf = new InformationTemplate(item.PatientName, item.PatientFamily, item.PatientPhoneNumber, item.Gender, item.PatientDateBirth,item.PatientID);
                inf.Cursor = Searchbtn.Cursor;
                inf.MouseDown += Inf_MouseDown;
                dgridPatients.Children.Add(inf);
            }
            informationTemplatesItem = dgridPatients.Children.OfType<InformationTemplate>().ToList();
        }

        private void Inf_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var pa =( InformationTemplate)sender;
            new TurnRatingsWindow(pa.name,pa.family,pa.pID,pa.gender).Show();
        }

        private void Searchbtn_Click(object sender, RoutedEventArgs e)
        {
            var data = informationTemplatesItem.Where(c => c.name.Contains(UserNameTxt.Text)).ToList();
            dgridPatients.Children.Clear();

            foreach (var item in data)
            {  
                dgridPatients.Children.Add(item);
            }

        }

        private void PhoneNumberTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            var data = informationTemplatesItem.Where(c => c.phone.Contains(PhoneNumberTxt.Text)).ToList();
            dgridPatients.Children.Clear();

            foreach (var item in data)
            {
                dgridPatients.Children.Add(item);
            }
        }
    }
}
