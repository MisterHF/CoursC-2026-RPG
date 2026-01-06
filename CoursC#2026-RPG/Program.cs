using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursC_2026_RPG
{
    internal class Program
    {
        private static bool GameRunning = true;
        private static Player Player = new Player(0, 0);
        private static InputHandler InputHandler = new InputHandler(Player);
        static void Main()
        {
            //IEntity monsterFactory = new Monster();
            //Entity monster = monsterFactory.CreateEntity();
            //monster.SetStatsEntity(StatType.Health, 100);

            //IEntity npcFactory = new Pnj();
            //Entity npc = monsterFactory.CreateEntity();
            //npc.SetStatsEntity(StatType.Health, 20);

            while (GameRunning)
            {
                InputHandler.HandleInput();
            }
           
        }
    }
}
