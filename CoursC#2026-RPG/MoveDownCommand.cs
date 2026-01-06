namespace CoursC_2026_RPG
{
    public class MoveDownCommand : ICommand
    {
        private Player _player;
        
        public MoveDownCommand(Player player)
        {
            _player = player;
        }

        public void Execute()
        {
            _player.Move(0, 1);
        }
    }
}