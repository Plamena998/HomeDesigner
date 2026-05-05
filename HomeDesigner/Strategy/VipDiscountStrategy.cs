using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDesigner.Strategy
{
    public class VipDiscountStrategy : IPaymentStrategy
    {
        public double Discount(double amount)
        {
            return amount * 0.85;
        }
    }
}
