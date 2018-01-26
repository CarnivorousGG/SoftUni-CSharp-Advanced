using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace _02._Simple_Calculator
{

//Create a simple calculator that can evaluate simple expressions with only addition and subtraction.There will not
//be any parentheses.
//Solve the problem using a Stack.
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            var inputToStack = new Stack<string>(input.Reverse()); // when we push the input string array to a stack all of the elements will be reversed
                                                                   // this is why we are using the LINQ function to again reverse the strings in the stack

            

            while (inputToStack.Count > 1) 
            {
                var leftOperator = int.Parse(inputToStack.Pop()); // we need to pass the string to an integer in order to perform our operand
                var operand = inputToStack.Pop();
                var rightOperand = int.Parse(inputToStack.Pop());

                switch (operand)
                {
                    case "+": //when we have + between two numbers they will be summed
                        inputToStack.Push((leftOperator + rightOperand).ToString()); //because C# doesn't allow us to use an integer we need to transform the result into a string
                        break;
                    case "-": //when we have - between two numbers they will be subtracted
                        inputToStack.Push((leftOperator - rightOperand).ToString());
                        break;
                }
            }

            Console.WriteLine(inputToStack.Pop()); //print the result
        }
    }
}
