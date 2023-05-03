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
    class CarsFromBD
    {
        public static List<CarsList> LoadCars()
        {
            List<CarsList> car = new List<CarsList>();
            using (SqlConnection connection = new SqlConnection(Connection.ConnString))
            {
                connection.Open();
                string sqlExp = "select AutoID, CarName, f.FuelName, a.Perfomance, b.[BodyType], DateOfRealese, c.ColorName, CarAvalible from Automobile a"
                    + " join AutomobileBody b on b.[AutomobileBodyID] = a.BodyType "
                    + " join AutomobileFuel f on f.[AutomobileFuelID] = a.Fuel "
                    + " join AutomobileColor c on c.AutomobileColorID = a.Color ";
                SqlCommand cmd = new SqlCommand(sqlExp, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                car.Add(new CarsList(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), Convert.ToInt32(reader[3]), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()));
                if (reader.HasRows)
                {
                    car.Add(new CarsList(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), Convert.ToInt32(reader[3]), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()));
                    while (reader.Read())
                    {
                        car.Add(new CarsList(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), Convert.ToInt32(reader[3]), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()));
                    }
                }
                reader.Close();
                return car;
            }
        }
        public static List<CarsList> LoadCarsCarAvalible(string name)
        {
            List<CarsList> car = new List<CarsList>();
            using (SqlConnection connection = new SqlConnection(Connection.ConnString))
            {
                connection.Open();
                string sqlExp = "select AutoID, CarName, f.FuelName, a.Perfomance, b.[BodyType], DateOfRealese, c.ColorName, CarAvalible from Automobile a"
                    + " join AutomobileBody b on b.[AutomobileBodyID] = a.BodyType "
                    + " join AutomobileFuel f on f.[AutomobileFuelID] = a.Fuel "
                    + $" join AutomobileColor c on c.AutomobileColorID = a.Color where CarAvalible = 'Y' and CarName like '%{name}%' ";
                SqlCommand cmd = new SqlCommand(sqlExp, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    car.Add(new CarsList(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), Convert.ToInt32(reader[3]), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()));
                    while (reader.Read())
                    {
                        car.Add(new CarsList(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), Convert.ToInt32(reader[3]), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString()));
                    }
                }
                reader.Close();
                return car;
            }
        }
    }
}