using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CursachDBapp.Forms;
using CursachDBapp.Model;

namespace CursachDBapp.Model
{
    internal class AddDelCients
    {
        public static bool AddClient(string FIO, string gender, DateTime BirthdayDate, string ClientPassport, string ClientNumber)
        {
            using (SqlConnection connection = new SqlConnection(Connection.ConnString))
            {
                try
                {
                    int a = 1;
                    connection.Open();
                    string sqlExp = "insert into Clients values (@FIO, @Gender, @BirthdayDate, @ClientPassport, @NumberPH, @position)";
                    SqlCommand cmd = new SqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("@FIO", FIO);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@BirthdayDate", BirthdayDate);
                    cmd.Parameters.AddWithValue("@ClientPassport", ClientPassport);
                    cmd.Parameters.AddWithValue("@NumberPH", ClientNumber);
                    cmd.Parameters.AddWithValue("@position", a);
                    
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return false;
                }
            }
        }
    }
}
