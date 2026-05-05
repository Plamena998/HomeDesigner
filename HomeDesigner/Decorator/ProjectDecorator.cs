using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDesigner.Decorator
{
    public abstract class ProjectDecorator : IProject
    {
        protected IProject project;
        public ProjectDecorator(IProject project)
        {
            this.project = project;
        }
        public virtual string GetDescription()
        {
            return project.GetDescription();
        }
        public virtual double GetCost()
        {
            return project.GetCost();
        }
    }
}
