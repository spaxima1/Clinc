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
    /// Interaction logic for TurnRatingsListUserControl.xaml
    /// </summary>
    public partial class TurnRatingsListUserControl : UserControl
    {
        public TurnRatingsListUserControl()
        {
            InitializeComponent();
            DataGrid_TurnRatings.ItemsSource = database.find_TurnRatings_Patinent_all_active().ToList();
        }
        ClinicDBEntities database = new ClinicDBEntities();

        private void SearchMedicinebtn_Click(object sender, RoutedEventArgs e)
        {
            DataGrid_TurnRatings.ItemsSource = database.find_TurnRatings_Patinent_all_active().Where(c=>c.DoctorFamily==Nametxt.Text).ToList();

        }
    }
}
