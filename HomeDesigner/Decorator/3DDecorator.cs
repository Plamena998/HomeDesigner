using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDesigner.Decorator
{
    public class _3DDecorator : ProjectDecorator
    {
        public _3DDecorator(IProject project) : base(project)
        {
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " with 3D visualization";
        }
        public override double GetCost()
        {
            return base.GetCost() + 500;
        }
    }
}
