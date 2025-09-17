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

            for (int i = 0; i < 5; i++)
                --rectangle1;

            rectangle1.Show();
        }
    }
}