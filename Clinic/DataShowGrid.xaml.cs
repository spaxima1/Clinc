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
    /// Interaction logic for DataShowGrid.xaml
    /// </summary>
    public partial class DataShowGrid : UserControl
    {
        public DataShowGrid(string namemdicin,int count,long price)
        {
            InitializeComponent();
            NameMedicinetxt.Text = namemdicin;
            countMedicinetxt.Text = count.ToString();
            priceMedicnetxt.Text = price.ToString();


        }
    }
}
