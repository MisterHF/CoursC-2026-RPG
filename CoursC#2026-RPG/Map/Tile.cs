using System;

namespace CoursC_2026_RPG.Map
{
    public class Tile
    {
        public TileType Type { get; }

        public bool Walkable => Type.Walkable;
        public char Symbol => Type.Symbol;

        public Tile(TileType type)
        {
            Type = type;
        }
    }

}