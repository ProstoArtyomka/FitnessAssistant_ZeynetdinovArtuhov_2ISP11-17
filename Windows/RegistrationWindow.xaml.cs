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
        DataBase.User userAuth = new DataBase.User();
        bool isEdit = true;

        public RegistrationWindow()
        {
            InitializeComponent();

            cmbGender.ItemsSource = AppData.Context.Gender.ToList();
            cmbGender.DisplayMemberPath = "NameGender";
            cmbGender.SelectedItem = 0;

            isEdit = false;
        }

        public RegistrationWindow(DataBase.User user)
        {
            InitializeComponent();

            cmbGender.ItemsSource = AppData.Context.Gender.ToList();
            cmbGender.DisplayMemberPath = "NameGender";

            tbTitle.Text = "Изменения данных пользователя";
            tbTitle2.Text = " ";
            btnRegistration.Content = "Изменить";

            userAuth = user;

            txtLastName.Text = userAuth.LastName;
            txtFirstName.Text = userAuth.FirstName;
            txtBirthday.Text = Convert.ToString(userAuth.Birthday);
            txtWeight.Text = Convert.ToString(userAuth.Weight);
            txtHeight.Text = Convert.ToString(userAuth.Height);
            cmbGender.SelectedIndex = userAuth.IDGender - 1;
            txtLogin.Text = userAuth.Login;
            txtPassword.Text = userAuth.Password;

            isEdit = true;

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

            if (isEdit)
            {
                try
                {
                    //Изменение данных Клиента
                    userAuth.LastName = txtLastName.Text;
                    userAuth.FirstName = txtFirstName.Text;
                    userAuth.Login = txtLogin.Text;
                    userAuth.Password = txtPassword.Text;
                    userAuth.Weight = Convert.ToDouble(txtWeight.Text);
                    userAuth.Height = Convert.ToDouble(txtHeight.Text);
                    userAuth.IDGender = cmbGender.SelectedIndex + 1;
                    userAuth.Birthday = Convert.ToDateTime(txtBirthday.Text);

                    AppData.Context.SaveChanges();
                    MessageBox.Show("Успех", "Данные пользователя изменены", MessageBoxButton.OK, MessageBoxImage.Information);

                    userAuth = AppData.Context.User.ToList().
                    Where(i => i.Login == txtLogin.Text && i.Password == txtPassword.Text).
                    FirstOrDefault();

                    UserInfoWindow openwindow = new UserInfoWindow(userAuth);
                    openwindow.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                try
                {
                    var resultClick = MessageBox.Show("Вы уверены?", "Подтвердите добавление пользователя", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (resultClick == MessageBoxResult.Yes)
                    {
                        //Добавление нового клиента
                        DataBase.User newUser = new DataBase.User();
                        newUser.LastName = txtLastName.Text;
                        newUser.FirstName = txtFirstName.Text;
                        newUser.Birthday = Convert.ToDateTime(txtBirthday.Text);
                        newUser.Weight = Convert.ToDouble(txtWeight.Text);
                        newUser.Height = Convert.ToDouble(txtHeight.Text);
                        newUser.IDGender = cmbGender.SelectedIndex + 1;
                        newUser.Login = txtLogin.Text;
                        newUser.Password = txtPassword.Text;

                        AppData.Context.User.Add(newUser);
                        AppData.Context.SaveChanges();

                        MessageBox.Show("Успех", "Пользователь успешно добавлен", MessageBoxButton.OK, MessageBoxImage.Information);

                        MainWindow openwindow = new MainWindow();
                        openwindow.Show();
                        this.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }  
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