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
    }
}