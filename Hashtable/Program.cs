using System.Collections;
using System.Security.Cryptography;
namespace HashtableProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Hashtable o = new Hashtable();
            SortedList o= new SortedList();
            o.Add(1, 'A');
            o.Add(2, 'B');
            o.Add(3, 'C');
            o.Add(4, 'D');
            o.Add(5, 'E');
            o.Add(6, 'F');
            o.Add(7, 'G');
            o.Add(8, 'H');
            o.Add(9, 'I');
            o[0] = 'S';
            o[0] = "SHREYAS";
           o.
            //foreach (var s in o )
            //{
            //    Console.WriteLine(s);
            //}
            foreach ( DictionaryEntry s in o)
            {
                Console.WriteLine(s.Key);
                Console.WriteLine(s.Value);

            }
        }
    }
}