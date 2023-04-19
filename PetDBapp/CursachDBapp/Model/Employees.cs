using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursachDBapp.Model
{
    public class EmpList
    {
        public int EmpID { get; set; }
        public string EmpFIO { get; set; }
        public string EmpStatus { get; set; }

        public EmpList(int empID, string empFIO, string empStatus)
        {
            EmpID = empID;
            EmpFIO = empFIO;
            EmpStatus = empStatus;
        }
    }
}
