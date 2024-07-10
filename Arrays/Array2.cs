using System.Collections.Generic;

namespace Arrays2
{
    internal class Program2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            string[] array=new string[4];
          
            for (int i = 0; i < array.Length-1; i++)
            {
                Console.WriteLine("arr[{0}]", i);
                array[i]=Console.ReadLine();
                 

            }
                foreach (string name in array)
                {
                    Console.WriteLine(name + " ");
                }
        }
    }
}

