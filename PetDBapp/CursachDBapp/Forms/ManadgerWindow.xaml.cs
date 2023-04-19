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
    /// <summary>
    /// Логика взаимодействия для ManadgerWindow.xaml
    /// </summary>
    public partial class ManadgerWindow : Window
    {
        public ManadgerWindow()
        {
            InitializeComponent();
            lable1.Content = "Добро пожаловать в систему, " + AutoForm.Fio;
            lable2.Content = "Ваша должность: " + AutoForm.EmpPost;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Deals addDeal = new Deals();
            addDeal.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            AutoForm auto = new AutoForm();
            auto.Show();
            this.Hide();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
