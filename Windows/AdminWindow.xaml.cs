using railwayDatabase.Windiws;
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

namespace railwayDatabase
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void TrainButton_Click(object sender, RoutedEventArgs e)
        {
            TrainsWindow trainsWindow = new TrainsWindow(null);
            trainsWindow.Show();
            this.Close();
        }

        private void PlaceButton_Click(object sender, RoutedEventArgs e)
        {
            PlaceWindow1 placeWindow = new PlaceWindow1(null);
            placeWindow.Show();
            this.Close();
        }

        private void RoalwagCarriageButton_Click(object sender, RoutedEventArgs e)
        {
            RailwagCarriageWindow railwagCarriageWindow = new RailwagCarriageWindow(null);
            railwagCarriageWindow.Show();
            this.Close();
        }
    }
}
