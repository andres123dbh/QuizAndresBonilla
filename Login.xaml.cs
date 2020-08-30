using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuizAndresBonilla
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(txtUsername.Text == "andres" && txtPassword.Password == "220402")
            {
                MainWindow w = (MainWindow) Window.GetWindow(this);
                w.frameMain.NavigationService.Navigate(new Home());
            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
        }
    }
}
