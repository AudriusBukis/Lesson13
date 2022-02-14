using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson13.Models;
using Xunit;
namespace Lesson13.UnitTest
{
    public class RectangleTest
    {
        [Fact]
        public void Test_if_Declaring_With_Minus_Length_Return_Zero()
        {
            Rectangle rectangle = new Rectangle(-3.75, 4);

            Assert.True(rectangle.Length == 0);
        }
        [Fact]
        public void Test_if_Declaring_With_Minus_Width_Return_Zero()
        {
            Rectangle rectangle = new Rectangle(3.75, -4);

            Assert.True(rectangle.Width == 0);
        }
        [Fact]
        public void Test_if_Declaring_With_Minus_Width_And_Length_Return_Zero()
        {
            Rectangle rectangle = new Rectangle(-3.75, -4);

            Assert.True(rectangle.Width == 0 && rectangle.Length == 0);
        }

        [Fact]
        public void Test_if_Rectangle_Functions_Returs_Correct_Values()
        {
            Rectangle rectangle = new Rectangle(5, 10);

            Assert.Equal(10, rectangle.getWidth());   
            Assert.Equal(5, rectangle.getLength());
            Assert.Equal(50, rectangle.getArea());
        }

        
        
        
        
 
    }
}
