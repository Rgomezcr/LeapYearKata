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
        public void CheckIfItsLeapYear2008()
        {
            var leapYear = new LeapYear();

            Assert.True(leapYear.IsLeapYear(2008));
        }

        [Fact]
        public void CheckIfItsNotLeapYear2001()
        {
            var leapYear = new LeapYear();
            Assert.False(leapYear.IsLeapYear(2001));
        }

        [Fact]
        public void CheckIfItsNotDivisibleBy100AndItsDivisibleBy4()
        {
            var leapYear = new LeapYear();
            Assert.False(leapYear.IsLeapYear(2000));
        } 
    }
}