using System;

namespace CoursC_2026_RPG
{
    public class Player
    {
        public Weapon Weapon { get; set; }
        public IAttack AttackStrategy { get; set; }
        public Stats Stats { get; private set; } = new Stats();

        private int PlayerX;
        private int PlayerY;
        private Map.Map CurrentMap;

        public Player(int x = 0, int y = 0, Map.Map map = null)
        {
            PlayerX = x;
            PlayerY = y;
            CurrentMap = map;
        }

        public void Move(int dx, int dy)
        {
            int newX = PlayerX + dx;
            int newY = PlayerY + dy;

            if (CurrentMap == null || CanMove(newX, newY))
            {
                PlayerX = newX;
                PlayerY = newY;
                Console.WriteLine($"Player moved to ({PlayerX},{PlayerY})");
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

        public void DoAttack(Entity target)
        {
            if (Weapon == null || AttackStrategy == null)
            {
                Console.WriteLine("Impossible d'attaquer !");
                return;
            }

            int damage = AttackStrategy.ExecuteAttack(Weapon);

            int finalDamage = Math.Max(0, damage - target.Stats.Get(StatType.Defense));
        }
        public override string ToString() => $"Player({PlayerX},{PlayerY})";

        public int X => PlayerX;
        public int Y => PlayerY;
    }
}
