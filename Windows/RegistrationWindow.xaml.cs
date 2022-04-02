using FitnessAssistant_ZeynetdinovArtuhov_2ISP11_17.Classes;
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

            cmbGender.ItemsSource = AppData.Context.Gender.ToList();
            cmbGender.DisplayMemberPath = "NameGender";
            cmbGender.SelectedItem = 0;
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            // Проверка на пустоту 

            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Поле Логин не может быть пустым");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Поле Пароль не может быть пустым");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Поле Фамилия не может быть пустым");
                return;
            }


            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Поле Имя не может быть пустым");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHeight.Text))
            {
                MessageBox.Show("Поле Рост не может быть пустым");
                return;
            }


            if (string.IsNullOrWhiteSpace(txtWeight.Text))
            {
                MessageBox.Show("Поле Вес не может быть пустым");
                return;
            }


            // Проверка на значение

            int val;

            if (!Int32.TryParse(txtHeight.Text, out val))
            {
                MessageBox.Show("Введены недопустимые значения в поле Рост \nВведите число!");
                return;
            }

            if (!Int32.TryParse(txtWeight.Text, out val))
            {
                MessageBox.Show("Введены недопустимые значения в поле Вес \nВведите число!");
                return;

            }

            DataBase.User newUser = new DataBase.User();
            newUser.LastName = txtLastName.Text;
            newUser.FirstName = txtFirstName.Text;
            newUser.Birthday = Convert.ToDateTime(txtBirthday.Text);
            newUser.Weight = Convert.ToDouble(txtWeight.Text);
            newUser.Height = Convert.ToDouble(txtHeight.Text);
            newUser.IDGender = cmbGender.SelectedIndex + 1;
            newUser.Login = txtLogin.Text;
            newUser.Password = txtPassword.Text;
            //newUser.Age = DateTime.Now - Convert.ToDateTime(txtBirthday.Text);

            AppData.Context.User.Add(newUser);
            AppData.Context.SaveChanges();

            MessageBox.Show("Успех", "Пользователь успешно добавлен", MessageBoxButton.OK, MessageBoxImage.Information);
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