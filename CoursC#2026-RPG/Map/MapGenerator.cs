using System;
using System.Diagnostics;

namespace CoursC_2026_RPG.Map
{
    public static class MapGenerator
    {
        private static readonly Random RandomNumber = new Random();

        public static Map Generate(int width, int height, int playerWidth, int playerHeight)
        {
            var map = new Map(width, height);

            if (playerWidth > width || playerHeight > height)
            {
                Console.WriteLine("Map non valide");
            }

            for (int x = 0; x < width; x++)
            for (int y = 0; y < height; y++)
            {
                TileType type =  TileTypes.Floor;

                int roll = RandomNumber.Next(100);
                type = roll < 70 ? TileTypes.Floor : TileTypes.Wall;
                
                map.Tiles[x, y] = new Tile(type);
            }

            return map;
        }
    }
}