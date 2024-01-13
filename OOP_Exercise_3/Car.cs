using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_3
{
    public abstract class Car
    {
        private string _name;
        protected Car(CarType carType,string name)
        {
            Type = carType;
            Name = name;
        }
        public CarType Type { get; set; }
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Id Cannot Be Empty.");

                }
                _name = value;
            }
        }
        public int DailyPrice { get; private set; }
        public int Count { get; private set; }

        public virtual void SetPrice(int dailyPrice)
        {
            if (dailyPrice < 0) { throw new Exception("The Price Cannot Be Negative."); }
            DailyPrice = dailyPrice;

        }
        public void SetCount(int count)
        {
            if (count < 0) { throw new Exception("The Count Cannot Be Negative."); }
            if (count > 5) { throw new Exception("The garage doesn't have enough space for this number\n" +
                "Maximum acceptable quantity is '5'"); }
            Count = count;

        }

    }
}
