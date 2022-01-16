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
    /// Interaction logic for UserControlMedicine.xaml
    /// </summary>
    public partial class UserControlMedicine : UserControl
    {
        public UserControlMedicine()
        {
            InitializeComponent();
            DataGrid_Medicine.ItemsSource = database.Vw_prescibes.ToList();

        }
        ClinicDBEntities database = new ClinicDBEntities();

        private void SearchMedicinebtn_Click(object sender, RoutedEventArgs e)
        {
            var dataMeadisan = database.find_prescibes_By_phonenumber(PhoneNumberTxt.Text).OrderBy(c => c.PrescribeDate).ToList();
            DataGrid_Medicine.ItemsSource = dataMeadisan;
            try
            {
                var sum = database.sum_medicineSaleePrice(PhoneNumberTxt.Text, dataMeadisan[0].PrescribeDate).First();
                SumMedicnetxt.Text = Convert.ToInt64(sum).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }
    }
}
