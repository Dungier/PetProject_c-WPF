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
using CursachDBapp.Model;
using CursachDBapp.Forms;

namespace CursachDBapp.Forms
{
    /// <summary>
    /// Логика взаимодействия для AutoForm.xaml
    /// </summary>
    public partial class AutoForm : Window
    {
        internal static string Fio { get; set; }
        internal static int UserId { get; set; }
        internal static string EmpPost { get; set; }
        internal static int EmpPostID { get; set; }
        public AutoForm()
        {
            InitializeComponent();
            Fio = "";
            UserId = 0;
            EmpPost = "";
            EmpPostID = 0;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1 != null && textBox2 != null)
            {
                UserId = Auto.CheckAutorize(textBox1.Text, textBox2.Text);
                if (UserId != 0 && EmpPostID == 2 || EmpPostID == 3 || EmpPostID == 4)
                {
                    MainWindow mainform = new MainWindow();
                    mainform.Show();
                    this.Hide();
                }
                else if(UserId != 0 && EmpPostID == 1)
                {
                    ManadgerWindow manadgerwindow = new ManadgerWindow();
                    manadgerwindow.Show();
                    this.Hide();
                }
                else
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
        }
    }
}
