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

namespace Wpf_Palashicheva_PR6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string adminu = "Admin";
        string adminp = "Admin";

        string useru = "User";
        string userp = "User";


        private void Username_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(UsernamePodsk.Text))
            {
                UsernamePodsk.Text = "";
            }
        }
        private void Username_MouseLeave(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Username.Text))
            {
                UsernamePodsk.Text = "Username";
            }
        }

        private void Password_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(PasswordPodsk.Text))
            {
                PasswordPodsk.Text = "";
            }
        }

        private void Password_MouseLeave(object sender, MouseEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(PasswordPodsk.Text))
            {
                PasswordPodsk.Text = "Password";
            }
        }

        private void Log_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
