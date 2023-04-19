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
    internal class AddDelEmp
    {
        public static void DelEmp(int EmpID)
        {
            using(SqlConnection connection = new SqlConnection(Connection.ConnString))
            {
                try
                {
                    connection.Open();
                    string sqlExp = "Delete from Employees where EmpID = @EmpID";
                    SqlCommand cmd = new SqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("@EmpID", EmpID);
                    cmd.ExecuteNonQuery();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public static bool AddEmp(string FIO, int position, string Gender, DateTime BirthdayDate, string EmpPassport, string NumberPH, string EmpLogin, string EmpPassword)
        {
            using (SqlConnection connection = new SqlConnection(Connection.ConnString))
            {
                try
                {
                    connection.Open();
                    string sqlExp = "insert into Employees values (@position, @FIO, @Gender, @BirthdayDate, @EmpPassport, @NumberPH, @EmpLogin, @EmpPassword)";
                    SqlCommand cmd = new SqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("@position", position);
                    cmd.Parameters.AddWithValue("@FIO", FIO);
                    cmd.Parameters.AddWithValue("@Gender", Gender);
                    cmd.Parameters.AddWithValue("@BirthdayDate", BirthdayDate);
                    cmd.Parameters.AddWithValue("@EmpPassport", EmpPassport);
                    cmd.Parameters.AddWithValue("@NumberPH", NumberPH);
                    cmd.Parameters.AddWithValue("@EmpLogin", EmpLogin);
                    cmd.Parameters.AddWithValue("@EmpPassword", EmpPassword);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
