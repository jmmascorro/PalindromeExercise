using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("kayak", true)]
        [InlineData("radar", true)]
        [InlineData("hello", false)]
        [InlineData("truecoders", false)]
        public void IsAPalindrome(string text, bool expected)
        {
            //Arrange
            var test = new WordSmith();
            //Act
            var actual = test.IsAPalindrome(text);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
