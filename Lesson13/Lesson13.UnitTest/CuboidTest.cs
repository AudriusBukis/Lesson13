using Lesson13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lesson13.UnitTest
{
    public class CuboidTest
    {

        [Fact]
        public void Test_if_Declaring_With_Minus_Length_Return_Zero()
        {
            Cuboid cuboid = new Cuboid(-5, 10, 5);

            Assert.True(cuboid.Length == 0);
        }
        [Fact]
        public void Test_if_Declaring_With_Minus_Width_Return_Zero()
        {
            Cuboid cuboid = new Cuboid(5, -10, 5);

            Assert.True(cuboid.Width == 0);
        }
        [Fact]
        public void Test_if_Declaring_With_Minus_Height_Return_Zero()
        {
            Cuboid cuboid = new Cuboid(5, 10, -5);

            Assert.True(cuboid.Height == 0);
        }
        [Fact]
        public void Test_if_Declaring_With_Minus_Width_And_Length_And_Height_Return_Zero()
        {
            Cuboid cuboid = new Cuboid(-5, -10, -5);

            Assert.True(cuboid.Width == 0 && cuboid.Length == 0 && cuboid.Height == 0);
        }
        [Fact]
        public void Test_if_Cuboid_Functions_Returs_Correct_Values()
        {
            Cuboid cuboid = new Cuboid(5, 10, 5);

            Assert.Equal(10, cuboid.getWidth());
            Assert.Equal(5, cuboid.getLength());
            Assert.Equal(50, cuboid.getArea());
            Assert.Equal(5, cuboid.getHeight());
            Assert.Equal(250, cuboid.getVolume());
        }

    }
}
