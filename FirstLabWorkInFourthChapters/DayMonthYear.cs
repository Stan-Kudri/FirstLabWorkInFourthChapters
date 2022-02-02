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

        public override string ToString()
        {            
            return string.Format("Введенный дата {0:M} {1}",
                new DateTime(
                    _leapYear.Year,
                    _dayAndMonth.DateTime.Month,
                    _dayAndMonth.DateTime.Day),
                _leapYear);
        }
    }
}
