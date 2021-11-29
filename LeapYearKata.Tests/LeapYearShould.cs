using System;
using Xunit;

namespace LeapYearKata.Tests
{
    public class LeapYearShould
    {
        [Fact]
        public void CheckIfItsLeapYear()
        {
            var leapYear = new LeapYear();

            Assert.True(leapYear.IsLeapYear(2000));
        }

        [Fact]
        public void CheckIfItsNotLeapYear()
        {
            var leapYear = new LeapYear();
            Assert.False(leapYear.IsLeapYear(2001));
        } 
    }
}