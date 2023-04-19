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
        public AddClients()
        {
            InitializeComponent();
            clients = ClientsFromDB.LoadClients();
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
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "")
            {
                string gender = "";
                bool ClearTextBoxes = false;
                if (textBox2.Text == "Женский")
                {
                    gender = "F";
                }
                else if (textBox2.Text == "Мужской")
                {
                    gender = "M";
                }
                ClearTextBoxes = AddDelCients.AddClient(textBox1.Text, gender, BirthdayDate, textBox3.Text, textBox4.Text);
                ListViewClients.ItemsSource = ClientsFromDB.LoadClients();
                if (ClearTextBoxes == true)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
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
    }
}
