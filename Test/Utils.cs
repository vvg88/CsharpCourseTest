using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    static class Utils
    {
        public static void PrintFibNumLessThenNum(uint number)
        {
            Console.Write("Числа Фибоначчи меньше числа " + number + ": ");
            uint firstFibNum = 0;
            uint secFibNum = 1;
            if (number != 0)
                Console.Write(firstFibNum + " ");

            while (secFibNum < number)
            {
                Console.Write(secFibNum + " ");
                uint next = firstFibNum + secFibNum;
                firstFibNum = secFibNum;
                secFibNum = next;
            }
            Console.WriteLine();
        }

        public static bool TryEnterNumFromConsole(out uint number)
        {
            Console.Write("Введите неотрицательное число: ");
            string numasStr = Console.ReadLine();

            if (!uint.TryParse(numasStr, out number))
            {
                Console.Write("It's not a number!");
                return false;
            }
            return true;
        }

        public static void PrintDoubleArray(double[] arrayForPrint)
        {
            for (int i = 0; i < arrayForPrint.Length; i++)
            {
                Console.Write(arrayForPrint[i].ToString("0.00") + " ");
            }
            Console.Write('\n');
        }
    }
}
