using railwayDatabase.dataModel;
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
    /// Логика взаимодействия для PlaceWindow1.xaml
    /// </summary>
    public partial class PlaceWindow1 : Window
    {
        private Place _place = new Place();
        RailwayContext context = RailwayContext.GetContext();
        public PlaceWindow1(Place selectPlace)
        {
            InitializeComponent();
            RailwayCarriageIdBox.ItemsSource = context.RailwayCarriages.ToList();
            PlaceGrid.ItemsSource = context.Places.ToList();
            if (selectPlace != null)
            {
                _place = selectPlace;
            }
            DataContext = _place;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Place item = PlaceGrid.SelectedItem as Place;
            if (item != null)
            {
                var PlaceForRemoving = PlaceGrid.SelectedItems.Cast<Place>().ToList();
                RailwayContext.GetContext().Places.RemoveRange(PlaceForRemoving);
                RailwayContext.GetContext().SaveChanges();
            }
            else
            {
                MessageBox.Show("Выберите элемент таблицы");
            }
            RailwayContext context = RailwayContext.GetContext();
            PlaceGrid.ItemsSource = context.Places.ToList();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
            this.Close();
        }

        private void CahngeButton_Click(object sender, RoutedEventArgs e)
        {
            Place item = PlaceGrid.SelectedItem as Place;
            if (item == null)
            {
                MessageBox.Show("Item not a data");
            }
            RailwayCarriage railwayCarriage = RailwayCarriageIdBox.SelectedItem as RailwayCarriage;
            item.RailwayCarriageId = railwayCarriage.RailwayCarriageId;
            item.PlaceLocation = PlaceLocationBox.Text;
            item.PlaceType = PlaceTypeBox.Text;
            //item.PlacePrice = double.Parse(PlacePriceBox.Text);
            //item.PlaceAvail = bool.Parse(PlaceAvailBox.Text);
            try
            {
                item.PlacePrice = double.Parse(PlacePriceBox.Text);
                item.PlaceAvail = bool.Parse(PlaceAvailBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            StringBuilder errors = new StringBuilder();

            if (item.RailwayCarriageId < 0)
            {
                errors.AppendLine("Укажите ID вагона");
            }
            if (item.PlaceLocation == null)
            {
                errors.AppendLine("Укажите расположение места");
            }
            if (item.PlaceType == null)
            {
                errors.AppendLine("Укажите тип места");
            }
            if (item.PlacePrice == 0)
            {
                errors.AppendLine("Бесплатно!? Ладно...");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (item.PlaceId == 0)
            {
                RailwayContext.GetContext().Places.Add(item);
            }

            try
            {
                RailwayContext.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            PlaceGrid.Items.Refresh();
        }


        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            Place place = new Place();

            RailwayCarriage railwayCarriageId = RailwayCarriageIdBox.SelectedItem as RailwayCarriage;
            string placeLocation = PlaceLocationBox.Text;
            string placeType = PlaceTypeBox.Text;
            double placePrice = 0;
            bool placeAvail = false;

            if (railwayCarriageId == null)
            {
                errors.AppendLine("Укажите ID вагона");
            }

            if (placeLocation == null)
            {
                errors.AppendLine("Укажите расположение места");
            }

            if (placeType == null)
            {
                errors.AppendLine("Укажите тип места");
            }

            

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            try
            {
                placePrice = double.Parse(PlacePriceBox.Text);
                placeAvail = bool.Parse(PlaceAvailBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            if (placePrice == 0)
            {
                MessageBox.Show("Бесплатно!? Дайте два!");
            }

            place.RailwayCarriageId = railwayCarriageId.RailwayCarriageId;
            place.PlaceLocation = placeLocation;
            place.PlaceType = placeType;
            place.PlacePrice = placePrice;
            place.PlaceAvail = placeAvail;

            RailwayContext.GetContext().Places.Add(place);
            RailwayContext.GetContext().SaveChanges();

            try
            {
                
                MessageBox.Show("Информация сохранена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }



            PlaceGrid.Items.Refresh();
            PlaceGrid.ItemsSource = context.Places.ToList();
        }

        private void PlaceGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Place item = PlaceGrid.SelectedItem as Place;
            if (item != null)
            {
                _place = item;
                PlaceLocationBox.Text = _place.PlaceLocation.ToString();
                PlaceTypeBox.Text = _place.PlaceType.ToString();
                PlacePriceBox.Text = _place.PlacePrice.ToString();
                PlaceAvailBox.Text = _place.PlaceAvail.ToString();
            }
        }
    }
}
