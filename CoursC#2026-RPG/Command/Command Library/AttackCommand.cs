using System;

namespace CoursC_2026_RPG
{
    public class AttackCommand : ICommand
    {
        private Player Player;

        public AttackCommand(Player player)
        {
            Player = player;
        }

        public void Execute()
        {
            Player.DoAttack(null);
        }
    }
}