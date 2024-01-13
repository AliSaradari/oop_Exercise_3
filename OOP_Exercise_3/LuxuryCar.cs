using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_3
{
    public class LuxuryCar : Car
    {
        public LuxuryCar(CarType carType, string name) : base(carType, name)
        {
        }

        public override void SetPrice(int dailyPrice)
        {
            base.SetPrice(dailyPrice);
            if (dailyPrice < 200)
            {
                throw new Exception("Luxury car daily prices cannot be less than $200");
            }
        }
    }
}
