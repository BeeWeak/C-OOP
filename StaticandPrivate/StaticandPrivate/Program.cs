using System;

namespace StaticandPrivate
{


    public class Example
    {
        //constructor
        private static int Counter;
        private Example()
        {
            Counter = 10;

        }

        public static int GetCounter()
        {
            return ++Counter;
        }


        //static constructor        
        static Example()
        {
            Counter = 20;
        }

        public Example(int counter)
        {
            Counter = Counter + counter;
        }

        public class NestedExample
        {
            public void Test()
            {
                //internal instance
                Example ex = new Example();
                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //external reference
            Example ex = new Example(10);
            Console.WriteLine("Counter: {0} ", Example.GetCounter());

            Console.ReadKey();
        }
    }
}
