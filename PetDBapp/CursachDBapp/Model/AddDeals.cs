using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CursachDBapp.Model
{
    internal class AddDeals
    {
        public static bool AddDeal(DateTime DealTime, int Price, int AutoID, int CompanySypplier, int SellerID, int ClientID, int CompanyNotary)
        {
            try 
            {
                using (SqlConnection connection = new SqlConnection(Connection.ConnString))
                {
                    connection.Open();
                    string sqlExp = "exec AddDeal @DealTime, @Price, @AutoID, @CompanySypplier, @SellerID, @ClientID, @CompanyNotary";
                    SqlCommand cmd = new SqlCommand(sqlExp, connection);
                    cmd.Parameters.AddWithValue("@DealTime", DealTime);
                    cmd.Parameters.AddWithValue("@Price", Price);
                    cmd.Parameters.AddWithValue("@AutoID", AutoID);
                    cmd.Parameters.AddWithValue("@CompanySypplier", CompanySypplier);
                    cmd.Parameters.AddWithValue("@SellerID", SellerID);
                    cmd.Parameters.AddWithValue("@ClientID", ClientID);
                    cmd.Parameters.AddWithValue("@CompanyNotary", CompanyNotary);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
    }
}
