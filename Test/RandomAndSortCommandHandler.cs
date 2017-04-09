using System;

namespace Test
{
    class RandomAndSortCommandHandler : CommandHandler
    {
        public RandomAndSortCommandHandler() : base("ShowRandomAndSort") { }

        protected override void run()
        {
            uint arrLength;
            if (!Utils.TryEnterNumFromConsole(out arrLength))
            {
                Console.Read();
                return;
            }

            double[] array = new double[arrLength];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.NextDouble() * 100;
            }

            Console.Write("Несортированный массив: ");
            Utils.PrintDoubleArray(array);

            for (int j = array.Length - 1; j > 0; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        double tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                    }
                }
            }
            Console.Write("Cортированный массив: ");
            Utils.PrintDoubleArray(array);
        }
    }
}
