using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDesigner.Builder
{
    public class DesignerDirector
    {
        public void Construct(IRoomBuilder roomBuilder)
        {
            roomBuilder.SetStyle();
            roomBuilder.BuildFloor();
            roomBuilder.BuildWalls();
            roomBuilder.BuildCeiling();
            roomBuilder.AddFurniture();
            
        }
    }
}
