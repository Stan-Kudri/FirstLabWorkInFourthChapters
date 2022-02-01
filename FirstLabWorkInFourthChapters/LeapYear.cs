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

        public LeapYear(int year)
        {
            if (_year <= 0)
                throw new ArgumentException("Year Greater than Zero!");
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
            else
            {
                throw new ArgumentException("Параметр не подходит для задачи");
            }
        }

        private bool ISLeapYear(int year)
        {
            if (year % 4 != 0)
                return false;
            else
            {
                if (year % 100 != 0 || year % 400 == 0)
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            if (ISLeapYear(_year))
                stringBuilder.AppendFormat("{0} считается высокосным годом.", _year);
            else
                stringBuilder.AppendFormat("{0} считается не высокосным годом.", _year);
            return stringBuilder.ToString();
        }

    }
}
