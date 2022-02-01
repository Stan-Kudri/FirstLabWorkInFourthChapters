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
        private DateTime _date;

        public DayMonthYear( int day, int year)
        {
            _dayAndMonth = new DayAndMonthInYear(day);
            _leapYear = new LeapYear(year);
            CreatingNewDate();
        }

        public DayMonthYear( string dayLine, string yearLine)
        {
            _dayAndMonth = new DayAndMonthInYear(dayLine);
            _leapYear = new LeapYear(yearLine);
            CreatingNewDate();
        }

        private void CreatingNewDate()
        {
            DateTime dateTime = _dayAndMonth.DateTime;
            _date = new DateTime(_leapYear.Year, dateTime.Month, dateTime.Day);
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Введенный дата {0:M} {1}", _date, _leapYear);
            return stringBuilder.ToString();
        }

    }
}
