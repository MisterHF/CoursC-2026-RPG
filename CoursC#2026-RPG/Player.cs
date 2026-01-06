using System;

namespace CoursC_2026_RPG
{
    public class Player
    {
        private int playerX;
        private int playerY;

        public Player(int _playerX, int _playerY)
        {
            playerX = _playerX;
            playerY = _playerY;
        }
        
        public void Move(int x, int y)
        {
            playerX += x;
            playerY += y;
            Console.WriteLine($"Moving {playerX}, {playerY}");
        }
    }
}