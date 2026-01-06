namespace CoursC_2026_RPG
{
    public class Map
    {
        public Tile[,] Tiles { get; }

        public Map(int width, int height)
        {
            Tiles = new Tile[width, height];
        }

        public Tile GetTile(int x, int y) => Tiles[x, y];
    }

}