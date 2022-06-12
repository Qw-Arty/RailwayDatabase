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
using railwayDatabase.dataModel;
using railwayDatabase.Windiws;

namespace railwayDatabase
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RailwayContext context = RailwayContext.GetContext();
        public MainWindow()
        {
            InitializeComponent();
            StartStationBox.ItemsSource = context.Stations.ToList();
            EndStationBox.ItemsSource = context.Stations.ToList();


            //Route newRoute = context.Routes.ToList().Find(r => r.RouteId == 5);
            //Train newTrain = context.Trains.ToList().Find(r => r.TrainId == 5);
            //newRoute.TrainsCollection.Add(newTrain);
            //context.SaveChanges();


            //RailwayContext.GetContext().Stations.Add(new Station() { StationName = "aboba", StationLocality = "abobinsk" });
            //RailwayContext.GetContext().SaveChanges();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            Station StartStationObject = null;
            Station EndStationObject = null;

            try
            {
                StartStationObject = StartStationBox.SelectedItem as Station;
                EndStationObject = EndStationBox.SelectedItem as Station;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            if (StartStationObject != null && EndStationObject != null)
            {
                List<PairsOfStations> StartStationsCandidate = context.PairsOfStationses.Where(a => a.StartingStationId == StartStationObject.StationId).ToList();
                List<PairsOfStations> EndStationsCandidate = context.PairsOfStationses.Where(a => a.EndStationId == EndStationObject.StationId).ToList();
                List<Route> SearchedRoutes = new List<Route>();
                foreach (var StartStation in StartStationsCandidate)
                {
                    foreach (var EndStation in EndStationsCandidate)
                    {
                        if (StartStation.RouteId == EndStation.RouteId)
                        {
                            SearchedRoutes.Add(StartStation.Route);
                        }
                    }
                }
                if (SearchedRoutes.Count() == 0)
                {
                    MessageBox.Show("Маршрут не найден");
                }
                else
                {   
                    SearchWindow searchWindow = new SearchWindow(SearchedRoutes.First());
                    searchWindow.Show();
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите маршрут");
            }
        }

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
            this.Close();
        }

        private void ProgramInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ABOBA");
            MessageBox.Show("Backend разработчик - Портных Артем, Frontend разработчик - Портных Артем, Портных Артем в фильме Портных Артем, а Райан Гослинг в фильме Драйв");
        }
    }
}
