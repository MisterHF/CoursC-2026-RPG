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
            FactoryNpc factoryNpc = new FactoryNpc();
            FactoryMonster factoryMonster = new FactoryMonster();


            Monster monster = factoryMonster.AsMonster()
                .WithStat(StatType.Health, 1000)
                .WithStat(StatType.Damage, 30)
                .Build();

            Pnj npc = factoryNpc.AsNpc()
                .WithStat(StatType.Health, 20)
                .WithStat(StatType.Damage, 5)
                .Build();

            Console.WriteLine($"{monster.GetType().Name} - Health: {monster.Stats.Get(StatType.Health)}, Damage: {monster.Stats.Get(StatType.Damage)}");
            Console.WriteLine($"{npc.GetType().Name} - Health: {npc.Stats.Get(StatType.Health)}, Damage: {npc.Stats.Get(StatType.Damage)}");


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
            Weapon sword = new Sword("Épée du dragon", 12);
            sword = new PoisonDecorator(sword);
            sword = new FireDecorator(sword);

            Player player = new Player(0, 0)
            {
                Weapon = sword,
                AttackStrategy = new NormalAttack()
            };

            Player enemy = new Player(5, 5);
            enemy.Stats.Set(StatType.Defense, 8);

            player.DoAttack(null); 
            player.AttackStrategy = new CriticalAttack();
            player.DoAttack(null); 
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

    public class FactoryNpc
    {
        private Pnj entity;

        public FactoryNpc AsNpc()
        {
            entity = new Pnj();
            entity.Stats.Set(StatType.Health, 1);
            return this;
        }

        public FactoryNpc WithStat(StatType stat, int value)
        {
            entity.Stats.Set(stat, value);
            return this;
        }

        public FactoryNpc WithPosition(int x, int y)
        {
            entity.SetPosition(x, y);
            return this;
        }
        public FactoryNpc WithItem(Item item, StatType stat, int value)
        {
            item.Stats.Set(stat, value);
            return this;
        }

        public Pnj Build()
        {
            return entity;
        }
    }

    public class FactoryMonster
    {
        private Monster entity;

        public FactoryMonster AsMonster()
        {
            entity = new Monster();
            entity.Stats.Set(StatType.Health, 1);
            return this;
        }

        public FactoryMonster WithStat(StatType stat, int value)
        {
            entity.Stats.Set(stat, value);
            return this;
        }

        public FactoryMonster WithPosition(int x, int y)
        {
            entity.SetPosition(x, y);
            return this;
        }
        public FactoryMonster WithItem(Item item, StatType stat, int value)
        {
            item.Stats.Set(stat, value);
            return this;
        }

        public Monster Build()
        {
            return entity;
        }
    }
}


