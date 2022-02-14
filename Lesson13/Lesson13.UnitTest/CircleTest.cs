using Lesson13.Models;
using System;
using Xunit;

namespace Lesson13.UnitTest
{
    public class CircleTest
    {
        [Fact]
        public void Test_if_Declaring_With_Minus_Radius_Return_Zero()
        {
            Circle circle = new Circle(-3.75);

            Assert.True(circle.Radius == 0);    
        }

        [Fact]
        public void Test_if_Cylider_Functions_Returs_Correct_Values()
        {
            Circle circle = new Circle(5.55); ; ;

            Assert.Equal(5.55, circle.getRadius());
            Assert.Equal(96.76890771219959, circle.getArea());
            
        }
    }
}
