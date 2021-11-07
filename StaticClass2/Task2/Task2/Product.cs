using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Product
    {
        public string Name;
        public decimal Price;
        public int  Count;
        public int TotalIncome;

        public Product()
        {
            this.Count=0;
            this.TotalIncome=0;
        }
        public string Sell()
        {
            if (Count == 0)
            {
                return $"Mehsul yoxdur";
            }
            else
            {
                Count--;
                TotalIncome++;
            }
            return $"Product Count{this.Count}\n TotalIncome{this.TotalIncome}";
        }
    }
}
