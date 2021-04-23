﻿using System;

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
          // Delegate provades a way which tells whick method to be called wehn
          // an event is triggered
          // Delegate provides way to encapsulate the methods
          // Delegate tis ref type that provide reference to methods with particular parmeter list
          //and return type and then calls the methis in a program for execution when it si needed
          // Delegate may have zero or more input parameters and one out / oputput-return param
    }
}
