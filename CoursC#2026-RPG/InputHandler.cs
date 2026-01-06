using System;
using System.Collections.Generic;

namespace CoursC_2026_RPG
{
    public class InputHandler
    {
        private Dictionary<ConsoleKey, ICommand> _commands;

        public InputHandler(Player player)
        {
            _commands = new Dictionary<ConsoleKey, ICommand>
            {
                { ConsoleKey.Z, new MoveUpCommand(player) },
                { ConsoleKey.S, new MoveDownCommand(player) },
                { ConsoleKey.Q, new MoveLeftCommand(player) },
                { ConsoleKey.D, new MoveRightCommand(player) }
            };
        }

        public void HandleInput()
        {
            if (!Console.KeyAvailable) return;

            var key = Console.ReadKey(true).Key;
            if (_commands.ContainsKey(key))
                _commands[key].Execute();
        }
    }

}