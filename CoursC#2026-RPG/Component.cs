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

    public abstract class Weapon
    {
        public abstract int GetDamage();
    }

    public abstract class WeaponDecorator : Weapon
    {
        protected Weapon weapon;

        protected WeaponDecorator(Weapon weapon)
        {
            this.weapon = weapon;
        }
    }

    public class FireDecorator : WeaponDecorator
    {
        public FireDecorator(Weapon weapon) : base(weapon) { }

        public override int GetDamage()
        {
            Console.WriteLine("Feu");
            return weapon.GetDamage() + 5;
        }
    }

    public class PoisonDecorator : WeaponDecorator
    {
        public PoisonDecorator(Weapon weapon) : base(weapon) { }

        public override int GetDamage()
        {
            Console.WriteLine("Poison");
            return weapon.GetDamage() + 3;
        }
    }

    //public class Player
    //{
    //    public IAttack Attack { get; set; }
    //    public Weapon Weapon { get; set; }

    //    public void DoAttack()
    //    {
    //        int damage = Attack.ExecuteAttack(Weapon);
    //        Console.WriteLine($"Degat : {damage}");
    //    }
    //}
}
