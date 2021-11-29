using System;
using Xunit;

namespace LeapYearKata.Tests
{
    public class LeapYearShould
    {
        [Fact]
        public void CheckIfItsLeapYear()
        {
            LeapYear leapYear = new();

            Assert.True(leapYear.IsLeapYear(2000));
        }

        [Fact]
        public void CheckIfItsNotLeapYear()
        {
            LeapYear leapYear = new();
            Assert.False(leapYear.IsLeapYear(2001));
        } 
    }
}