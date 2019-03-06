using System;
using Xunit;

namespace StringCalculatorKata.Tests
{
    public class StringCalculatorTest
    {
        private StringCalculator underTest; //generated from light bulb below line 18

        public StringCalculatorTest() // constructor
        {
            underTest = new StringCalculator();
        }

        [Fact]
        public void Add_Returns_0_For_Empty_String()
        {
           // underTest = new StringCalculator(); //delete the word var & use lightbulb

            var result = underTest.Add("");

            Assert.Equal(0, result);
        }

        //[Fact]
        //public void Add_Returns_1_For_1()
        //{
        //    // var underTest = new StringCalculator(); //now in scope of class

        //    var result = underTest.Add("1");

        //    Assert.Equal(1, result);
        //}

        //[Fact]
        //public void Add_Returns_2_For_2()
        //{
        //    var result = underTest.Add("2");

        //    Assert.Equal(2, result);
        //}

        [Theory] //use this bcse fact cannot have paramaters or arguments
        [InlineData("1", 1)] //use InlineData to add arguments to [Theory]
        [InlineData("2", 2)] //test will now run twice, once with each data set; Now delete above tests
        public void Add_Returns_Expected_Output(string input, int expected)
        {
            var result = underTest.Add(input);

            Assert.Equal(expected, result);
        }
    }
}
