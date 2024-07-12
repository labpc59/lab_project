using static GenericClass.Program;

namespace GenericClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] arr1 = { 1, 2 };
            string [] arr2 = { "SHREE", "OOOM" };
            char [] arr3 = { 'A', 'B' };
            
            myGenericClass<int> temp1 = new myGenericClass<int>();
            temp1.display(arr1);
            temp1.swap(ref arr1[0],ref  arr1[1]);
            temp1.display(arr1);

            myGenericClass<string> temp2 = new myGenericClass<string>();
            temp2.display(arr2);
            temp2.swap(ref arr2[0], ref arr2[1]);
            temp2.display(arr2);

            myGenericClass<char> temp3 = new myGenericClass<char>();
            temp3.display(arr3);
            temp3.swap(ref arr3[0], ref arr3[1]);
            temp3.display(arr3);


        }


        public class myGenericClass<T>
        {
            public void swap(ref T i,ref T j )
        {
                T temp = i;
                i=j; j=temp;


            }
            public void display( T[] arr)
            {
            foreach (T i in arr)
            {
                Console.WriteLine(i);
            }
            }



    }
    }
}


//notes:
//The where keyword in C# is used to specify constraints on the types that can be used as arguments for a generic type or method. There are several kinds of constraints you can apply, such as requiring a type to be a class, a struct, have a parameterless constructor, inherit from a specific base class, or implement a specific interface.

//Here's an overview of different where constraints along with examples:

//Reference Type Constraint (where T : class):

//Specifies that the type argument must be a reference type.
//Value Type Constraint (where T : struct):

//Specifies that the type argument must be a value type.
//Parameterless Constructor Constraint (where T : new()):

//Specifies that the type argument must have a parameterless constructor.
//Base Class Constraint (where T : BaseClass):

//Specifies that the type argument must inherit from a specified base class.
//Interface Constraint(where T : ISomeInterface):

//Specifies that the type argument must implement a specified interface.
//Multiple Constraints:

//You can combine multiple constraints on a single type argument.

//Reference Type Constraint:

//public class MyClass<T>
//    where T : class
//{
//    // T must be a reference type
//    public void DoSomething(T obj)
//    {
//        Console.WriteLine(obj.ToString());
//    }
//} 


//Value Type Constraint:

//public class MyStructClass<T>
//    where T : struct
//{
//    // T must be a value type
//    public void DoSomething(T obj)
//    {
//        Console.WriteLine(obj.ToString());
//    }
//}

//Parameterless Constructor Constraint:

//public class MyNewClass<T>
//    where T : new()
//{
//    // T must have a parameterless constructor
//    public T CreateInstance()
//    {
//        return new T();
//    }
//}

//Base Class Constraint:
//public class MyBaseClass
//{
//    public void BaseMethod() { }
//}

//public class MyDerivedClass<T>
//    where T : MyBaseClass
//{
//    public void UseBaseMethod(T obj)
//    {
//        obj.BaseMethod();
//    }
//}
 
//Interface Constraint:
//public interface IMyInterface
//{
//    void MyMethod();
//}

//public class MyInterfaceClass<T>
//    where T : IMyInterface
//{
//    public void CallMyMethod(T obj)
//    {
//        obj.MyMethod();
//    }
//}

//Multiple Constraints:
//public class MultipleConstraintsClass<T>
//    where T : class, IMyInterface, new()
//{
//    public void UseConstraints(T obj)
//    {
//        obj.MyMethod(); // T must implement IMyInterface
//        var instance = new T(); // T must have a parameterless constructor
//        Console.WriteLine(instance.ToString()); // T must be a reference type
//    }
//}

