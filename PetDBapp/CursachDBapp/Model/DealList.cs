using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursachDBapp.Model
{
    class DealFromDB
    {
        public static List<DealList> LoadDeals()
        {
            List<DealList> dealLists = new List<DealList>();
            using (SqlConnection connection = new SqlConnection(Connection.ConnString))
            {
                connection.Open();
                string sqlExp = "select DealID , DateOfDeal, Price, Automobile, a.CarName,ComSyp.CompanyName, ComSypCoun.Country, Emp.FIO, EmpPost.StatusName, Client.FIO,NotaryComp.NotaryСompanyName, Tax.AmountOfTaxa from Deals deal"
                + " join Automobile A on a.AutoID = deal.Automobile " + " join CompanySypplier ComSyp on ComSyp.CompanyID = deal.CompanySypplier "
                + " join CompanySypplierCountry ComSypCoun on ComSyp.CompanyCountry = ComSypCoun.CompanyCountryID " + " join Employees Emp on deal.EmpSeller = Emp.EmpID "
                + " join EmployeesPost EmpPost on Emp.Position = EmpPost.EmpStatusID " + " join Clients Client on deal.Client = Client.ClientID "
                + " join NotaryСompany NotaryComp on deal.NotaryСompanyConfirmed = NotaryComp.NotaryСompanyID " + " join Taxation Tax on Tax.TaxaID = DealID  " + " order by DealID ";
                SqlCommand cmd = new SqlCommand(sqlExp, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                dealLists.Add(new DealList(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), Convert.ToInt32(reader[11])));
                while (reader.Read())
                {
                    dealLists.Add(new DealList(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), Convert.ToInt32(reader[11])));
                }
                connection.Close();
                reader.Close();
                return dealLists;
            }
        }
    }
}
