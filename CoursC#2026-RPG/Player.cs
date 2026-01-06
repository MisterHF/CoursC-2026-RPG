using System;

namespace CoursC_2026_RPG
{
    public class Player
    {
        private int PlayerX;
        private int PlayerY;
        private Map.Map CurrentMap;

        public Player(int playerX, int playerY, Map.Map map)
        {
            PlayerX = playerX;
            PlayerY = playerY;
            CurrentMap = map;
        }

        public void Move(int x, int y)
        {
            int newX = PlayerX + x;
            int newY = PlayerY + y;

            if (CanMove(newX, newY))
            {
                PlayerX = newX;
                PlayerY = newY;
                Console.WriteLine($"Player moved to ({PlayerX}, {PlayerY})");
            }
            else
            {
                Console.WriteLine("Cannot move there!");
            }
        }

        private bool CanMove(int x, int y)
        {
            if (x < 0 || y < 0 || x >= CurrentMap.Width || y >= CurrentMap.Height)
                return false;
            
            if (!CurrentMap.Tiles[x, y].Walkable)
                return false;

            return true;
        }

        public int X => PlayerX;
        public int Y => PlayerY;
    }
}