using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursachDBapp.Model
{
    class ClientsFromDB
    {
        public static List<ClientsList> LoadClients(string fio)
        {
            List<ClientsList> clientsLists = new List<ClientsList>();
            using (SqlConnection connection = new SqlConnection(Connection.ConnString))
            {
                connection.Open();
                string sqlExp = $"Select ClientID, FIO, StatusName, NumberPH from Clients c join ClientStatus cs on c.Position = cs.ClientStatusID where FIO like '%{fio}%' ";
                SqlCommand cmd = new SqlCommand(sqlExp, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    clientsLists.Add(new ClientsList(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()));
                    while (reader.Read())
                    {
                        clientsLists.Add(new ClientsList(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), reader[3].ToString()));
                    }
                }
                reader.Close();
                return clientsLists;
            }
        }
    }
}
