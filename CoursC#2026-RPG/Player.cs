using System;

namespace CoursC_2026_RPG
{
    public class Player
    {
        private int PlayerX;
        private int PlayerY;

        public Player(int playerX, int playerY)
        {
            PlayerX = playerX;
            PlayerY = playerY;
        }
        
        public void Move(int x, int y)
        {
            PlayerX += x;
            PlayerY += y;
            Console.WriteLine($"Moving {PlayerX}, {PlayerY}");
        }
    }
}