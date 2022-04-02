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
        DataBase.User userAuth = new DataBase.User();

        public UserInfoWindow()
        {
            InitializeComponent();
        }

        public UserInfoWindow(DataBase.User user)
        {
            InitializeComponent();

            userAuth = user;

            txtWelcomeUser.Text = "Добро пожаловать, " + userAuth.FirstName + "!";
            txtWeightClient.Text = Convert.ToString(userAuth.Weight);
            txtHeightClient.Text = Convert.ToString(userAuth.Height);
            txtAgeClient.Text = Convert.ToString(userAuth.Age);
            double BMI = userAuth.Weight / ((userAuth.Height/100) * (userAuth.Height/100));
            if (BMI < 16)
            {
                txtBMIClient.Text = BMI + " Значительный дефицит массы тела";
            }
            else if (16 <= BMI && BMI < 18.5)
            {
                txtBMIClient.Text = BMI + " Недостаток массы тела";
            }
            else if (18.5 <= BMI && BMI < 25)
            {
                txtBMIClient.Text = BMI + " Нормальный вес тела";
            }
            else if (25 <= BMI && BMI < 30)
            {
                txtBMIClient.Text = BMI + " Излишек массы тела";
            }
            else if (30 <= BMI && BMI < 35)
            {
                txtBMIClient.Text = BMI + " Начальная степень ожирения";
            }
            else if (35 <= BMI && BMI < 40)
            {
                txtBMIClient.Text = BMI + " Средняя степень ожирения";
            }
            else if (BMI >= 40)
            {
                txtBMIClient.Text = BMI + " Высокая степень ожирения";
            }

            if (userAuth.IDGender == 1)
            {
                double BMRMan = Convert.ToDouble(66 + (13.7 + userAuth.Weight) + (5 + (userAuth.Height / 100)) - (6.8 + userAuth.Age));
                txtBMRClient.Text = Convert.ToString(BMRMan) + " ккал / день";
            }
            else if(userAuth.IDGender == 2)
            {
                double BMRWoman = Convert.ToDouble(655 + (9.8 + userAuth.Weight) + (1.8 + (userAuth.Height / 100)) - (4.7 + userAuth.Age));
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
