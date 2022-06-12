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
    /// Логика взаимодействия для RailwagCarriageWindow.xaml
    /// </summary>
    public partial class RailwagCarriageWindow : Window
    {
        private RailwayCarriage _railwayCarriage = new RailwayCarriage();
        RailwayContext context = RailwayContext.GetContext();
        public RailwagCarriageWindow(RailwayCarriage selectRailwayCarriage)
        {
            InitializeComponent();

            TrainIdBox.ItemsSource = context.Trains.ToList();

            RailwagCarriageGrid.ItemsSource = context.RailwayCarriages.ToList();
            if (selectRailwayCarriage != null)
            {
                _railwayCarriage = selectRailwayCarriage;
            }
            DataContext = _railwayCarriage;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            RailwayCarriage item = RailwagCarriageGrid.SelectedItem as RailwayCarriage;
            if (item != null)
            {
                var RailwayCarriageForRemoving = RailwagCarriageGrid.SelectedItems.Cast<RailwayCarriage>().ToList();
                RailwayContext.GetContext().RailwayCarriages.RemoveRange(RailwayCarriageForRemoving);
                RailwayContext.GetContext().SaveChanges();
            }
            else
            {
                MessageBox.Show("Выберите элемент таблицы");
            }
            RailwayContext context = RailwayContext.GetContext();
            RailwagCarriageGrid.ItemsSource = context.RailwayCarriages.ToList();
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            RailwayCarriage item = RailwagCarriageGrid.SelectedItem as RailwayCarriage;
            if (item == null)
            {
                MessageBox.Show("Item not a data");
            }

            item.TrainId = TrainIdBox.SelectedIndex;
            

            StringBuilder errors = new StringBuilder();

            if (item.TrainId < 0)
            {
                errors.AppendLine("Укажите название поезда");
            }
            if ( item.RailwayCarriageRoom < 0)
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
                RailwayContext.GetContext().RailwayCarriages.Add(item);
            }

            try
            {
                item.RailwayCarriageRoom = int.Parse(RoomBox.Text);
                RailwayContext.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            RailwagCarriageGrid.Items.Refresh();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            RailwayCarriage railwayCarriage = new RailwayCarriage();

            int room = 0;
            int trainId = int.Parse(TrainIdBox.Text);
            

            if ( trainId < 0)
            {
                errors.AppendLine("Укажите название поезда");
            }
            

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            try
            {
                room = int.Parse(RoomBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            if (room < 0)
            {
                errors.AppendLine("Укажите тип поезда");
            }

            railwayCarriage.TrainId = trainId;
            railwayCarriage.RailwayCarriageRoom = room;

            try
            {
                RailwayContext.GetContext().RailwayCarriages.Add(railwayCarriage);
                RailwayContext.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
            

            RailwagCarriageGrid.Items.Refresh();
            RailwagCarriageGrid.ItemsSource = context.RailwayCarriages.ToList();
        }

        private void RailwagCarriageGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RailwayCarriage item = RailwagCarriageGrid.SelectedItem as RailwayCarriage;
            if (item != null)
            {
                _railwayCarriage = item;
                RoomBox.Text = _railwayCarriage.RailwayCarriageRoom.ToString();
            }
        }
    }
}
