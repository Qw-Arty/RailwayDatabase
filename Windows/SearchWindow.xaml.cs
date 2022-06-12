using railwayDatabase.dataModel;
using railwayDatabase.Windows;
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

namespace railwayDatabase.Windiws
{
    /// <summary>
    /// Логика взаимодействия для SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        RailwayContext context = RailwayContext.GetContext();
        private Station _station = new Station();
        private Train _train = new Train();
        private Route _route = new Route();
        public SearchWindow(Route SearchRoute)
        {
            InitializeComponent();
            //MessageBox.Show($"{SearchRoute.RouteName}");
            //SearchRoute.PairsOfStations
            RouteNameBox.Text = ($"Глобальный маршрут: {SearchRoute.RouteName}");
            StartTmeBox.Text = ($"Старт поездки {SearchRoute.DepartureTimeGlobal}");
            EndTimeBox.Text = ($"Конец поездки {SearchRoute.ArrivalTimeGlobale}");
            TrainList.ItemsSource = SearchRoute.TrainsCollection;
            _route = SearchRoute;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            _train = TrainList.SelectedItem as Train;
            ByPlacesWindow byPlacesWindow = new ByPlacesWindow(_train, _route);
            byPlacesWindow.Show();
            this.Close();
        }
    }
}
