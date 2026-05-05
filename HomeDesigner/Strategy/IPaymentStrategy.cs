using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDesigner.Strategy
{
    public interface IPaymentStrategy
    {
        public double Discount(double amount);
    }
}
