using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int Row, Column;
        input_Row:
            {
                Console.Write("Input Row of Matrix:");
                if (int.TryParse(Console.ReadLine(), out Row) == false || Row <= 0)
                {
                    Console.Write("Input Error!, only int and Row >= 0\n");
                    goto input_Row;
                }

            }
        input_Column:
            {
                Console.Write("Input Column of Matrix:");
                if (int.TryParse(Console.ReadLine(), out Column) == false || Column <= 0)
                {
                    Console.Write("Input Error!, only int and Column >= 0\n");
                    goto input_Column;
                }
            }
            // Nhập ma trận
            int[,] Matrix = new int[Row, Column];
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                input_Matrix:
                    {
                        Console.Write("Input Matrix[{0}][{1}]:", i, j);
                        if (int.TryParse(Console.ReadLine(), out Matrix[i, j]) == false)
                        {
                            Console.Write("Input Error, only int!\n");
                            goto input_Matrix;
                        }
                    }
                }
            }
            //In ma trận
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
