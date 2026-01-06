namespace CoursC_2026_RPG
{
    public class MoveUpCommand : ICommand
    {
        private Player _player;
        
        public MoveUpCommand(Player player)
        {
            _player = player;
        }

        public void Execute()
        {
            _player.Move(0, -1);
        }
    }
}