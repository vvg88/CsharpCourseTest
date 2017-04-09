using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, CommandHandler> commands = new Dictionary<string, CommandHandler>
            {
                {"ShowFibonachi",  new FibonachiCommandHandler()},
                {"ShowRandomAndSort", new RandomAndSortCommandHandler()},
                {"ShowStringHandle", new StringHandleCommandHandler()}
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
