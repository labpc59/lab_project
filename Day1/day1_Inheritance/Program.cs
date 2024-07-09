namespace day1_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
             DerivedClass derivedClass =new DerivedClass();
            derivedClass.display();
            SubDerivedClass subDerivedClass = new SubDerivedClass();
            subDerivedClass.display(); // Display method from DerivedClass
        }

        public abstract class BaseClass
        {
            protected private int i = 19;
           // public int i1 { get; set; }
        }

        public abstract class DerivedClass : BaseClass
            {

           public abstract void display() { 
           
                Console.WriteLine(i);
            }

            }

        public class SubDerivedClass : DerivedClass
        {

             
                public override void display()
            {

                Console.WriteLine("hi"+i);
            }

        }
    }
}
