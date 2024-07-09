    using System.Collections.Generic;

    namespace Arrays
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Hello, World!");

               // string [] array = { "shreyas", "Ramdas", "Damase" };
               // for (int i = 0; i < array.Length; i++) { 
               // Console.Write(array[i]);
                //Console.Write(" ");


                    List<string> fullName=new List<string>();
                    fullName.Add("shreyas");
                    fullName.Add("Ramdas");
                    fullName.Add("Damase");
                fullName.Add("Bokya");
                foreach (string name in fullName)
                            {
                        Console.Write(name+" ");
                            }
                }
            }
        }
 
