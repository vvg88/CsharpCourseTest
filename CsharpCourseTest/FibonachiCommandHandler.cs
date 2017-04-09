using System;

namespace Test
{
    class FibonachiCommandHandler : CommandHandler
    {
        public FibonachiCommandHandler() : base("ShowFibonachi") { }

        protected override void run()
        {
            uint num1, num2, num3;
            if (!Utils.TryEnterNumFromConsole(out num1) ||
                !Utils.TryEnterNumFromConsole(out num2) ||
                !Utils.TryEnterNumFromConsole(out num3))
            {
                Console.Read();
                return;
            }

            var min = Math.Min(Math.Min(num1, num2), num3);
            Console.Write("Наименьшее число: ");
            Console.WriteLine(min);

            Utils.PrintFibNumLessThenNum(num1);
            Utils.PrintFibNumLessThenNum(num2);
            Utils.PrintFibNumLessThenNum(num3);
        }
    }
}
