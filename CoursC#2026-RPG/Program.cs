using System;

namespace CoursC_2026_RPG
{
    internal class Program
    {
        private static bool GameRunning = true;
        private static Player Player = new Player(0, 0);
        private static InputHandler InputHandler = new InputHandler(Player);
        static void Main()
        {
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


            while (GameRunning)
            {
                InputHandler.HandleInput();
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


