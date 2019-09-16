using System;

namespace ToneLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string replace(string item, char delimiter, char selection)
        {

            char[] array = item.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == delimiter)
                {
                    array[i] = selection;
                }
            }

            string newItem = new string(array);

            return newItem;

        }
    }
}
