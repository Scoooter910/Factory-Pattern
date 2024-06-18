using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Shrimp : IOrderable
    {
        public double Price { get; set; } = 12.99;

        public void OrderDescription()
        {
            Console.WriteLine("Steamed peel and eat shrimp");
        }
    }
}
