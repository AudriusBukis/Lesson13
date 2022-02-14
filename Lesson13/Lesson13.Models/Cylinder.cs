using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.Models
{
    public class Cylinder : Circle
    {
        public double Height { get; set; }
        public Cylinder(double radius, double height) : base(radius)
        {
            if (height < 0) Height = 0; 
            else Height = height;
        }
        public double getHeight()
        {
            return Height;
        }
        public double getVolume()
        {
            return getArea() * Height;
        }

    }
}
