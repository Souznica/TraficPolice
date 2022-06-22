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

namespace TraficPolice
{
    /// <summary>
    /// Логика взаимодействия для MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        Driver driver1;
        public MainWindow2()
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame;
        }
        public MainWindow2(bool i)
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame;
            if (i == false)
            {
                BtnCar.Visibility = Visibility.Hidden;
                BntDriver.Visibility = Visibility.Hidden;
                BtnHistory.Visibility = Visibility.Visible;
                BtnPenalty.Visibility = Visibility.Visible;
            }
            if (i == true)
            {
                BtnCar.Visibility = Visibility.Visible;
                BntDriver.Visibility = Visibility.Visible;
                BtnHistory.Visibility = Visibility.Hidden;
                BtnPenalty.Visibility = Visibility.Hidden;
            }
        } // Конструктор выбора загрузки отображения
        public MainWindow2(bool i, Driver driver)
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame;
            if (i == false)
            {
                BtnCar.Visibility = Visibility.Hidden;
                BntDriver.Visibility = Visibility.Hidden;
                BtnHistory.Visibility = Visibility.Visible;
                BtnPenalty.Visibility = Visibility.Visible;
                driver1 = driver;
            }
            if (i == true)
            {
                BtnCar.Visibility = Visibility.Visible;
                BntDriver.Visibility = Visibility.Visible;
                BtnHistory.Visibility = Visibility.Hidden;
                BtnPenalty.Visibility = Visibility.Hidden;
            }
        } // Конструктор выбора загрузки отображения c принятием в себя данных водителя

        private void BtnViolation_Click(object sender, RoutedEventArgs e)   
        {
            Manager.MainFrame.Navigate(new Violations());

        } // Показать страницу про Нарушения

        private void BntDriver_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Drivers());

        } // Показать страницу про Водителей

        private void BtnCar_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Cars());

        } // Показать страницу про Автомобили

        private void BtnGoback_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.GoBack();
        } // Возвращение на предыдущую страницу

        private void Frame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                BtnGoback.Visibility = Visibility.Visible;
            }
            else BtnGoback.Visibility = Visibility.Hidden;
        } // Проверка возможности вернуться на предыдущую страницу

        private void BtnHistory_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MyCarHistory(driver1));
        } // Открытие страницы истории ТС данного пользователя

        private void BtnPenalty_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MyPenalty(driver1));
        } // Открытие страницы штрафов данного пользователя
    }
}
