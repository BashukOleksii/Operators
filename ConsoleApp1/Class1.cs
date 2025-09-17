using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangle
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Rectangle(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double S()
        {
            return X * Y;
        }
        public double P()
        {
            return 2 * (X + Y);
        }
        public void Show()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }



        public static Rectangle operator +(Rectangle rectangle, Rectangle rectangle1)
        {
            return new Rectangle(rectangle.X + rectangle1.X, rectangle.Y + rectangle1.Y);
        }

        public static Rectangle operator +(Rectangle rectangle, double num)
        {
            return new Rectangle(rectangle.X + num, rectangle.Y + num);
        }

        public static Rectangle operator +(double num, Rectangle rectangle)
        {
            return new Rectangle(rectangle.X + num, rectangle.Y + num);
        }

        public static Rectangle operator -(Rectangle rectangle, Rectangle rectangle1)
        {
            if (rectangle1.X > rectangle.X || rectangle1.Y > rectangle.Y)
                throw new Exception();
            return new Rectangle(rectangle.X - rectangle1.X, rectangle.Y - rectangle1.Y);
        }

        public static Rectangle operator -(Rectangle rectangle, double num)
        {
            if(num > rectangle.X || num > rectangle.Y )
                throw new Exception();
            return new Rectangle(rectangle.X - num, rectangle.Y - num);
        }

        public static Rectangle operator -(double num, Rectangle rectangle)
        {
            if(num < rectangle.X || num < rectangle.Y)
                throw new Exception();
            return new Rectangle(num - rectangle.X,num - rectangle.Y);
        }

    }
}
