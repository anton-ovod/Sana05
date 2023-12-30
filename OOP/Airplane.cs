using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Airplane
    {
        protected string startCity;
        protected string finishCity;
        protected MyDate startDate;
        protected MyDate finishDate;

        public string StartCity
        {
            get
            {
                return startCity;
            }

            set
            {
                if (value == "")
                    throw new Exception("Start City name can't be empty");
                startCity = value;
            }
        }

        public string FinishCity
        {
            get
            {
                return finishCity;
            }

            set
            {
                if (value == "")
                    throw new Exception("Finish City name can't be empty");
                finishCity = value;
            }
        }

        public MyDate StartDate
        {
            get
            {
                return startDate;
            }

            set
            {
                try
                {
                    startDate = new MyDate(value);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public MyDate FinishDate
        {
            get
            {
                return finishDate;
            }

            set
            {
                try
                {
                    finishDate = new MyDate(value);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public Airplane()
        {
            StartCity = "Default StartCity";
            FinishCity = "Default FinishCity";
            StartDate = new MyDate();
            FinishDate = new MyDate();
        }

        public Airplane(string startCity, string finishCity, MyDate startDate, MyDate finishDate)
        {
            StartCity=startCity;
            FinishCity=finishCity;
            StartDate=startDate;
            FinishDate=finishDate;
        }

        public Airplane(MyDate startDate, MyDate finishDate)
        {
            StartCity = "Belin";
            FinishCity = "Warsaw";
            StartDate = startDate;
            FinishDate = finishDate;
        }

        public Airplane(Airplane airplane)
        {
            StartCity = airplane.StartCity;
            FinishCity = airplane.FinishCity;
            StartDate = airplane.StartDate;
            FinishDate = airplane.FinishDate;
        }

        public int GetTotalTime()
        {
            var TotalTimeMinutes = 0;
            DateTime startTime;
            DateTime finishTime;

            if (StartDate.Hour is null || StartDate.Minute is null)
            {
                startTime = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day);
                finishTime = new DateTime(FinishDate.Year, FinishDate.Month, FinishDate.Day);
            }
            else
            {
                startTime = new DateTime(StartDate.Year, StartDate.Month, StartDate.Day, (int)StartDate.Hour, (int)StartDate.Minute, 0);
                finishTime = new DateTime(FinishDate.Year, FinishDate.Month, FinishDate.Day, (int)FinishDate.Hour, (int)FinishDate.Minute, 0);
            }

            TotalTimeMinutes = (int)(finishTime - startTime).TotalMinutes;
            return TotalTimeMinutes;
        }

        public bool IsArrivingToday()
        {
            return (StartDate.Year == FinishDate.Year && StartDate.Month == FinishDate.Month && StartDate.Day == FinishDate.Day);
        }

        public override string ToString()
        {
            return StartCity + " -> " + FinishCity + "\n" + 
                StartDate + " -> " + FinishDate;
        }
    }
}
