using railwayDatabase.dataModel;
using railwayDatabase.Windiws;
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

namespace railwayDatabase.Windows
{
    /// <summary>
    /// Логика взаимодействия для ByPlacesWindow.xaml
    /// </summary>
    public partial class ByPlacesWindow : Window
    {
        RailwayContext context = RailwayContext.GetContext();
        private Route _route = new Route();
        private Train _train = new Train();
        private Place _place = new Place();
        public ByPlacesWindow(Train byTrain, Route byRoute)
        {
            InitializeComponent();

            List<RailwayCarriage> railwayCarriages = byTrain.RailwayCarriages.ToList();
            RailwayCarriageBox.ItemsSource = railwayCarriages;
            this._route = byRoute;
            //List<Train> trains = ByPlace.TrainsCollection.ToList();
            //_route = ByPlace;
            //MessageBox.Show($"{ByPlace.TrainsCollection.First().TrainName}");
            //List<TrainRoute> trainRoutes = context.TrainRoutes.Where(tr => tr.RouteId == ByPlace.RouteId).ToList();
            //List<Train> trains = context.Trains.Where(t => t.TrainId == trainRoutes)
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            SearchWindow searchWindow = new SearchWindow(_route);
            searchWindow.Show();
            this.Close();
        }

        private void InfoButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RailwayCarriageBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RailwayCarriage railwayCarriage = RailwayCarriageBox.SelectedItem as RailwayCarriage;
            PlaceNumberBox.ItemsSource = railwayCarriage.Places.ToList().Where(p => p.PlaceAvail == false);
        }

        private void PlaceNumberBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Place place = PlaceNumberBox.SelectedItem as Place;
            if (place != null)
            {
                LocationPlaceBox.Text = place.PlaceLocation.ToString();
                TypePlaceBox.Text = place.PlaceType.ToString();
                PricePlaceBox.Text = ($"{place.PlacePrice.ToString()} р");
            }
        }

        private void ByPlaceButton_Click(object sender, RoutedEventArgs e)
        {
            _place = PlaceNumberBox.SelectedItem as Place;
            _place.PlaceAvail = true;
            MessageBox.Show($"Место {_place.PlaceId} куплено)))");
            context.SaveChanges();
        }
    }
}
