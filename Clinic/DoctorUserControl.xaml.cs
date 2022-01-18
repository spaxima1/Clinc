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
    /// Interaction logic for DoctorUserControl.xaml
    /// </summary>
    public partial class DoctorUserControl : UserControl
    {
     
        public DoctorUserControl(string name,string falmily,string DoctorSpecialty,int id)
        {
            InitializeComponent();
            DrIdtxt.Text = id.ToString();
            DrId = id;
            Nametxt.Text = this.DrName = name;
            Familytxt.Text = this.DrFamily = falmily;
            DoctorSpecialtytxt.Text = this.DoctorSpecialtyDr = DoctorSpecialty;
        }
        public string DrName { get; set; }
        public string DrFamily { get; set; }
        public string DoctorSpecialtyDr { get; set; }
        public int DrId { get; set; }
    }
}
