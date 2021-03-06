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
using MaterialDesignThemes.Wpf;
using DataModelLayer;


namespace Clinic
{
    /// <summary>
    /// Interaction logic for Clerk.xaml
    /// </summary>
    public partial class Clerk : Window
    {
        public Clerk(int clerkId)
        {
            InitializeComponent();
            var infclerk = database.find_Clerk_byID(clerkId).First();
            clrckname.Text = infclerk.ClerkName + " " + infclerk.ClerkFamily;


        }
        ClinicDBEntities database = new ClinicDBEntities();

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }
        internal void SwitchScreen(object sender)
        {
            var screen = ((UserControl)sender);

            if (screen != null)
            {
                StackPanelMain.Children.Clear();
                StackPanelMain.Children.Add(screen);
            }
        }

        private void PatientRegistration_Click(object sender, RoutedEventArgs e)
        {
            StackPanelMain.Children.Clear();
            
            StackPanelMain.Children.Add(new UserControlRegister());
        }

        private void MedixinePatientbtn_Click(object sender, RoutedEventArgs e)
        {
            StackPanelMain.Children.Clear();

            StackPanelMain.Children.Add(new UserControlMedicine());
        }

        private void Patientsbtn_Click(object sender, RoutedEventArgs e)
        {
            StackPanelMain.Children.Clear();

            StackPanelMain.Children.Add(new ShowPatientsInformation());
        }

        private void TurnRatingsbtn_Click(object sender, RoutedEventArgs e)
        {
            StackPanelMain.Children.Clear();

            StackPanelMain.Children.Add(new TurnRatingsListUserControl());
        }
    }
}
