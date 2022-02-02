using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLabWorkInFourthChapters
{
    public class LeapYear
    {
        private readonly int _year;

        public int Year
        {
            get { return _year; }
        }

        public LeapYear(int year)
        {
            if (year <= 0)
                throw new ArgumentException("Значение года больше нуля!");
            _year = year;
        }

        public LeapYear(string line): this (ParseYear(line))
        {
        }

        private static int ParseYear(string str)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            if (int.TryParse(str, out int value))
            {
                return value;
            }
            throw new ArgumentException("Параметр не подходит для задачи");
        }

        private bool IsYearLeap(int year)
        {
            if (year % 4 != 0)
                return false;
            return year % 400 == 0 || year % 100 != 0;
        }

        public override string ToString()
        {
            var formatMessage = IsYearLeap(_year) ? "{0} считается высокосным годом." : "{0} считается не высокосным годом.";
            return string.Format(formatMessage, _year);
        }

    }
}
