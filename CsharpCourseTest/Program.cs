using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CommandHandler> commands = new List<CommandHandler>
            {
                new FibonachiCommandHandler(),
                new RandomAndSortCommandHandler(),
                new StringHandleCommandHandler()
            };

            Console.WriteLine("Введите команду: ");
            foreach(var comm in commands)
            {
                Console.WriteLine(comm.CommandName);
            }
            string command = Console.ReadLine();

            var commHandler = commands.Find(handler => handler.CommandName == command);
            if (commHandler != null)
                commHandler.Run();
            else
                Console.WriteLine("Команда введена неверно!");

            Console.ReadLine();
        }
    }
}
