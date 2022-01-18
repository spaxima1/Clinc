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
    /// Interaction logic for TurnRatingsWindow.xaml
    /// </summary>
    public partial class TurnRatingsWindow : Window
    {
        public TurnRatingsWindow(string name,string family,int Id ,string gender)
        {
            InitializeComponent();
            DoctorSpecialtyTxt.Focus();
            NamePtxt.Text=PatientNmae = name;
            FmailyPtxt.Text=PatientFamily = family;
            GenderPtxt.Text = gender;
            Patientid = Id;
        }
        public string PatientNmae { get; set; }
        public string PatientFamily { get; set; }
        public string PatientGender { get; set; }
        public int Patientid { get; set; }
        ClinicDBEntities database = new ClinicDBEntities();

        private void Searchbtn_Click(object sender, RoutedEventArgs e)
        {
            Drname.Children.Clear();
            
            var data = database.Doctors.Where(c => c.DoctorSpecialty.Contains(DoctorSpecialtyTxt.Text)).ToList();
            foreach (var item in data)
            {
                var Druse = new DoctorUserControl(item.DoctorName, item.DoctorFamily, item.DoctorSpecialty, item.DoctorID);
                Druse.MouseDown += Druse_MouseDown;
                Druse.Cursor = Searchbtn.Cursor;
                Drname.Children.Add(Druse);

            }
        }

        private void Druse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DRforPatinSact.Children.Clear();
            var p = (DoctorUserControl)sender;
            var np = new DoctorUserControl(p.DrName, p.DrFamily, p.DoctorSpecialtyDr, p.DrId);
            DRforPatinSact.Children.Add(np);
        }

        private void Regster_Click(object sender, RoutedEventArgs e)
        {
            if (DRforPatinSact.Children.Count > 0)
            {
                var drid=DRforPatinSact.Children.OfType<DoctorUserControl>().First().DrId;
                database.TurnRatings.Add(new TurnRating
                {
                    Acctive = true,
                    PatientID = this.Patientid,
                    DoctorID = drid,
                    TurnRatingDate = DateTime.Now


                }); 
                database.SaveChanges();
                MessageBox.Show("با موفیقت انجام شد", "", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("لطفا دکتر مورد نظر را انتخاب کنید", "", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
