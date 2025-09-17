using System;
using System.Collections.Specialized;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(10, 10);
            Rectangle rectangle2 = new Rectangle(30, 20);

            Rectangle rectangle =  rectangle1 - rectangle2;
            rectangle.Show();
        }
    }
}