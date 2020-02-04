using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2
{
    class StrawberryDonutRecipe : IBakeryRecipe
    {
        public BakeryProduct Donut;

        public void bake()
        {
            Donut.bakingTime = 10;
        }

        public void CreateDough()
        {
            Donut.dough = "puff pastry";
        }

        public void CreateFilling()
        {
            Donut.filling = new string[] { "strawberry", "chocolate"};
        }

        public BakeryProduct GetProduct()
        {
            return Donut;
        }

        public StrawberryDonutRecipe()
        {
            Donut = new BakeryProduct();
        }
    }
}
