using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> add = Sum;
            int result = add(10, 10);
            Console.WriteLine(result);
        }
        static int Sum(int x, int y) 
        {
            return x + y;
        } // Delegate is variable that points to a method, it is reference type,
          // Delegate provides a way which tells which method to be called when
          // an event is triggered
          // Delegate provides way to encapsulate the methods
          // Delegate is ref type that provide reference to methods with particular parmeter list
          //and return type and then calls the methods in a program for execution when it is needed
          // Delegate may have zero or more input parameters and one out / oputput-return param
    }
}
