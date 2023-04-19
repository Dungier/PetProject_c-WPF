using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CursachDBapp.Model
{
    public class CarsList
    {
        public int AutoID { get; set; }
        public string CarName { get; set; }
        public string CarFuel { get; set; }
        public int CarPerfomance { get; set; }
        public string CarBody { get; set; }
        public string CarRealese { get; set; }
        public string CarColor { get; set; }
        public string CarAvailable { get; set; }
        public CarsList(int autoID, string carName, string carFuel, int carPerfomances, string carBody, string carRealese, string carColor, string carAvailable)
        {
            AutoID = autoID;
            CarName = carName;
            CarFuel = carFuel;
            CarPerfomance = carPerfomances;
            CarBody = carBody;
            CarRealese = carRealese;
            CarColor = carColor;
            CarAvailable = carAvailable;
        }
    }
}
