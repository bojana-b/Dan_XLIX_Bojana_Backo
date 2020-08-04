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

namespace Dan_XLIX_Bojana_Backo.View
{
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
            OwnerAccess.AddToFile();
            //MessageBox.Show("upisano u file");
        }
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            var hash = SecurePasswordHasher.Hash("Vlasnik2020");
            try
            {
                if (txtUsername.Text.Equals("Vlasnik2020") && SecurePasswordHasher.Verify(txtPassword.Password, hash))
                {
                    OwnerWindow dashboard = new OwnerWindow();
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //sqlCon.Close();
            }
        }
    }
}
