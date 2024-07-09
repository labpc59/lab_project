using System.Collections.Generic;

namespace Arrays2
{
    internal class Program2
    {
        static void Main2(string[] args)
        {

            Console.WriteLine("Hello, World!");

            string[] array = { "shreyas", "Ramdas", "Damase" };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");

                foreach (string name in array)
                {
                    Console.Write(name + " ");
                }
            }
        }
    }
}

