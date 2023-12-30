using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Currency
    {
        protected string name;
        protected decimal exRate;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Currency name can't be null or empty!!");
                name = value;
            }
        }

        public decimal ExRate
        {
            get
            {
                return exRate;
            }

            set
            {
                if (decimal.IsNegative(value))
                    throw new Exception("Exchange rate can't be negative value!!");
                exRate = value;
            }
        }

        public Currency()
        {
            Name = "Default currency";
            ExRate = 11.11M;
        }

        public Currency(string name, decimal  exRate)
        {
            Name = name;
            ExRate = exRate;
        }

        public Currency(string name)
        {
            Name = name;
            ExRate = 1.00M;
        }

        public Currency(Currency currency)
        {
            Name = currency.Name;
            ExRate = currency.ExRate;
        }

        public override string ToString()
        {
            return Name + " <=> " + ExRate;
        }
    }
}
