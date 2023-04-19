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
        public Employees()
        {
            InitializeComponent();
            emps = EmpFromBD.LoadEmp();
            ListViewEmp.ItemsSource = emps;
            EmpID = 0;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                bool ClearTextBoxes;
                string gender = "";
                if(textBox3.Text == "Женский")
                {
                    gender = "F";
                }else if (textBox3.Text == "Мужской")
                {
                    gender = "M";
                }
                int position;
                if (textBox2.Text == "Менеджер") { position = 1; }
                else if(textBox2.Text == "Директор") { position= 2; }
                else if (textBox2.Text == "Администратор") { position = 3; }
                else if (textBox2.Text == "Помощник директора") { position = 4; }
                ClearTextBoxes =  AddDelEmp.AddEmp(textBox1.Text, Convert.ToInt32(textBox2.Text), gender, PresetDateTime, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
                ListViewEmp.ItemsSource = EmpFromBD.LoadEmp();
                if (ClearTextBoxes == true)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
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
                ListViewEmp.ItemsSource = EmpFromBD.LoadEmp();
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
    }
}
