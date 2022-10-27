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





        private void Log_Click(object sender, RoutedEventArgs e)
        {
            if (Username.Text == "" && Password.Text == "")
            {
                MessageBox.Show("Enter username!\nEnter password!", "Infromation");

            }
            else if (Username.Text == "")
            {
                MessageBox.Show("Enter username!", "Infromation");

            }
            else if (Password.Text == "")
            {
                MessageBox.Show("Enter password!", "Infromation");

            }
            else if (Username.Text != adminu && Username.Text != useru)
            {
                MessageBox.Show("User is not found!", "Infromation");

            }
            else if (Username.Text == adminu && Password.Text != adminp || Username.Text == useru && Password.Text != userp)
            {
                MessageBox.Show("Password incorrect!", "Infromation");
            }
            else if (Username.Text == adminu && Password.Text == adminp || Username.Text == useru && Password.Text == userp)
            {
                
            }

        }

        private void Username_TextChanged(object sender, TextChangedEventArgs e)
        {
            UsernamePodsk.Text = "";

            if (Username.Text == "" )
                {
                UsernamePodsk.Text = "Username";
                }
        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {
            PasswordPodsk.Text = "";

            if (Password.Text == "")
            {
                PasswordPodsk.Text = "Username";
            }
        }
    }
}
