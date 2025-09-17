using System;
using System.Collections.Specialized;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(5, 10);
            Rectangle rectangle2 = new Rectangle(30, 20);

            Console.WriteLine(rectangle2 == rectangle1);
            Console.WriteLine(rectangle2 >= rectangle1);
            Console.WriteLine(rectangle2 <= rectangle1);
            Console.WriteLine(rectangle2 > rectangle1);
            Console.WriteLine(rectangle2 < rectangle1);
            Console.WriteLine(rectangle2 != rectangle1);
        }
    }
}