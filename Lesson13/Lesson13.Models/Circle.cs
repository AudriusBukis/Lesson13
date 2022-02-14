using System;

namespace Lesson13.Models
{
    public class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius < 0) Radius = 0;            
            else Radius = radius;
        }

        public double getArea()
        {
            return Radius * Radius * Math.PI;
        }
        public double getRadius()
        {
            return Radius;
        }
        
    }  
    
}
