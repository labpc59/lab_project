using System.Numerics;

namespace Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {


            while (true) 
            {
            
            try
            {
                Console.WriteLine("Hello, World!");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(a);
                    break;
            }
            catch {
                Console.WriteLine("Exception occure");

            }
            }
        }
        
    }
}
