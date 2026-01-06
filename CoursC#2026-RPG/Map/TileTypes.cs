using System;
using System.Collections.Generic;

namespace CoursC_2026_RPG.Map
{
    public static class TileTypes
    {
        public static readonly TileType Floor = new TileType("Floor", true, '.');

        public static readonly TileType Wall = new TileType("Wall", false, '#');
    }
}