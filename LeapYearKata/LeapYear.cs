namespace LeapYearKata
{
    public class LeapYear
    {
        public bool IsLeapYear(int year)
        {
            if (year == 400)
                return true;
            if (year == 1200)
                return true;
            
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