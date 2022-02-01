using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLabWorkInFourthChapters
{
    public class DayAndMonthInYear
    {
        private int _day;
        private bool _leapYear;

        public int Day
        {
            get { return _day; }
            set
            {
                if (value <= 0 || value > 366)
                {
                    throw new ArgumentException("Параметр не входит в интервал от 0 до 366!");
                }
                _leapYear = CheckLeapYear(value);
                _day = value;
            }
        }

        public DayAndMonthInYear(int day)
        {
            Day = day;
        }

        public DayAndMonthInYear(string line)
        {
            if (line is null)
            {
                throw new ArgumentNullException(nameof(line));
            }
            if (int.TryParse(line, out int value))
            {
                Day = value;
            }
            else
            {
                throw new ArgumentException("Параметр не подходит для задачи");
            }
        }

        public override string ToString()
        {
            var dateTime = Convert.ToDateTime("01.01.2000");
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("День и месяц : {0:M}.", dateTime.AddDays(Day - 1))
                .AppendLine();
            if (!_leapYear)
                stringBuilder.AppendLine("Не высокосный год!");
            else
                stringBuilder.AppendLine("Высокосный год!");
            return stringBuilder.ToString();
        }

        private bool CheckLeapYear(int day)
        {
            if (day % 4 == 0)
            {
                if (day % 400 != 0 && day % 100 == 0)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
