using System;
using Xunit;

namespace LeapYearKata.Tests
{
    public class LeapYearShould
    {
        [Fact]
        public void CheckIfItsLeapYear2000()
        {
            var leapYear = new LeapYear();

            Assert.True(leapYear.IsLeapYear(2000));
        }
        
        [Fact]
        public void CheckIfItsLeapYear2004()
        {
            var leapYear = new LeapYear();

            Assert.True(leapYear.IsLeapYear(2004));
        }

        [Fact]
        public void CheckIfItsNotLeapYear2001()
        {
            var leapYear = new LeapYear();
            Assert.False(leapYear.IsLeapYear(2001));
        } 
    }
}