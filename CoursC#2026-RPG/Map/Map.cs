using System.Collections.Generic;

namespace CoursC_2026_RPG.Map
{
    public class Map
    {
        public int Width { get; }
        public int Height { get; }
        public Tile[,] Tiles { get; }
        public List<Entity> Entities { get; } = new List<Entity>();

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
            Tiles = new Tile[width, height];
        }
    }

}