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
        public InformationTemplate(string name,string family,string phone,string gendr,DateTime? date)
        {
            InitializeComponent();
            Nametxt.Text = name;
            Familytxt.Text = family;
            PhoneNumbertxt.Text = phone;
            PatientDateBirthtxt.Text = date.ToString();
            gendertxt.Text = gendr;
        }
    }
}
