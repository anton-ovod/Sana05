using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class MyDate
    {
        protected int year;
        protected int month;
        protected int day;
        protected int? hour;
        protected int? minute;

        public int Year {

            get
            {
                return year;
            }

            set
            {
                if(value <= 0 || value > DateTime.Now.Year) 
                {
                    throw new ArgumentOutOfRangeException("Invalid year!!");
                }
                year = value;

            }
        }

        public int Month
        {

            get
            {
                return month;
            }

            set
            {
                if (value <= 0 || value > 12)
                {
                    throw new Exception("Invalid month!!");
                }
                month = value;

            }
        }

        public int Day
        {

            get
            {
                return day;
            }

            set
            {
                if (value <= 0 || value > DateTime.DaysInMonth(year, month))
                {
                    throw new Exception("Invalid day!!");
                    
                }
                day = value;

            }
        }

        public int? Hour
        {

            get
            {
                return hour;
            }

            set
            {
                if (value < 0 || value > 24)
                {
                    throw new Exception("Invalid hour!!");
                }
                hour = value;

            }
        }

        public int? Minute
        {

            get
            {
                return minute;
            }

            set
            {
                if (value <= 0 || value > 60)
                {
                    throw new Exception("Invalid minute!!");
                }
                minute = value;

            }
        }

        public MyDate()
        {
            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;
            Day = DateTime.Now.Day;
            Hour = DateTime.Now.Hour;
            Minute = DateTime.Now.Minute;
        }

        public MyDate(int year, int month, int day, int hour, int minute)
        {
            Year = year;
            Month = month;
            Day = day;
            Hour = hour;
            Minute = minute;
        }

        public MyDate(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
            Hour = null;
            Minute = null;
        }

        public MyDate(MyDate date)
        {
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
            Hour = date.Hour;
            Minute = date.Minute;
        }

        public override string ToString()
        {
            return this.year.ToString() + "/" + this.month.ToString()
                + "/" + this.day.ToString()
                + " - " + this.hour.ToString()
                + ":" + this.minute.ToString();
        }


    }
}
