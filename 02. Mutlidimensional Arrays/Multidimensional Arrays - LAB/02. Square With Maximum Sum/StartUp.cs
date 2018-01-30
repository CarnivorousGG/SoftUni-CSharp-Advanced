using System;
using System.Linq;

    //Write a program that read a matrix from console.Then find biggest sum of 2x2 submatrix and print it to console.
    //On first line you will get matrix sizes in format rows, columns.
    //One next rows lines you will get elements for each column separated with coma.
    //Print biggest top-left square, which you find and sum of its elements.
namespace _02._Square_With_Maximum_Sum
{
    class StartUp
    {
        static void Main(string[] args)
        {

            int rowIndex = 0, columIndex = 0, sum = 0;

            int[] rowsAndColums = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[,] matrix = new int[rowsAndColums[0], rowsAndColums[1]]; //create the 2D matrix from user input 


            
            //we create 2 loops, 1 for the rows and the other for the colums in the matrix
            //this way we will be able to pass the user input into it
            for (int rows = 0; rows < rowsAndColums[0]; rows++)
            {
                var values = Console.ReadLine().
                    Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();


                for (int colums = 0; colums < rowsAndColums[1]; colums++)
                {
                    matrix[rows, colums] = values[colums];// this will populate the matrix
                }
            }

            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                for (int columns = 0; columns < matrix.GetLength(1) - 1; columns++)
                {

                    // this algorithm will sum the the 1st row and it's colums +1, because we are moving in a square
                    //the next iteration will sum the 2nd row and it;s columns + 1;
                    //in the for loops we are cycling until the length of the matrix - 1, this prevents us from going out of the 
                    //matrix and causing an indexOutOfRangeException
                    var tempSum = matrix[rows, columns] + matrix[rows, columns + 1]
                                  + matrix[rows + 1, columns] + matrix[rows + 1, columns + 1];

                    //get the max sum
                    if (tempSum > sum)
                    {
                        sum = tempSum;
                        rowIndex = rows; //we need these indexes to print out the sub-matrix with the largest result
                        columIndex = columns;
                    }

                }
            }

            Console.WriteLine(matrix[rowIndex, columIndex] + " " + matrix[rowIndex, columIndex + 1]);
            Console.WriteLine(matrix[rowIndex + 1, columIndex] + " " + matrix[rowIndex + 1, columIndex + 1]);
            Console.WriteLine(sum);

        }
    }
}
