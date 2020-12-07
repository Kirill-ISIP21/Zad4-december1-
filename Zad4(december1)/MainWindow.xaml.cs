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

namespace Zad4_december1_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Bus bus1 = new Bus("Кизаров И.И.", 33, "Mazda", 1989, 3000);
            Bus bus2 = new Bus("Пупкин М.И.", 21, "Toyota", 2008, 4900);
            Bus bus3 = new Bus("Иванов В.Е.", 21, "Opel", 2010, 8400);
            Bus bus4 = new Bus("Понасенков Р.В.", 9, "Lexus", 2003, 12000);
            buses.Add(bus1);
            buses.Add(bus2);
            buses.Add(bus3);
            buses.Add(bus4);
            label1.Content = "Водитель \t Марш. \t Марка \t Год \t Пробег";
            foreach (Bus bus in buses)
            {
                label1.Content += "\n" + bus.GetInfo();
            }
        }

        List<Bus> buses = new List<Bus>();

        private void click(object sender, RoutedEventArgs e)
        {
            string listRoute = "";
            string listExp = "";
            string listProbeg = "";
            foreach (Bus bus in buses)
            {
                if (bus.busRouteNumber == Convert.ToInt32((txtBoxRoute.Text))) listRoute += "\n" + bus.GetInfo();
                if (Convert.ToInt32((DateTime.Now.Year.ToString())) - bus.busYear > Convert.ToInt32(txtBoxExp.Text)) listExp += "\n" + bus.GetInfo();
                if (bus.busProbeg >= Convert.ToInt32(txtBoxProbeg.Text)) listProbeg += "\n" + bus.GetInfo();
            }
            System.Windows.MessageBox.Show($"Автобусы, ездящие по {txtBoxRoute.Text} маршруту:\n {listRoute}\nАвтобусы в эксплуатации больше {Convert.ToInt32(txtBoxExp.Text)} лет:\n\n {listExp}\n\nАвтобусы, ездящие больше {Convert.ToInt32(txtBoxProbeg.Text)} км:\n {listProbeg}");
        }
    }
}
