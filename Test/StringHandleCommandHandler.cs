using System;

namespace Test
{
    class StringHandleCommandHandler : CommandHandler
    {
        public StringHandleCommandHandler() : base("ShowStringHandle") { }

        protected override void run()
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();

            StringHelper strHelper = new StringHelper(str);

            Console.WriteLine($"{(strHelper.IsPolyndrome() ? "Является" : "Не является")} палиндромом");
            Console.WriteLine(string.Format("Количество слов: {0}", strHelper.GetCountWords()));
            Console.WriteLine($"Перевернутая строка: {strHelper.GetInverseString()}");
        }
    }
}
