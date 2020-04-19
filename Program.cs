using System;

namespace ClassTask3b
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int x = 1;
            do
            {
                Console.WriteLine("enter a number between 3 to 9");
                num = Convert.ToInt32(Console.ReadLine());
            }
            while (num < 3 || num > 9);
            int[][] matrix= new int[num][];
            for (int row = 0; row < matrix.Length; row++, x++)
            {
                matrix[row] = new int[row + 1];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = x;
                }
            }

        }
    }
}
