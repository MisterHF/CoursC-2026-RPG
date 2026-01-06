namespace CoursC_2026_RPG
{
    public class MoveLeftCommand : ICommand
    {
        private Player _player;
        
        public MoveLeftCommand(Player player)
        {
            _player = player;
        }

        public void Execute()
        {
            _player.Move(-1, 0);
        }
    }
}