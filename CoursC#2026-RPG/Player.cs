using System;

namespace CoursC_2026_RPG
{
    public class Player
    {
        public Weapon Weapon { get; set; }
        public IAttack Attack { get; set; }

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
            Console.WriteLine($"Moving to ({PlayerX}, {PlayerY})");
        }

        public void DoAttack()
        {
            if (Weapon == null)
            {
                Console.WriteLine("Pas d'arme équipée !");
                return;
            }

            if (Attack == null)
            {
                return;
            }

            int damage = Attack.ExecuteAttack(Weapon);
            Console.WriteLine($"Dégâts infligés : {damage}");
        }
    }
}
