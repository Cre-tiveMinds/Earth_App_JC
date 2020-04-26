using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Earth_App_JC
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LogIn : Page
    {
        public LogIn()
        {
            this.InitializeComponent();
        }

        private void btnFacebook_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnGoogle_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Password;

                Match numericMatch = Regex.Match(pass, @".*[0-9]+.*[0-9]+.*");

                getCredentials(user, pass);

                if (txtPassword.Password == "")
                {
                    lblError.Text = "Password cannot be empty";
                }
                else if (txtUsername.Text == "")
                {
                    lblError.Text = "Username cannot be blank";
                }
                //else if (txtPassword.Password != user.password)
                //{
                //    lblError.Text = "Invalid password";
                //}
                else
                {
                    Frame.Navigate(typeof(Index));
                }
        }

        private void lnkForgotCredentials_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cbxLogdIn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
