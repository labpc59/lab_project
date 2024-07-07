using System.Diagnostics.Metrics;
using System;

namespace Day1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            class1 Class1=new class1();
            Class1.Display();
            class1.DisplayStaic();
        }


        public class class1 
        {
            public  int h;
            public static int i;

        public static int j=5;
            public void Display() 
            {
                System.Console.WriteLine(h);
                System.Console.WriteLine(i);//from nonStatic function we can access static members 
                System.Console.WriteLine(j);

            }
            public static void DisplayStaic()
            {
                 //System.Console.WriteLine(h);//but from staicfunction we can not access non Static members 
                  //Error   An object reference is required for the non-static field, method, or property 'Program.class1.h' 
                 //so here conclusion by static function we can onely access static member 
                System.Console.WriteLine(i);
                System.Console.WriteLine(j);

            }
        }
        public static class Class2 
        {
            private static int i ;//compolsory to make it as staic cause if not it will not goin to access by static property 
            public static int I 
            {
                set {
                    i=value;
                }
                get { return i; }
            }
        }
    }
}
// when static constructor get called ans: when class get loaded in to the memory 
//when class get loaded into memory ans: when the first object is created or static member is access first time