using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursachDBapp.Model
{
    public class ClientsList
    {
        public int ClientID { get; set; }
        public string ClientName { get; set; }
        public string ClientStatus { get; set; }
        public string ClientPhone { get; set; }
        public ClientsList(int clientID, string clientName, string clientStatus, string clientPhone)
        {
            ClientID = clientID;
            ClientName = clientName;
            ClientStatus = clientStatus;
            ClientPhone = clientPhone;
        }
    }
}
