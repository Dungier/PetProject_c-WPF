using CursachDBapp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Логика взаимодействия для Employees.xaml
    /// </summary>
    public partial class Employees : Window
    {
        public List<EmpList> emps = new List<EmpList>();
        public int EmpID { get; set; }
        private DateTime PresetDateTime { get; set; }
        private int position { get; set; }
        private string gender { get; set; }
        public Employees()
        {
            InitializeComponent();
            emps = EmpFromBD.LoadEmp("");
            ListViewEmp.ItemsSource = emps;
            EmpID = 0;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                bool ClearTextBoxes;
                ClearTextBoxes =  AddDelEmp.AddEmp(textBox1.Text, position, gender, PresetDateTime, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
                ListViewEmp.ItemsSource = EmpFromBD.LoadEmp("");
                if (ClearTextBoxes == true)
                {
                    textBox1.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля.");
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            if (EmpID != 0)
            {
                AddDelEmp.DelEmp(EmpID);
                ListViewEmp.ItemsSource = EmpFromBD.LoadEmp("");
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void ListViewEmp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EmpList selectedItem = (EmpList)ListViewEmp.SelectedItem;
            if (selectedItem != null)
            {
                EmpID = selectedItem.EmpID;
            }
        }

        public void PresetTime(object sender, SelectionChangedEventArgs e)
        {
            PresetDateTime = TimePicker1.SelectedDate.Value;
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

        private void ComboBox2_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> stat = new List<string>();
            stat.Add("Менеджер");
            stat.Add("Директор");
            stat.Add("Администратор");
            stat.Add("Помощник Директора");
            ComboBox2.ItemsSource = stat;
        }

        private void ComboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBox2.SelectedItem.ToString() == "Все") { }
            else if (ComboBox2.SelectedItem.ToString() == "Менеджер") { position = 1; }
            else if (ComboBox2.SelectedItem.ToString() == "Директор") { position = 2; }
            else if (ComboBox2.SelectedItem.ToString() == "Администратор") { position = 3; }
            else if (ComboBox2.SelectedItem.ToString() == "Помощник директора") { position = 4; }
        }

        private void ComboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            emps = EmpFromBD.LoadEmpPosition(ComboBox3.SelectedIndex + 1);
            ListViewEmp.ItemsSource = emps;
        }

        private void ComboBox3_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> stat = new List<string>();
            stat.Add("Менеджер");
            stat.Add("Директор");
            stat.Add("Администратор");
            stat.Add("Помощник Директора");
            ComboBox3.ItemsSource = stat;
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            emps = EmpFromBD.LoadEmp(textBox2.Text);
            ListViewEmp.ItemsSource = emps;
        }
    }
}
