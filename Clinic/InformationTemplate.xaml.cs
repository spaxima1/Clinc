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
    /// Interaction logic for InformationTemplate.xaml
    /// </summary>
    public partial class InformationTemplate : UserControl
    {
        public InformationTemplate(string name,string family,string phone,string gendr,DateTime? date,int id)
        {
            InitializeComponent();
            Nametxt.Text=this.name = name;
            Familytxt.Text=this.family = family;
            PhoneNumbertxt.Text =this.phone= phone;
            PatientDateBirthtxt.Text =this.Brithday= date.ToString();
            gendertxt.Text = this.gender = gendr;
            pID = id;
            
        }
        public int pID { get; set; }
        public string name { get; set; }
        public string family  { get; set; }
        public string phone { get; set; }
        public string  gender { get; set; }
        public string Brithday { get; set; }

    }
}
