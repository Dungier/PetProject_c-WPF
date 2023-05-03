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
    /// Логика взаимодействия для AddClients.xaml
    /// </summary>
    public partial class AddClients : Window
    {
        List<ClientsList> clients = new List<ClientsList>();
        private int ClientsID {  get; set; }
        private DateTime BirthdayDate { get; set; }
        private string gender { get; set; }
        public AddClients()
        {
            InitializeComponent();
            clients = ClientsFromDB.LoadClients("");
            ListViewClients.ItemsSource = clients;
        }

        private void ListViewClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ClientsList selectedItem = (ClientsList)ListViewClients.SelectedItem;
            if (selectedItem != null)
            {
                ClientsID = selectedItem.ClientID;
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                bool ClearTextBoxes = false;
                ClearTextBoxes = AddDelCients.AddClient(textBox1.Text, gender, BirthdayDate, textBox3.Text, textBox4.Text);
                ListViewClients.ItemsSource = ClientsFromDB.LoadClients("");
                if (ClearTextBoxes == true)
                {
                    textBox1.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
            }else
            {
                MessageBox.Show("Заполните все поля.");
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void PresetTime(object sender, SelectionChangedEventArgs e)
        {
            BirthdayDate = TimePicker1.SelectedDate.Value;
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox1.SelectedItem.ToString() == "Женский")
            {
                gender = "F";
            }
            else if (ComboBox1.SelectedItem.ToString() == "Мужской")
            {
                gender = "M";
            }
        }

        private void ComboBox1_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> gender = new List<string>();
            gender.Add("Мужской");
            gender.Add("Женский");
            ComboBox1.ItemsSource = gender;
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            clients = ClientsFromDB.LoadClients(textBox2.Text);
            ListViewClients.ItemsSource = clients;
        }
    }
}
