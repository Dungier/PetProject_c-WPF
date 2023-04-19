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
    /// Логика взаимодействия для DealsLists.xaml
    /// </summary>
    public partial class DealsLists : Window
    {
        public List<DealList> dealLists = new List<DealList>();
        public DealsLists()
        {
            InitializeComponent();
            dealLists = DealFromDB.LoadDeals();
            ListViewDeals.ItemsSource = dealLists;
        }

        private void ListViewDeals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
