using Lesson13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lesson13.UnitTest
{
    public class CylinderTest
    {
        [Fact]
        public void Test_if_Declaring_With_Minus_Radius_Return_Zero()
        {
            Cylinder cylinder1 = new Cylinder(-3.75, 4);

            Assert.True(cylinder1.Radius == 0);
        }
        [Fact]
        public void Test_if_Declaring_With_Minus_Height_Return_Zero()
        {
            Cylinder cylinder2 = new Cylinder(3.75, - 4);

            Assert.True(cylinder2.Height == 0);
        }

        [Fact]
        public void Test_if_Declaring_With_Minus_Height_And_Radius_Return_Zero()
        {
            Cylinder cylinder3 = new Cylinder(-3.75, -4);

            Assert.True(cylinder3.Height == 0 && cylinder3.Radius == 0);
        }

        [Fact]
        public void Test_if_Cylider_Functions_Returs_Correct_Values()
        {
            Cylinder cylinder4 = new Cylinder(5.55, 7.25); ;

            Assert.Equal(5.55, cylinder4.getRadius());
            Assert.Equal(96.76890771219959, cylinder4.getArea());
            Assert.Equal(7.25, cylinder4.getHeight());
            Assert.Equal(701.574580913447, cylinder4.getVolume());
            /*circle.radius = 3.75
            circle.area = 44.178646691106465
            cylinder.radius = 5.55
            cylinder.height = 7.25
            cylinder.area = 96.76890771219959
            cylinder.volume = 701.574580913447 */
        }
    }
}
