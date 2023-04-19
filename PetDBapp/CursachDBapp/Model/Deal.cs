using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursachDBapp.Model
{
    public class DealList
    {
        public int DealID { get; set; }
        public string DealDate { get; set; }
        public string CarPrice { get; set; }
        public string CarID { get; set; }
        public string CarName { get; set; }
        public string CompanySypplier { get; set; }
        public string CompanySypplierCountry { get; set; }
        public string EmpSeller { get; set; }
        public string EmpSellerStatus { get;set; }
        public string Client { get; set; }
        public string Notary { get; set; }
        public int AmountOfTaxa { get; set; }
        public DealList(int dealID, string dealDate, string carPrice, string carID, string carName, string companySypplier, string companySypplierCountry, string empSeller, string empSellerStatus, string client, string notary, int amountOfTaxa)
        { 
            DealID = dealID;
            DealDate = dealDate;             
            CarPrice = carPrice;
            CarID = carID;              
            CarName = carName;
            CompanySypplier = companySypplier;
            CompanySypplierCountry = companySypplierCountry;
            EmpSeller = empSeller;
            EmpSellerStatus = empSellerStatus;
            Client = client;
            Notary = notary;
            AmountOfTaxa = amountOfTaxa;
        }
    }
}

