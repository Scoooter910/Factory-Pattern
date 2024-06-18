using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    static class FoodFactory
    {
        public static IOrderable OrderFood(string choice)
        {
            switch(choice)
            {
                case "shrimp":
                    return new Shrimp();
                case "steak":
                    return new Steak();
                default:
                    return new Steak();

                



            }

        }
    }
}
