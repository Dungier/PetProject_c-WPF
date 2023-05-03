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
    /// <summary>
    /// Логика взаимодействия для Deals.xaml
    /// </summary>
    public partial class Deals : Window
    {
        List<CarsList> cars = new List<CarsList>();
        List<ClientsList> clients = new List<ClientsList>();
        private int CarID { get; set; }
        private int ClientsID { get; set; }
        private DateTime DealDate {get;set;}
        private int Sypplier { get; set; }
        private int Notary { get; set; }
        private int SumOfDeal { get; set; }
        public Deals()
        {
            InitializeComponent();
            cars = CarsFromBD.LoadCarsCarAvalible("");
            ListViewCars.ItemsSource = cars;
            clients = ClientsFromDB.LoadClients("");
            ListViewClients.ItemsSource = clients;
        }
        private void ListViewCars_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CarsList selectedItem = (CarsList)ListViewCars.SelectedItem;
            if (selectedItem != null)
            {
                CarID = selectedItem.AutoID;
            }
        }

        private void ListViewClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ClientsList selectedItem = (ClientsList)ListViewClients.SelectedItem;
            if(selectedItem != null)
            {
                ClientsID = selectedItem.ClientID;
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if(textBox1.Text != null)
            {
                SumOfDeal = int.Parse(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Для заключения сделки необходимо заполнить поле: Сумма сделки.");
            }
            DealDate = DateTime.Now;
            bool DealAns = AddDeals.AddDeal(DealDate, SumOfDeal, CarID, Sypplier, AutoForm.UserId, ClientsID, Notary);
            if (DealAns)
            {
                MessageBox.Show("Сделка успешна");
                ListViewCars.ItemsSource = CarsFromBD.LoadCarsCarAvalible("");
                textBox1.Text = "";
                ComboBox1.SelectedIndex = 0;
                ComboBox2.SelectedIndex = 0;
            }
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Sypplier = ComboBox1.SelectedIndex + 1;
        }

        private void ComboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Notary = ComboBox2.SelectedIndex + 1;
        }

        private void ComboBox1_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> Company = new List<string>();
            Company.Add("Mercedes-Bens Germany");
            Company.Add("Mercedes-Bens America");
            Company.Add("Mercedes-Bens England");
            Company.Add("Audi");
            Company.Add("BMW");
            Company.Add("Porsche");
            Company.Add("Ferrari");
            ComboBox1.ItemsSource = Company;
            ComboBox1.SelectedIndex = 0;
        }

        private void ComboBox2_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> NotaryCompany = new List<string>();
            NotaryCompany.Add("Auto Notary Services");
            NotaryCompany.Add("Annabelle’s Notary Services");
            NotaryCompany.Add("A Plus Notary");
            NotaryCompany.Add("SAS Notary");
            NotaryCompany.Add("Notary Xpert");
            NotaryCompany.Add("Worldwide Notary");
            ComboBox2.ItemsSource = NotaryCompany;
            ComboBox2.SelectedIndex = 0;
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            cars = CarsFromBD.LoadCarsCarAvalible(textBox2.Text);
            ListViewCars.ItemsSource = cars;
        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            clients = ClientsFromDB.LoadClients(textBox3.Text);
            ListViewClients.ItemsSource = clients;
        }
    }
}
