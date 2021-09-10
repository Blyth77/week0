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

        [Fact]
        public void Main_prints_Greeting()
        {
            // Arrange 
            var writer = new StringWriter();
            Console.SetOut(writer);
            
            // Act 
            Program.Main(new string[0]);

            // Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Please type a number and press 'Enter'!", output);
        
        }

        [Fact]
        public void Main_prints_Yay()
        {
            // Arrange 
            var writer = new StringWriter();
            Console.SetOut(writer);
            
            // Act 
            Console.SetIn(new StringReader("1600"));
            Program.Main(new string[0]);
            writer.Flush();

            // Assert
            var output = writer.GetStringBuilder().ToString().Split("\n");
            Assert.Equal("Yay!", output[1]);
        }

        [Fact]
        public void Main_prints_Nay()
        {
            // Arrange 
            var writer = new StringWriter();
            Console.SetOut(writer);
            
            // Act 
            Console.SetIn(new StringReader("1999"));
            Program.Main(new string[0]);
            writer.Flush();

            // Assert
            var output = writer.GetStringBuilder().ToString().Split("\n");
            Assert.Equal("Nay!", output[1]);
        }

        [Fact]
        public void Main_prints_Not_Valid_Year()
        {
            // Arrange 
            var writer = new StringWriter();
            Console.SetOut(writer);
            
            // Act 
            Console.SetIn(new StringReader("hey"));
            Program.Main(new string[0]);
            writer.Flush();

            // Assert
            var output = writer.GetStringBuilder().ToString().Split("\n");
            Assert.Equal("Not a valid year, sorry! Please try again!", output[1]);
        }

        [Fact]
        public void Main_Input_To_Low_Year()
        {
            // Arrange 
            var writer = new StringWriter();
            Console.SetOut(writer);
            
            // Act 
            Console.SetIn(new StringReader("1581"));
            Program.Main(new string[0]);
            writer.Flush();

            // Assert
            var output = writer.GetStringBuilder().ToString().Split("\n");
            Assert.Equal("Not a valid year, it is to low! Please try again!", output[1]);
        }
    }
}
