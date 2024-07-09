namespace day1_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // DerivedClass derivedClass =new DerivedClass();
            //derivedClass.display();
            SubDerivedClass subDerivedClass = new SubDerivedClass();
            subDerivedClass.display(); // Display method from DerivedClass
        }

        public abstract class BaseClass
        {
            protected   int i = 19;
           // public int i1 { get; set; }
        }

        public abstract class DerivedClass : BaseClass
            {

            public abstract void display();//abstract method should not have body the are meant to be override 

        }

        public class SubDerivedClass : DerivedClass
        {

             
                public override void display()
            {

                Console.WriteLine("hi"+i);
            }

        }
        /*
        public abstract class DerivedClass : BaseClass
        {

            public void display() { } 

        }

        public class SubDerivedClass : DerivedClass
        {


            public new void display()
            {

                Console.WriteLine("hi" + i);
            }

        }*/
    }
}
