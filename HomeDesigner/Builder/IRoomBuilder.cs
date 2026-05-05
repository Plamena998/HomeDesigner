using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDesigner.Builder
{
    public interface IRoomBuilder
    {
       public void SetStyle();
        public void BuildFloor();
        public void BuildWalls();
        public void BuildCeiling();
        public void AddFurniture();
        public Room GetResult();
    }
}
