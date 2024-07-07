using n1;
using n1.n1_1;
using System;
namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main");
            Class1 o;
            o=new Class1();
            o.MC1();
            Class2 a = new Class2();
            a.MC2();
            Class4 result=new Class4();
            result.add(4, 5, 3);
            result.add(c:4);
        }
    }
}
namespace n1 {

    public class Class1 {
            public void MC1 ()
        {
            Console.WriteLine("class 1");
        }
             
}
    public class Class2 {
        int x = 100;
        public void MC2() 
        {
            Console.WriteLine("class 2");
            Console.WriteLine(++x);
        }
    }
    namespace n1_1
    {
        class Class3 
        {
            public void MC3()
            {
                Console.WriteLine("class 3");

            }
        }

        class Class4
        {
            public void add(int a= 0, int b=0,int c=0)
            {
                int x = a + b + c;
                Console.WriteLine(x);

            }
        }

    }

}
