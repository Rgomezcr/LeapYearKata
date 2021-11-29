namespace LeapYearKata
{
    public class LeapYear
    {
        public bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
                if (year % 100 == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            return false;
        }
    }
}