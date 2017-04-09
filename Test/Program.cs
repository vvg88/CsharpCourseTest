using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Action> commands = new Dictionary<string, Action>
            {
                {"ShowFibonachi",  ShowFibonachi},
                {"ShowRandomAndSort", ShowRandomAndSort},
                {"ShowStringHandle", ShowStringHandle}
            };

            Console.WriteLine(@"Введите одну из трех команд:
ShowFibonachi
ShowRandomAndSort
ShowStringHandle");

            string command = Console.ReadLine();
            if (commands.ContainsKey(command))
                commands[command]();
            else
                Console.WriteLine("Команда введена неверно!");

            Console.ReadLine();
        }

        static void ShowFibonachi()
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

        static void ShowRandomAndSort()
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

        static void ShowStringHandle()
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
