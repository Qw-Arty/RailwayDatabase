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
    /// Логика взаимодействия для TrainsWindow.xaml
    /// </summary>
    public partial class TrainsWindow : Window
    {
        private Train _train = new Train();
        RailwayContext context = RailwayContext.GetContext();
        public TrainsWindow(Train selectTrain)
        {
            InitializeComponent();

            TrainsDataGrid.ItemsSource = context.Trains.ToList();
            if (selectTrain != null)
            {
                _train = selectTrain;
            }
            DataContext = _train;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
            this.Close();
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            Train item = TrainsDataGrid.SelectedItem as Train;
            if (item == null)
            {
                MessageBox.Show("Item not a data");
            }

            item.TrainType = TrainTypeBox.Text;
            item.TrainName = TrainNameBox.Text;

            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(item.TrainName))
            {
                errors.AppendLine("Укажите название поезда");
            }
            if (string.IsNullOrWhiteSpace(item.TrainType))
            {
                errors.AppendLine("Укажите тип поезда");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (item.TrainId == 0)
            {
                RailwayContext.GetContext().Trains.Add(item);
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
            TrainsDataGrid.Items.Refresh();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            Train train = new Train();
            string type = TrainTypeBox.Text;
            string name = TrainNameBox.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                errors.AppendLine("Укажите название поезда");
            }
            if (string.IsNullOrWhiteSpace(type))
            {
                errors.AppendLine("Укажите тип поезда");
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            train.TrainName = name;
            train.TrainType = type;

            try
            {
                RailwayContext.GetContext().Trains.Add(train);
                RailwayContext.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            TrainsDataGrid.Items.Refresh();
            TrainsDataGrid.ItemsSource = context.Trains.ToList();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Train item = TrainsDataGrid.SelectedItem as Train;
            if (item != null)
            {
                var TrainForRemoving = TrainsDataGrid.SelectedItems.Cast<Train>().ToList();
                RailwayContext.GetContext().Trains.RemoveRange(TrainForRemoving);
                RailwayContext.GetContext().SaveChanges();
            }
            else
            {
                MessageBox.Show("Выберите элемент таблицы");
            }
            RailwayContext context = RailwayContext.GetContext();
            TrainsDataGrid.ItemsSource = context.Trains.ToList();
        }

        private void TrainsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Train item = TrainsDataGrid.SelectedItem as Train;
            if (item != null)
            {
                _train = item;
                TrainTypeBox.Text = _train.TrainType;
                TrainNameBox.Text = _train.TrainName; 
            }
        }
    }
}
