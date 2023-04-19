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
    internal class EmpFromBD
    {
        public static List<EmpList> LoadEmp()
        {
            List<EmpList> emps = new List<EmpList>();
            using (SqlConnection connection = new SqlConnection(Connection.ConnString))
            {
                connection.Open();
                string sqlExp = "select EmpID, FIO, StatusName from Employees"
                    + " join EmployeesPost on Position = EmpStatusID";
                SqlCommand cmd = new SqlCommand(sqlExp, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        emps.Add(new EmpList(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString()));
                    }
                }
                reader.Close();
                return emps;
            }
        }
    }
}
