using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLabWorkInFourthChapters
{
    public class DayMonthYear
    {
        private DayAndMonthInYear _dayAndMonth;
        private LeapYear _leapYear;

        public DayMonthYear(int day, int year)
        {
            _dayAndMonth = new DayAndMonthInYear(day);
            _leapYear = new LeapYear(year);
        }

        public DayMonthYear(string dayLine, string yearLine)
        {
            _dayAndMonth = new DayAndMonthInYear(dayLine);
            _leapYear = new LeapYear(yearLine);
        }

        private DateTime CreatingNewDate()
        {
            DateTime dateTime = _dayAndMonth.DateTime;
            return new DateTime(_leapYear.Year, dateTime.Month, dateTime.Day);
        }

        public override string ToString()
        {            
            return string.Format("Введенный дата {0:M} {1}", CreatingNewDate(), _leapYear);
        }
    }
}
