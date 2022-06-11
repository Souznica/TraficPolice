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

namespace TraficPolice
{
    /// <summary>
    /// Логика взаимодействия для Cars.xaml
    /// </summary>
    public partial class Cars : Page
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void cmb_mark_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RefreshData();
        }

        private void txt_search_TextChanged(object sender, TextChangedEventArgs e)
        {
            RefreshData();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            TrafficPoliceEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(entry => entry.Reload());
            CarsList.ItemsSource = TrafficPoliceEntities.GetContext().Car.ToList();
            var markList = TrafficPoliceEntities.GetContext().Car.ToList();
            markList.Insert(0, new Car() { mark = "Все" });
            cmb_mark.ItemsSource = markList;
        }
        public void RefreshData()
        {
            var list = TrafficPoliceEntities.GetContext().Car.ToList();
            if (cmb_mark.SelectedIndex > 0)
            {
                Car car = cmb_mark.SelectedItem as Car;
                list = list.Where(x=> x.mark == car.mark).ToList();
            }
            if(!string.IsNullOrWhiteSpace(txt_search.Text))
            {
                list = list.Where(x => x.StateNumber.ToLower().Contains(txt_search.Text.ToLower())).ToList();
            }
            CarsList.ItemsSource = list;
        }
    }
}
