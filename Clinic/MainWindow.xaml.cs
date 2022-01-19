using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UserNameTxt.Focus();
          
           
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        public int id;
        ClinicDBEntities database = new ClinicDBEntities();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var clrek = database.find_Clerk(UserNameTxt.Text, UserPasswordtxt.Password).First();
                id = clrek.ClerkID;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("اطلاعات وارد شده درست نمی باشد لطفا دقت  کنید !!", "", MessageBoxButton.OK, MessageBoxImage.Warning);
                UserNameTxt.Text = "";
                UserPasswordtxt.Password = "";
                UserNameTxt.Focus();

            }



        }

        private void UserNameTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter&&UserNameTxt.Text!="")
                UserPasswordtxt.Focus();
        }

        private void UserPasswordtxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter&&UserPasswordtxt.Password!="")
                Button_Click(Loginbtn, new RoutedEventArgs());
        }

        private void Exitbtn_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);

        }
    }
}
