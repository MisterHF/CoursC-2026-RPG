using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursC_2026_RPG
{
    public class Monster : IEntity
    {
        public Entity CreateEntity()
        {
            Console.WriteLine("Monster Created");
            Entity monster = new Entity();
            monster.SetType(EntityType.Monster);
            return monster;
        }
    }
}
