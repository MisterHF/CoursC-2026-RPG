namespace CoursC_2026_RPG
{
    public class MoveUpCommand : ICommand
    {
        private Player Player;
        
        public MoveUpCommand(Player player)
        {
            Player = player;
        }

        public void Execute()
        {
            Player.Move(0, -1);
        }
    }
}