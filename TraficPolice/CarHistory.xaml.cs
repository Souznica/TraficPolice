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
    /// Логика взаимодействия для CarHistory.xaml
    /// </summary>
    public partial class CarHistory : Page
    {
        public CarHistory(DriversCars driversCars)
        {
            InitializeComponent();
            //if(driversCars != null)
            //    _current = driversCars;
            //DataContext = _current;
            var list = TrafficPoliceEntities.GetContext().DriversCars.Select(p => new
            {
                idCar1 = p.idCar,
                Name = p.Driver.name,
                Date1 = p.dateStartDrive,
                Date2 = p.dateEndDrive
            }).ToList().Where(x => x.Date2 != null);
            CarList.ItemsSource = list;
        }
    }
}
