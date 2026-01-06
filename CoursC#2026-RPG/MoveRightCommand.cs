namespace CoursC_2026_RPG
{
    public class MoveRightCommand : ICommand
    {
        private Player _player;
        
        public MoveRightCommand(Player player)
        {
            _player = player;
        }

        public void Execute()
        {
            _player.Move(1, 0);
        }
    }
}