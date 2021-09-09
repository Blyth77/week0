using System;
using System.IO;
using Xunit;

namespace week0.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void divisable_by_Four()
        {
            // Arrange 
            bool not_div_four, is_div_four;

            // Act 
            Program.Main(new string[0]);
            not_div_four = Program.IsLeapYear(5);
            is_div_four = Program.IsLeapYear(4);

            // Assert
            Assert.False(not_div_four); 
            Assert.True(is_div_four); 
        }

        [Fact]
        public void divisable_by_100_Not_Leap_Year()
        {
            bool is_div_100 = Program.IsLeapYear(100);

            Assert.False(is_div_100); 
        }

        [Fact]
        public void divisable_by_400_Is_Leap_Year()
        {
            bool is_div_400 = Program.IsLeapYear(400);

            Assert.True(is_div_400); 
        }
    }
}
