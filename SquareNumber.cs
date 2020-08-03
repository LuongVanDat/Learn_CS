using System;

namespace LuyenTap
{
    class SquareNumber
    {
        static int squareNumber(int n)
        {
            int data = Math.Abs(n);
            int level = 1;
            int sum = 0;
            while(data != 0)
            {
                int temp = data % 10;
                sum = ((temp * temp) * level) + sum;
                level = temp > 3 ? level * 100 : level * 10;
                data /= 10;
            }
            return n < 0 ? sum * -1 : sum; 
        }
        static void Main(string[] args)
        {
            int n = 207;

            Console.WriteLine(n + "=>" +squareNumber(n));
        }
    }
}
