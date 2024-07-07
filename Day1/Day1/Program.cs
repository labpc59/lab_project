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

            // Example usage of Class7
            Class7 class7 = new Class7();
            class7.I = 11;
            Console.WriteLine(class7.I);

            // Set class7 to null and call GC.Collect
            class7 = null;

            // Force garbage collection and wait for finalizers
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // Adding a longer delay to ensure finalization
            System.Threading.Thread.Sleep(1000); // 1 second delay

            Console.WriteLine("Garbage collection complete");
        }
    }
}

namespace n1
{
    public class Class1
    {
        public void MC1()
        {
            Console.WriteLine("class 1");
        }
    }

    public class Class2
    {
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
            public void add(int a = 0, int b = 0, int c = 0)
            {
                int x = a + b + c;
                Console.WriteLine(x);
            }
        }

        class Class5
        {
            int i = 0;
            public void setI(int i)
            {
                this.i = i;
            }
            public int getI()
            {
                return i;
            }
        }

        class Class6
        {
            int i = 0;
            public int I
            {
                set
                {
                    if (value < 10)
                    {
                        i = value;
                    }
                    else Console.WriteLine("EXCEPTION");
                }
                get
                {
                    return i;
                }
            }
        }

        public class Class7
        {
            public int I { get; set; }

            ~Class7()
            {
                Console.WriteLine("inside destructor");
            }
        }
    }
}
