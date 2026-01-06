namespace CoursC_2026_RPG
{
    public class MoveRightCommand : ICommand
    {
        private Player Player;
        
        public MoveRightCommand(Player player)
        {
            Player = player;
        }

        public void Execute()
        {
            Player.Move(1, 0);
        }
    }
}