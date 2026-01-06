namespace CoursC_2026_RPG
{
    using System;
    using System.Linq;

    namespace CoursC_2026_RPG
    {
        public static class EntityPlacer
        {
            private static readonly Random Random = new Random();

            public static void PlaceEntities(Map.Map map, int monsterCount, int npcCount, FactoryMonster monsterFactory, FactoryNpc npcFactory)
            {
                for (int i = 0; i < monsterCount; i++)
                {
                    var (x, y) = GetFreePosition(map);

                    Monster monster = monsterFactory.AsMonster()
                        .WithStat(StatType.Health, Random.Next(30, 100))
                        .WithPosition(x, y)
                        .Build();

                    map.Entities.Add(monster);
                }

                for (int i = 0; i < npcCount; i++)
                {
                    var (x, y) = GetFreePosition(map);

                    Pnj npc = npcFactory.AsNpc()
                        .WithStat(StatType.Health, Random.Next(10, 30))
                        .WithPosition(x, y)
                        .Build();

                    map.Entities.Add(npc);
                }
            }

            private static (int x, int y) GetFreePosition(Map.Map map)
            {
                int x, y;

                do
                {
                    x = Random.Next(0, map.Width);
                    y = Random.Next(0, map.Height);
                }
                while (
                    !map.Tiles[x, y].Walkable ||
                    map.Entities.Any(e => e.X == x && e.Y == y)
                );

                return (x, y);
            }
        }
    }

}