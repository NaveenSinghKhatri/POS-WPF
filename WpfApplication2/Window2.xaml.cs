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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            
        }
       
        private void btnOk_Click(object sender, RoutedEventArgs e)

        {
            if (adminid.Text == "admin" && admin_password.Password =="password")
            {
                Window1 Adminwindow = new Window1();
                Adminwindow.Show();
                Adminwindow.lblGreeting.Content =  adminid.Text;
               this.Hide();

            }
            else
            {
                
                MessageBox.Show("Incorrect UserID or Password");
            }


        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow welcomeScreen = new MainWindow();
                welcomeScreen.Show();

        }

        private void admin_password_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void admin_password_TextInput(object sender, TextCompositionEventArgs e)
        {
           
        }

        private void btnOk_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnOk_Pressed(object sender, KeyEventArgs e)
        {
            
        }
    }
}
