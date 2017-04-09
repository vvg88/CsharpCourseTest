using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class StringHelper
    {
        public StringHelper(string inputString)
        {
            this.inputString = inputString;
        }

        private string inputString;

        public bool IsPolyndrome()
        {
            if (inputString == null)
                return false;

            return inputString == GetInverseString();
        }

        public uint GetCountWords()
        {
            if (inputString == null)
                return 0;

            List<char> sepsArr = new List<char>();
            foreach (char ch in inputString)
            {
                if (!char.IsLetterOrDigit(ch) && !sepsArr.Contains(ch))
                    sepsArr.Add(ch);
            }
            Console.WriteLine(string.Join("", sepsArr));

            string[] words = inputString.Split(sepsArr.ToArray());

            uint cnt = 0;
            foreach (string str in words)
            {
                if (!string.IsNullOrEmpty(str))
                    cnt++;
            }
            return cnt;
        }

        public string GetInverseString()
        {
            if (inputString == null)
                return string.Empty;
            StringBuilder resultB = new StringBuilder();
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                resultB.Append(inputString[i]);
            }
            return resultB.ToString();
        }
    }
}
