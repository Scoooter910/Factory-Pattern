using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Steak : IOrderable
    {
        public double Price { get; set; } = 32.95;

        public void OrderDescription()
        {
            Console.WriteLine("T-bone steak");
        }
    }
}
