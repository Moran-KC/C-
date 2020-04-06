using System;

namespace Matala003
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] matrix = new string[3][];

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix.Length; col++)
                {
                    if (row == col && row + col == matrix.Length - 1)
                    {

                        Console.Write(" Center, ");
                    }
                    else if (row == col)
                    {

                        Console.Write(" main, ");
                    }
                    else if (row + col == matrix.Length - 1)
                    {

                        Console.Write(" sub, ");
                                            }
                    else if (row < col)
                    {

                        Console.Write(" up ,");
                    }
                    else
                    {
                        Console.Write(" down ,");
                    }  
                }
                Console.WriteLine();

            }
          }
    }
}
