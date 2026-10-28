using Labyrinth.Items;
using Labyrinth.Tiles;

namespace Labyrinth.Crawl
{
    /// <summary>
    /// Crawler moving through the labyrinth.
    /// </summary>
    public class Crawler(int startX, int startY, Tile facingTile) : ICrawler
    {
        public int X { get; private set; } = startX;

        public int Y { get; private set; } = startY;

        public Direction Direction => Direction.North;

        public Tile FacingTile { get; set; } = facingTile;

        public Inventory Walk() => throw new NotImplementedException();
        
        public void TurnLeft()
        {
            Direction.TurnLeft();
        }

        public void TurnRight()
        {
            Direction.TurnRight();
        }
        
        public void UpdateFacingTile(Tile tile)
        {
            FacingTile = tile;
        }
    }
}
