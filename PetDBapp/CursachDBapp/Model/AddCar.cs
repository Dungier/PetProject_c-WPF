using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using CursachDBapp.Forms;
using CursachDBapp.Model;
namespace CursachDBapp.Model
{
    internal class AddCarsBD
    {
        public static void AddCar(int fuel, int body, int color, string name, int perf, DateTime RealeseDate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.ConnString))
                {
                    connection.Open();
                    string sqlExp = "insert into Automobile (Fuel, BodyType, Color, DateOfRealese, CarName, Perfomance) values (@fuel, @body, @color, @realeseDate, @name, @perf)";
                    SqlCommand cmd = new SqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("@fuel", fuel);
                    cmd.Parameters.AddWithValue("@body", body);
                    cmd.Parameters.AddWithValue("@color", color);
                    cmd.Parameters.AddWithValue("@realeseDate", RealeseDate);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@perf", Convert.ToInt32(perf));
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
