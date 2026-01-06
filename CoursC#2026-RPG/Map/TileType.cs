using System;

namespace CoursC_2026_RPG.Map
{
    public sealed class TileType
    {
        public string Id { get; }
        public bool Walkable { get; }
        public char Symbol { get; }

        public TileType(string id, bool walkable, char symbol)
        {
            Id = id;
            Walkable = walkable;
            Symbol = symbol;
        }
    }
}