using System;
using System.Linq;

namespace _01._Sum_Matrix_Elements
{
    class StartUp
    {
        static void Main()
        {
            int[] rowsAndColums = Console.ReadLine()
                .Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[,] matrix = new int[rowsAndColums[0],rowsAndColums[1]]; //create the 2D matrix from user input 


            //we create 2 loops, 1 for the rows and the other for the colums in the matrix
            //this way we will be able to pass the user input into it
            for (int rows = 0; rows < rowsAndColums[0]; rows++)
            {
                var values = Console.ReadLine().
                    Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();


                for (int colums = 0; colums < rowsAndColums[1]; colums++)
                {
                    matrix[rows, colums] = values[colums];// this will add every number provided by the user to the matrix
                }
            }

            int sum = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    sum += matrix[rows, columns];
                }
            }

            Console.WriteLine(matrix.GetLength(0)); //number of rows
            Console.WriteLine(matrix.GetLength(1)); //number of colums
            Console.WriteLine(sum); 

        }
    }
}
