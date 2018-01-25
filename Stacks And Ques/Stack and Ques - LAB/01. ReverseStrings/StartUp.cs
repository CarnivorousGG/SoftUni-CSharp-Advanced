using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
//Write program that:
// Reads an input string
// Reverses it using a Stack&lt;T&gt;
// Prints the result back at the terminal
   public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var stackReversed = new Stack<char>(input); //push the string input into a char stack

            while (stackReversed.Count > 0)
            {
                Console.Write(stackReversed.Pop()); //due to the nature of the stack data sructure, when we pop each element they will be reversed
                                                    // and we do not need to perform any other functions
            }

            Console.ReadLine();
        }
    }
}
