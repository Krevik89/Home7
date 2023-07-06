using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home7
{
    public class Money
    {
        private int dollars;
        private int cents;

        public Money(int dollars, int cents)
        {
            this.dollars = dollars;
            this.cents = cents;
        }

        public int Dollars
        {
            get { return dollars; }
            set { dollars = value; }
        }

        public int Cents
        {
            get { return cents; }
            set { cents = value; }
        }

        public void Print()
        {
            Console.WriteLine($"{dollars}.{cents:D2}");
        }
    }
    public class Product
    {
        private string name;
        private Money price;

        public Product(string name, Money price)
        {
            this.name = name;
            this.price = price;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Money Price
        {
            get { return price; }
            set { price = value; }
        }

        public void ReducePrice(double percent)
        {
            int totalCents = price.Dollars * 100 + price.Cents;
            totalCents = (int)(totalCents * (1 - percent / 100));
            price.Dollars = totalCents / 100;
            price.Cents = totalCents % 100;
        }
    }
}
