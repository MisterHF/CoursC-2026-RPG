using System;

namespace CoursC_2026_RPG
{
    public interface IAttack
    {
        int ExecuteAttack(Weapon weapon);
    }

    public class NormalAttack : IAttack
    {
        public int ExecuteAttack(Weapon weapon)
        {
            Console.WriteLine("normale");
            return weapon.GetDamage();
        }
    }

    public class CriticalAttack : IAttack
    {
        public int ExecuteAttack(Weapon weapon)
        {
            Console.WriteLine("critique");
            return weapon.GetDamage() * 2;
        }
    }

    public class SkillAttack : IAttack
    {
        private int bonus;

        public SkillAttack(int bonusDamage)
        {
            bonus = bonusDamage;
        }

        public int ExecuteAttack(Weapon weapon)
        {
            int damage = weapon.GetDamage() + bonus;
            Console.WriteLine($"{weapon.Name} utilise une competence : {damage} degat");
            return damage;
        }
    }
    public abstract class WeaponDecorator : Weapon
    {
        protected Weapon weapon;

        protected WeaponDecorator(Weapon weapon) : base(weapon.Name, weapon.Stats)
        {
            this.weapon = weapon;
        }
    }

    public class FireDecorator : WeaponDecorator
    {
        public FireDecorator(Weapon weapon) : base(weapon)
        {
            Console.WriteLine($"{weapon.Name} : +5 dégâts Feu appliqués");
            weapon.Stats.Add(StatType.Damage, 5);
        }
    }

    public class PoisonDecorator : WeaponDecorator
    {
        public PoisonDecorator(Weapon weapon) : base(weapon)
        {
            Console.WriteLine($"{weapon.Name} : +3 dégâts poison appliqués");
            weapon.Stats.Add(StatType.Damage, 3);
        }
    }
}
