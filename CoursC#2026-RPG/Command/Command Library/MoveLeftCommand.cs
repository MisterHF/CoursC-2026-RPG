namespace CoursC_2026_RPG
{
    public class MoveLeftCommand : ICommand
    {
        private Player Player;
        
        public MoveLeftCommand(Player player)
        {
            Player = player;
        }

        public void Execute()
        {
            Player.Move(-1, 0);
        }
    }
}