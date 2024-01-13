using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_3
{
    public class RentedCar
    {
        public RentedCar(string name,string carName,int rentedDays,DateTime rentDate)
        {
            RenterUserName = name;
            RentedCarName = carName;
            RentedDays = rentedDays;
            RentDate = rentDate;
        }
        public string RenterUserName { get; set; }
        public string RentedCarName { get; set;}
        public int RentedDays { get; set; }
        public DateTime RentDate { get; set; }
    }
}
