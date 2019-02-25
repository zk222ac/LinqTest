using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
   public class Studio
   {
        public int StudioId { get; set; }
        public string  StudioName { get; set; }
        public string City { get; set; }
        public int NoOfEmployees { get; set; }

        public Studio( int id,string studioName, string city, int noOfEmployees)
        {
            StudioId = id;
            StudioName = studioName;
            City = city;
            NoOfEmployees = noOfEmployees;
        }

        public override string ToString()
        {
            return $"ID:{StudioId} ,StudioName :{StudioName}, City:{City}, Employees:{NoOfEmployees}";
        }
    }
}
