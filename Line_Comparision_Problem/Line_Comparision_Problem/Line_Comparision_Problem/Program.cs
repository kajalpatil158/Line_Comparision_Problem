using System;

namespace Calculate_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            double Length_Of_Line;
            Console.WriteLine("Enter X1 ");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter X2 ");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y1 ");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y2 ");
            int Y2 = Convert.ToInt32(Console.ReadLine());
            Length_Of_Line = (Math.Sqrt((X2 - X1) ^ 2 + (Y2 - Y1) ^ 2));
            //Console.WriteLine(Math.Sqrt(Length_Of_Line));
            Console.WriteLine("Lenth of line is {0}", Length_Of_Line);
        }
    }
}
