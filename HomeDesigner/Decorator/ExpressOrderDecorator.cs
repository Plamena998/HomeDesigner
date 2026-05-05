using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDesigner.Decorator
{
    public class ExpressOrderDecorator : ProjectDecorator
    {
        public ExpressOrderDecorator(IProject project) : base(project)
        {
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " with express order";
        }
        public override double GetCost()
        {
            return base.GetCost() + 1000;
        }
    }
}
