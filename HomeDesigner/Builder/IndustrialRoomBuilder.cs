
namespace HomeDesigner.Builder
{
    public class IndustrialRoomBuilder : IRoomBuilder
    {
        private Room _room = new Room();

        public void SetStyle() => _room.Style = "Industrial Loft";

        public void BuildCeiling() => _room.Ceiling = "Exposed concrete";

        public void BuildWalls() => _room.Walls = "Brick wall and metal elements";

        public void AddFurniture()
        {
            _room.Furnitures.Add(new Furnitureitem("Sofa Chesterfield","brown", 2800.00));
            _room.Furnitures.Add(new Furnitureitem("Table from solid wood and metal","natural", 850.00));
            _room.Furnitures.Add(new Furnitureitem("Metal shelf","black", 400.00));
            _room.BasePrice = 6200.00; 
        }

        public Room GetResult() => _room;

        public void BuildFloor()
        {
           _room.Floor = "Polished concrete with rugs";
        }
    }
}