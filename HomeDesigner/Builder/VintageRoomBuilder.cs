
namespace HomeDesigner.Builder
{
    public class VintageRoomBuilder : IRoomBuilder
    {
        private Room _room = new Room();

        public void SetStyle() => _room.Style = "Vintage Classic";

        public void BuildCeiling() => _room.Ceiling = "Ornate plaster ceiling";

        public void BuildWalls() => _room.Walls = "Wallpaper with floral patterns";

        public void AddFurniture()
        {
            _room.Furnitures.Add(new Furnitureitem("Retro Armchair","brown", 650.00));
            _room.Furnitures.Add(new Furnitureitem("Antique Cabinet","dark wood", 1100.00));
            _room.BasePrice = 4500.00;
        }

        public Room GetResult() => _room;

        public void BuildFloor()
        {
            _room.Floor = "Hardwood with vintage rugs";
        }

    }
}