using System;

namespace Calculate_Equality_Of_Two_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Points For Line One:");
            Console.WriteLine("Enter X1 ");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter X2 ");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y1 ");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y2 ");
            int Y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Points For Line Second:");
            Console.WriteLine("Enter A1 ");
            int A1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter A2 ");
            int A2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B1 ");
            int B1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B2 ");
            int B2 = Convert.ToInt32(Console.ReadLine());
            int X = X2 - X1;
            int Y = Y2 - Y1;
            int A = A2 - A1;
            int B = B2 - B1;
            if (X == A && Y == B)
            {
                Console.WriteLine("Two Lines Are Equal!!");
            }
            else
            {
                Console.WriteLine("Two Lines Are Not Equal!!");
            }
        }
    }
}
