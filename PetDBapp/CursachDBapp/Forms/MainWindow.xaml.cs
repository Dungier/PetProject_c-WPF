using CursachDBapp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Messaging;
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

namespace CursachDBapp.Forms
{
    public partial class MainWindow : Window
    { 
        public List<CarsList> cars = new List<CarsList>();
        private int CarID { get; set; }
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
            cars = CarsFromBD.LoadCars();
            ListViewCars.ItemsSource = cars;
            lable1.Content = "Добро пожаловать в систему, " + AutoForm.Fio;
            lable2.Content = "Ваша должность: " + AutoForm.EmpPost;
            if (AutoForm.EmpPost == "Administator")
            {
                button7.Visibility = Visibility.Visible;
            }else
            {
                button7.Visibility = Visibility.Hidden;
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Employees emp = new Employees();
            emp.Show();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            AddCars addCars = new AddCars();
            addCars.Show();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Deals addDeal = new Deals();
            addDeal.Show();
        }

        private void ListViewCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CarsList selectedItem = (CarsList)ListViewCars.SelectedItem;
            if (selectedItem != null)
            {
                CarID = selectedItem.AutoID;
            }
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            AutoForm auto = new AutoForm();
            auto.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            DealsLists deals = new DealsLists();
            deals.Show();   
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            AddClients addClients = new AddClients();
            addClients.Show();
        }
    }
}
