using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursC_2026_RPG
{
    internal class Program
    {
        private static bool gameRunning = true;
        private static Player player = new Player(0, 0);
        private static InputHandler inputHandler = new InputHandler(player);
        static void Main()
        {
            while (gameRunning)
            {
                inputHandler.HandleInput();
            }
        }
    }
}
