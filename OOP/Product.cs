using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Product
    {
        protected string name;
        protected decimal price;
        protected Currency cost;
        protected int quantity;
        protected string producer;
        protected double weight;

        public string Name {  
            get
            {
                return name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Product name can't be empty or null!!");
                name = value;
            }
        }

        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                if (decimal.IsNegative(value))
                    throw new Exception("Product price can't be negative value!!!");
                price = value;
            }
        }

        public Currency Cost
        {
            get
            {
                return cost;
            }

            set
            {
                cost = new Currency(value);
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                if (int.IsNegative(value))
                    throw new Exception("Product quantity can't be null!!");
                quantity = value;
            }
        }

        public string Producer
        {
            get
            {
                return producer;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Product producer name can't be null or emtpy!!");
                producer = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                if (double.IsNegative(value) || double.IsNaN(value))
                    throw new Exception("Product weight can't be NaN or negative value!!");
                weight = value;
            }
        }

        public Product()
        {
            Name = "Default name";
            Price = 100.00M;
            Cost = new Currency();
            Quantity = 0;
            Producer = "Default Producer";
            Weight = 0.0;
        }

        public Product(string name, decimal price, Currency cost, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = new Currency(cost);
            Quantity = quantity;
            Producer = producer;
            Weight = weight;

        }

        public Product(string name, decimal price, Currency cost, int quantity, double weight)
        {
            Name = name;
            Price = price;
            Cost = new Currency(cost);
            Quantity= quantity;
            Producer = "Default Producer";
            Weight = weight;

        }

        public Product(string name, decimal price, int quantity, string producer, double weight)
        {
            Name = name;
            Price = price;
            Cost = new Currency();
            Quantity = quantity;
            Producer = producer;
            Weight = weight;
        }

        public Product(Product product) 
        {
            Name = product.Name;
            Price = product.Price;
            Cost = product.Cost;
            Quantity = product.Quantity;
            Producer = product.Producer;
            Weight = product.Weight;
        }

        public decimal GetPriceInUAH()
        {
            return Price * Cost.ExRate;
        }

        public decimal GetTotalPriceInUAH()
        {
            return Price * Cost.ExRate * Quantity;
        }
        public double GetTotalWeight()
        {
            return Weight * Quantity;
        }

        public override string ToString()
        {
            return Name + ":" + Price + ":" + Cost + ":" + Quantity + ":" + Producer + ":" + Weight;
        }
    }
}
