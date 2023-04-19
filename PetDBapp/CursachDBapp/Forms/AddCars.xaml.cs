using CursachDBapp.Model;
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

namespace CursachDBapp.Forms
{
    public partial class AddCars : Window
    {
        private int CarFuelID { get; set; }
        private int CarBodyID { get; set; }
        private int CarColorID { get; set; }
        private string CarNames { get; set; }
        private string CarPerf { get; set; }
        private DateTime PresetDateTime { get; set; }
        public List<CarsList> cars = new List<CarsList>();
        public int CarID { get; set; }
        public AddCars()
        {
            DataContext = this;
            InitializeComponent();
            cars = CarsFromBD.LoadCars();
            ListViewCars.ItemsSource = cars;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            AddCarsBD.AddCar(CarFuelID, CarBodyID, CarColorID, CarNames, int.Parse(CarPerf), PresetDateTime);
            ComboBox1.SelectedIndex = 0;
            ComboBox2.SelectedIndex = 0;
            ComboBox3.SelectedIndex = 0;
            ComboBox4.SelectedIndex = 0;
            ComboBox5.SelectedIndex = 0;
            ListViewCars.ItemsSource = CarsFromBD.LoadCars();
        }

        private void ListViewCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CarsList selectedItem = (CarsList)ListViewCars.SelectedItem;
            if (selectedItem != null)
            {
                CarID = selectedItem.AutoID;
            }
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ComboBox1.SelectedItem == "Diesel")
            {
                CarFuelID = 1;
            }else if(ComboBox1.SelectedItem == "Gasoline")
            {
                CarFuelID = 2;
            }else if(ComboBox1.SelectedItem == "Electricity")
            {
                CarFuelID = 3;
            }
        }

        private void ComboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox2.SelectedItem == "Sedan")
            {
                CarBodyID = 1;
            }
            else if (ComboBox2.SelectedItem == "Coupe")
            {
                CarBodyID = 2;
            }
            else if (ComboBox2.SelectedItem == "Hatchback")
            {
                CarBodyID = 3;
            }
            else if (ComboBox2.SelectedItem == "Universal")
            {
                CarBodyID = 4;
            }
            else if (ComboBox2.SelectedItem == "Cabriolet")
            {
                CarBodyID = 5;
            }
            else if (ComboBox2.SelectedItem == "Liftback")
            {
                CarBodyID = 6;
            }
            else if (ComboBox2.SelectedItem == "Roadster")
            {
                CarBodyID = 7;
            }
        }

        private void ComboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox3.SelectedItem == "White")
            {
                CarColorID = 1;
            }
            else if (ComboBox3.SelectedItem == "Black")
            {
                CarColorID = 2;
            }
            else if (ComboBox3.SelectedItem == "Mixed")
            {
                CarColorID = 3;
            }
            else if (ComboBox3.SelectedItem == "Red")
            {
                CarColorID = 4;
            }
            else if (ComboBox3.SelectedItem == "Blue")
            {
                CarColorID = 5;
            }
            else if (ComboBox3.SelectedItem == "Purple")
            {
                CarColorID = 6;
            }
            else if (ComboBox3.SelectedItem == "Green")
            {
                CarColorID = 7;
            }
            else if (ComboBox3.SelectedItem == "Yellow")
            {
                CarColorID = 8;
            }
            else if (ComboBox3.SelectedItem == "Orange")
            {
                CarColorID = 9;
            }
        }

        private void PresetTime(object sender, SelectionChangedEventArgs e)
        {
            PresetDateTime = TimePicker1.SelectedDate.Value;
        }

        private void ComboBox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CarNames = ComboBox4.SelectedItem.ToString();
        }

        private void ComboBox5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CarPerf = ComboBox5.SelectedItem.ToString();
        }

        private void ComboBox1_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> fuels = new List<string>();
            fuels.Add("Diesel");
            fuels.Add("Gasoline");
            fuels.Add("Electricity");
            ComboBox1.ItemsSource = fuels;
            ComboBox1.SelectedIndex = 0;
        }

        private void ComboBox2_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> body = new List<string>();
            body.Add("Sedan");
            body.Add("Coupe");
            body.Add("Hatchback");
            body.Add("Universal");
            body.Add("Cabriolet");
            body.Add("Liftback");
            body.Add("Roadster");
            ComboBox2.ItemsSource = body;
            ComboBox2.SelectedIndex = 0;
        }

        private void ComboBox3_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> color = new List<string>();
            color.Add("White");
            color.Add("Black");
            color.Add("Mixed");
            color.Add("Red");
            color.Add("Blue");
            color.Add("Purple");
            color.Add("Green");
            color.Add("Yellow");
            color.Add("Orange");
            ComboBox3.ItemsSource = color;
            ComboBox3.SelectedIndex = 0;
        }

        private void ComboBox4_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> carName = new List<string>();
            carName.Add("Audi TT");
            carName.Add("BMW M4 Competition");
            carName.Add("BMW M5 Competition");
            carName.Add("BMW M7 Competition");
            carName.Add("Mercedes-Bens GT53");
            carName.Add("Mercedes-Bens GT63");
            carName.Add("Mercedes-Bens S200");
            carName.Add("Mercedes-Bens S300");
            carName.Add("Mercedes-Bens S350");
            carName.Add("Mercedes-Bens S400");
            carName.Add("Mercedes-Bens S450");
            carName.Add("Mercedes-Bens S500");
            carName.Add("Mercedes-Bens S63");
            carName.Add("Porsche Carrera 911");
            carName.Add("Porsche Panamera");
            carName.Add("Ferrari California");
            ComboBox4.ItemsSource = carName;
            ComboBox4.SelectedIndex = 0;
        }

        private void ComboBox5_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> perf = new List<string>();
            perf.Add("155");
            perf.Add("235");
            perf.Add("255");
            perf.Add("275");
            perf.Add("300");
            perf.Add("333");
            perf.Add("355");
            perf.Add("387");
            perf.Add("455");
            perf.Add("575");
            perf.Add("655");
            ComboBox5.ItemsSource = perf;
            ComboBox5.SelectedIndex = 0;
        }
    }
}
