using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReductionCardSystem
{
    public class Rreduction
    {
        public string  Name { get; set; }
        public int _age;
        public int Age
        {
            set
            {
                if (_age < 0)
                {
                    MessageBox.Show("impossible");
                }
                else
                {
                    _age = value;
                }
            }
            get
            {
                return _age;
            }
        }

        public string Product { get; set; }

        public double Price { get; set; }
        public double red { get; set; }

        public Rreduction(string Name,  int Age, string Product, double Price)
        {
            this.Name = Name;
            this.Age = Age;
            this.Product = Product;
            this.Price = Price;
        }
        public double redu()
        {
            if(Age>=18 && Age < 23)
            {
                red= Price - Price * 60 / 100.0;
            }
            else if(Age>=23 && Age < 60)
            {
                red = Price * (1 - 20 / 100.0);
            }
            else
            {
                red = Price * (1 - 70 / 100.0);
            }
            return red;
        }
    }
}
