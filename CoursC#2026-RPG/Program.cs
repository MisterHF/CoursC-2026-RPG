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
            //Entity entity = new Entity();
            //entity.CreateEntity();
            //entity.SetStatsEntity(StatType.Health, 100);

            Weapon mySword = CreateWeapon.Create<Sword>("Épée du dragon", 12);
            mySword = new PoisonDecorator(mySword);
            mySword = new FireDecorator(mySword);

            Player player = new Player(0, 0)
            {
                Weapon = mySword,
                Attack = new NormalAttack()
            };

            player.DoAttack(); 

            player.Attack = new CriticalAttack();
            player.DoAttack(); 

            while (GameRunning)
            {
                InputHandler.HandleInput();
            }

        }
    }
}
