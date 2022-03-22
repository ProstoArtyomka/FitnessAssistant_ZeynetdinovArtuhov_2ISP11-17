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

namespace FitnessAssistant_ZeynetdinovArtuhov_2ISP11_17
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

        private void Login_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Authorization_Click(object sender, RoutedEventArgs e)
        {
                // Проверка на пустоту 


                if (string.IsNullOrWhiteSpace(Login.Text))
                {
                    MessageBox.Show("Поле Логин не может быть пустым");
                    return;
                }




                if (string.IsNullOrWhiteSpace(Password.Text))
                {
                    MessageBox.Show("Поле Пароль не может быть пустым");
                    return;
                }

                        UserInfoWindow openwindow = new UserInfoWindow();
                        openwindow.Show();
                        this.Close();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow openwindow = new RegistrationWindow();
            openwindow.Show();
            this.Close();
        }
    }
}

