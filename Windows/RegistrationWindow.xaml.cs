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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
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

            if (string.IsNullOrWhiteSpace(LastName.Text))
            {
                MessageBox.Show("Поле Фамилия не может быть пустым");
                return;
            }


            if (string.IsNullOrWhiteSpace(FirstName.Text))
            {
                MessageBox.Show("Поле Имя не может быть пустым");
                return;
            }

            if (string.IsNullOrWhiteSpace(Height.Text))
            {
                MessageBox.Show("Поле Рост не может быть пустым");
                return;
            }


            if (string.IsNullOrWhiteSpace(Weight.Text))
            {
                MessageBox.Show("Поле Вес не может быть пустым");
                return;
            }


            // Проверка на значение

            int val;

            if (!Int32.TryParse(DateOfBirth.Text, out val))
            {
                MessageBox.Show("Введены недопустимые значения в поле Возраст");
                return;
            }


            if (!Int32.TryParse(Height.Text, out val))
            {
                MessageBox.Show("Введены недопустимые значения в поле Рост \nВведите число!");
                return;
            }

            if (!Int32.TryParse(Weight.Text, out val))
            {
                MessageBox.Show("Введены недопустимые значения в поле Вес \nВведите число!");
                return;

            }



            MainWindow openwindow = new MainWindow();
            openwindow.Show();
            this.Close();



        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow openwindow = new MainWindow();
            openwindow.Show();
            this.Close();
        }

        private void Gender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }
    }

}