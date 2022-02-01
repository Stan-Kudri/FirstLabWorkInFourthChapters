using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLabWorkInFourthChapters
{
    public class DayAndMonthInYear
    {
        private readonly int _day;

        public DayAndMonthInYear(int day) 
        {
            if (day <= 0 || day > 366)
            {
                throw new ArgumentException("Параметр не входит в интервал от 0 до 366!");
            }
            _day = day;
        }

        public DayAndMonthInYear(string line) : this (ParseDay(line))
        {
        }        

        private static int ParseDay(string str)
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

        public override string ToString()
        {
            var dateTime = new DateTime(2000,01,01);
            return String.Format("День и месяц : {0:M}.", dateTime.AddDays(_day - 1));
        }        
    }
}
