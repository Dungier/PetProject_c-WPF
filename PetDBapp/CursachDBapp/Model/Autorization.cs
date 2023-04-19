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
    class Auto
    {
        public static int CheckAutorize(string login, string password)
        {
            using (SqlConnection connect = new SqlConnection(Connection.ConnString))
            {
                connect.Open();
                if (!(login != "" && password != ""))
                {
                    MessageBox.Show("Введите данные"); return 0;
                }
                else
                {
                    string sqlExp = "Select EmpID, StatusName, FIO, Gender, BirthdayDate, EmpPassport, NumberPH, EmpLogin, EmpPassword, Position from Employees" +
                        " join EmployeesPost on Position = EmpStatusID" +
                        " where EmpLogin = @Login";
                    SqlCommand cmd = new SqlCommand(sqlExp, connect);
                    cmd.Parameters.AddWithValue("@login", login);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        if (reader["EmpPassword"].ToString() == password)
                        {
                            AutoForm.Fio = reader["FIO"].ToString();
                            AutoForm.UserId = Convert.ToInt32(reader["EmpID"]);
                            AutoForm.EmpPost = reader["StatusName"].ToString();
                            AutoForm.EmpPostID = Convert.ToInt32(reader["Position"]);
                            return Convert.ToInt32(reader["EmpID"]);
                        }
                        else
                        {
                            MessageBox.Show("Неверный пароль");
                            return 0;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Такого пользователя нет");
                        return 0;
                    }
                }
            }
        }
    }
}
