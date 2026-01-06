using System;
using System.Collections.Generic;

namespace CoursC_2026_RPG
{
    public class InputHandler
    {
        private Dictionary<ConsoleKey, ICommand> Commands;

        public InputHandler(Player player)
        {
            Commands = new Dictionary<ConsoleKey, ICommand>
            {
                { ConsoleKey.Z, new MoveUpCommand(player) },
                { ConsoleKey.S, new MoveDownCommand(player) },
                { ConsoleKey.Q, new MoveLeftCommand(player) },
                { ConsoleKey.D, new MoveRightCommand(player) }
            };
        }

        public bool HandleInput(ConsoleKey key)
        {
            if (Commands.ContainsKey(key))
            {
                Commands[key].Execute();
                return true;
            }
            return false;
        }
    }

}