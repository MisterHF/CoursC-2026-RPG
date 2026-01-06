using System;

namespace CoursC_2026_RPG
{
    public class MoveDownCommand : ICommand
    {
        private Player Player;
        
        public MoveDownCommand(Player player)
        {
            Player = player;
        }

        public void Execute()
        {
            Player.Move(0, 1);
        }
    }
}