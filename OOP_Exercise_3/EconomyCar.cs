using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_3
{
    public class EconomyCar : Car
    {
        public EconomyCar(CarType carType, string name) : base(carType, name)
        {
        }

        public override void SetPrice(int dailyPrice)
        {
            base.SetPrice(dailyPrice);
            if (dailyPrice > 200)
            {
                throw new Exception("Economy car daily prices cannot be more than $200");
            }
        }
    }
}
