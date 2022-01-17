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


        public ShowPatientsInformation()
        {
            InitializeComponent();
            dgridPatients.Children.Clear();
            foreach (var item in database.Vw_Patients.ToList())
            {
                var inf = new InformationTemplate(item.PatientName, item.PatientFamily, item.PatientPhoneNumber, item.Gender, item.PatientDateBirth);
                dgridPatients.Children.Add(inf);

            }
        }

        private void Searchbtn_Click(object sender, RoutedEventArgs e)
        {
            var data = database.Vw_Patients.Where(c => c.PatientName.Contains(UserNameTxt.Text)).ToList();
            dgridPatients.Children.Clear();

            foreach (var item in data)
            {
                var inf = new InformationTemplate(item.PatientName, item.PatientFamily, item.PatientPhoneNumber, item.Gender, item.PatientDateBirth);
                dgridPatients.Children.Add(inf);

            }

        }
    }
}
