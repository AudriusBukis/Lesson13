using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.Models
{
    public class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            if (length < 0) Length = 0;
            else Length = length;
            if (width < 0) Width = 0;
            else Width = width;
        }
        public double getLength()
        {
            return Length;
        }
        public double getWidth()
        {
            return Width;
        }
        public double getArea()
        {
            return Length * Width;
        }
    }
}
