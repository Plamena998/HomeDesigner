using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDesigner.Decorator
{
    public interface IProject
    {
        public string GetDescription();
        public double GetCost();

    }
}
