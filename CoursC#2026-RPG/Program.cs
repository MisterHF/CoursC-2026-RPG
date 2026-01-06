using System;
using CoursC_2026_RPG.Map;

namespace CoursC_2026_RPG
{
    public enum GameStatus
    {
        GameStarted,
        GameRunning,
        GameOver
        
    }
    
    internal class Program
    {
        private static GameStatus GameStatus = GameStatus.GameStarted;
        private static Map.Map Map;
        private static Player Player;
        private static InputHandler InputHandler;

        static void Main()
        {
            Map = MapGenerator.Generate(10, 10, 0, 0);
            
            Player = new Player(0, 0, Map);
            InputHandler = new InputHandler(Player);

            if (GameStatus == GameStatus.GameStarted)
            {
                DrawMap();
                GameStatus = GameStatus.GameRunning;
            }
            
            if (GameStatus == GameStatus.GameOver)
            {
                Console.WriteLine("Game Over");
            }

            while (GameStatus == GameStatus.GameRunning)
            {
                ConsoleKey key = Console.ReadKey(true).Key;
                
                bool moved = InputHandler.HandleInput(key);
                
                if (moved)
                {
                    Console.Clear();
                    DrawMap();
                }
            }
        }

        private static void DrawMap()
        {
            for (int y = 0; y < Map.Height; y++)
            {
                for (int x = 0; x < Map.Width; x++)
                {
                    if (x == Player.X && y == Player.Y)
                        Console.Write('P');
                    else
                        Console.Write(Map.Tiles[x, y].Symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
