using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursC_2026_RPG
{
    public class Pnj : IEntity
    {
        public Entity CreateEntity()
        {
            Console.WriteLine("Pnj Created");
            Entity npc = new Entity();
            npc.SetType(EntityType.NPC);
            return npc;
        }
    }
}
