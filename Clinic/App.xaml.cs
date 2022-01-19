using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Clinic;
namespace Clinic
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow w_n = new MainWindow();
            w_n.ShowDialog();

            Clerk clerk_Win= new Clerk(w_n.id);
            clerk_Win.ShowDialog();

        }
    }
}
