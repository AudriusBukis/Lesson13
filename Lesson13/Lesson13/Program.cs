using Lesson13.Models;
using System;

namespace Lesson13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 13 task 1");
          
             Rectangle rectangle = new Rectangle(5, 10);
             Console.WriteLine("rectangle.width= " + rectangle.getWidth());
             Console.WriteLine("rectangle.length= " + rectangle.getLength());
             Console.WriteLine("rectangle.area= " + rectangle.getArea());
             Cuboid cuboid = new Cuboid(5,10,5);
             Console.WriteLine("cuboid.width= " + cuboid.getWidth());
             Console.WriteLine("cuboid.length= " + cuboid.getLength());
             Console.WriteLine("cuboid.area= " + cuboid.getArea());
             Console.WriteLine("cuboid.height= " + cuboid.getHeight());
             Console.WriteLine("cuboid.volume= " + cuboid.getVolume());
             /*
             → OUTPUT
             
             rectangle.width= 5.0
             rectangle.length= 10.0
             rectangle.area= 50.0
             cuboid.width= 5.0
             cuboid.length= 10.0
             cuboid.area= 50.0
             cuboid.height= 5.0
             cuboid.volume= 250.0
             
            */
            Circle circle = new Circle(3.75);
            Console.WriteLine($"circle.radius= {circle.getRadius()}");
            Console.WriteLine($"circle.area= {circle.getArea()}");
            Cylinder cylinder = new Cylinder(5.55, 7.25);
            Console.WriteLine($"cylinder.radius= {cylinder.getRadius()}");
            Console.WriteLine($"cylinder.height= {cylinder.getHeight()}");
            Console.WriteLine($"cylinder.area= {cylinder.getArea()}");
            Console.WriteLine($"cylinder.volume= {cylinder.getVolume()}");
            Console.ReadKey();
            /*
            → OUTPUT

            circle.radius= 3.75
            circle.area= 44.178646691106465
            cylinder.radius= 5.55
            cylinder.height= 7.25
            cylinder.area= 96.76890771219959
            cylinder.volume= 701.574580913447 */
            

        }
    }
}
