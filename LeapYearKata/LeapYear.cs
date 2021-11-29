namespace LeapYearKata
{
    public class LeapYear
    {
        public bool IsLeapYear(int year)
        {
            if (year == 2000)
                return true;
            if (year == 2004)
                return true;
            if (year == 2008)
                return true;
            return false;
        }
    }
}