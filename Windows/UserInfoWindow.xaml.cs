using FitnessAssistant_ZeynetdinovArtuhov_2ISP11_17.Classes;
using FitnessAssistant_ZeynetdinovArtuhov_2ISP11_17.DataBase;
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

namespace FitnessAssistant_ZeynetdinovArtuhov_2ISP11_17
{
    /// <summary>
    /// Логика взаимодействия для UserInfoWindow.xaml
    /// </summary>
    public partial class UserInfoWindow : Window
    {

        DataBase.User editUser = new DataBase.User();
        public UserInfoWindow()
        {
            InitializeComponent();

            txtWelcomeUser.Text = "Добро пожаловать, " + editUser.FirstName + "!";
            txtWeightClient.Text = Convert.ToString(editUser.Weight);
            txtHeightClient.Text = Convert.ToString(editUser.Height);
            txtAgeClient.Text = Convert.ToString(editUser.Age);
            double BMI = editUser.Weight / (editUser.Height * editUser.Height);

            if (editUser.IDGender == 1)
            {
                double BMRMan = Convert.ToDouble(66 + (13.7 + editUser.Weight) + (5 + (editUser.Height / 100)) - (6.8 + editUser.Age));
                txtBMRClient.Text = Convert.ToString(BMRMan) + " ккал / день";
            }
            else
            {
                double BMRWoman = Convert.ToDouble(655 + (9.8 + editUser.Weight) + (1.8 + (editUser.Height / 100)) - (4.7 + editUser.Age));
                txtBMRClient.Text = Convert.ToString(BMRWoman) + " ккал / день";
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow openwindow = new MainWindow();
            openwindow.Show();
            this.Close();
        }
    }
}
