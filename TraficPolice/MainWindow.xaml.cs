﻿using System;
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

namespace TraficPolice
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TrafficPoliceEntities trafficPoliceEntities;
        int count = 0;
        public MainWindow()
        {
            InitializeComponent();
            trafficPoliceEntities = new TrafficPoliceEntities();
            Btn_Enter.IsEnabled = false;
        }
        private void Btn_Enter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int login = Convert.ToInt32(txt_login.Text);
                string password = txt_password.Text;

                Inspector inspector = trafficPoliceEntities.Inspector.ToList().Find(x => x.tabNum == login);
                if (inspector == null)
                {
                    MessageBox.Show("Данного пользователя не существует", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                    count++;
                }
                else
                {
                    if (inspector.password.Equals(password)) // Успешная авторизация
                    {   
                        MainWindow2 window2 = new MainWindow2();
                        window2.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Пароли не совпадают", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                        count++;
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный логин!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                count++;
            }
            catch
            {
                MessageBox.Show("Ошибка!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (count >= 3)
            {
                Btn_Enter.IsEnabled = false;
                txt_login.IsEnabled = false;
                txt_password.IsEnabled = false;
            }
        }

        private void txt_login_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txt_login.Text.Length > 0 && txt_password.Text.Length > 0)
            {
                Btn_Enter.IsEnabled = true;
            }
            else
                Btn_Enter.IsEnabled = false;
        }
    }
}
