
//Create a simple program that can convert a decimal number to its binary representation.Implement an
//elegant solution using a Stack.
//Print the binary representation back at the terminal.

using System;
using System.Collections.Generic;

namespace _03._Decimal_to_Binary_Converter
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var inputNumber = int.Parse(Console.ReadLine());
            var inputToStack = new Stack<int>();

            if (inputNumber == 0) //if the integer is zero, just return a zero
            {
                Console.WriteLine(0);
                return; //we need to return otherwise the logic flow will continue
                
            }

            while (inputNumber > 0)
            {
                var numberToBinary = inputNumber; // created a temporary var to use it in division
                inputToStack.Push(numberToBinary % 2); // turning numbers to binary is done by diving by % 2, the remainders form the binary sequenced (they need to be reversed)
                inputNumber /= 2;
            }
            while (inputToStack.Count > 0)
            {
                Console.Write(inputToStack.Pop()); //output
            }
            Console.WriteLine();
        }
    }
}
