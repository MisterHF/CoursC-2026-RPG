using System;

namespace CoursC_2026_RPG
{
    class CreateWeapon
    {
        public static T Create<T>(string name, int baseDamage)
            where T : Weapon
        {
            T weapon = (T)Activator.CreateInstance(typeof(T), name, baseDamage);
            return weapon;
        }
    }
}
