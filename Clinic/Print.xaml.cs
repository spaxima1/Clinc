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
using DataModelLayer;
namespace Clinic
{
    /// <summary>
    /// Interaction logic for Print.xaml
    /// </summary>
    public partial class Print : Window
    {
        public Print(string phone)
        {
            InitializeComponent();
            var dataMeadisan = database.find_prescibes_By_phonenumber(phone).OrderBy(c => c.PrescribeDate).ToList();
           
            Contentstac.Children.Clear();
            foreach (var item in dataMeadisan)
            {
                var child = new DataShowGrid(item.MedicineName, item.MedicineCount, item.MedicineSaleePrice);
                Contentstac.Children.Add(child);
            }
            try
            {
                PrescibeNamePrinttxt.Text = dataMeadisan[0].PatientName+" "+ dataMeadisan[0].PatientFamily;
                DrNamePrinttxt.Text = dataMeadisan[0].DoctorName + " " + dataMeadisan[0].DoctorFamily;
                DatePrinttxt.Text = dataMeadisan[0].PrescribeDate.ToString();
                var sum = database.sum_medicineSaleePrice(phone, dataMeadisan[0].PrescribeDate).First();
                sumfactotxt.Text = Convert.ToInt64(sum).ToString("#,#");
            }
            catch (Exception ex)
            {

            }
            

        }
        ClinicDBEntities database = new ClinicDBEntities();
        async void print()
        {
            try
            {
                this.IsEnabled = false;

                PrintDialog printDialog = new PrintDialog();

                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(printMedicine, "");
                }

            }
            finally
            {
                this.IsEnabled = true;

            }
        }
        private void printbtn_Click(object sender, RoutedEventArgs e)
        {
           print();
        }

        private void exitbtnprint_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
