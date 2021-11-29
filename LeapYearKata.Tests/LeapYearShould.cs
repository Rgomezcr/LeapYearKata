using System;
using Xunit;

namespace LeapYearKata.Tests
{
    public class LeapYearShould
    {
        [Theory]
        [InlineData(1996)]
        [InlineData(2004)]
        [InlineData(2008)]
        public void CheckIfLeapYearItsDivisibleBy4(int year)
        {
            var leapYear = new LeapYear();

            Assert.True(leapYear.IsLeapYear(year));
        }

        [Fact]
        public void CheckIfItsNotLeapYear2001()
        {
            var leapYear = new LeapYear();
            Assert.False(leapYear.IsLeapYear(2001));
        }

        [Theory]
        [InlineData(2000)]
        [InlineData(2200)]
        [InlineData(1700)]
        public void CheckIfItsNotDivisibleBy100AndItsDivisibleBy4(int year)
        {
            var leapYear = new LeapYear();
            Assert.False(leapYear.IsLeapYear(year));
        }

        [Theory]
        [InlineData(400)]
        public void CheckIfLeapYearItsDivisibleBy400(int year)
        {
            var leapYear = new LeapYear();
            Assert.True(leapYear.IsLeapYear(year));
        } 
    }
}