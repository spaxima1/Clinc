﻿using System;
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

    }
}
