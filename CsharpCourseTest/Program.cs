using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var fibHandler = new FibonachiCommandHandler();
            var randAndSortHandler = new RandomAndSortCommandHandler();
            var strHandler = new StringHandleCommandHandler();

            Dictionary<string, CommandHandler> commands = new Dictionary<string, CommandHandler>
            {
                {fibHandler.CommandName,  fibHandler},
                {randAndSortHandler.CommandName, randAndSortHandler},
                {strHandler.CommandName, strHandler}
            };

            Console.WriteLine("Введите команду: ");
            foreach(var comm in commands)
            {
                Console.WriteLine(comm.Key);
            }
            string command = Console.ReadLine();

            if (commands.ContainsKey(command))
                commands[command].Run();
            else
                Console.WriteLine("Команда введена неверно!");

            Console.ReadLine();
        }
    }
}
