using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDesigner.Builder
{
    public class ScandinavianRoomBuilder : IRoomBuilder
    {
        private Room room = new Room();

        public void SetStyle()
        {
            room.Style = "Scandinavian style";
        }
        public void BuildFloor()
        {
            room.Floor = "Light wood flooring";
            room.BasePrice += 500;
        }
        public void BuildWalls()
        {
            room.Walls = "White painted walls";
            room.BasePrice += 300;
        }
        public void BuildCeiling()
        {
            room.Ceiling = "White ceiling with wooden beams";
            room.BasePrice += 400;
        }
        public void AddFurniture()
        {
            room.Furnitures = new List<Furnitureitem>
            {
                new Furnitureitem("Sofa", "Gray", 800),
                new Furnitureitem("Coffee Table", "Light wood", 200),
                new Furnitureitem("Dining Table", "Light wood", 600),
                new Furnitureitem("Chairs", "White", 400)
            };
        }
        public Room GetResult()
        {
            return room;
        }
    }
}

