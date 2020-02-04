using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2
{
    class CherryPieRecipe : IBakeryRecipe
    {
        BakeryProduct Pie;

        public void bake()
        {
            Pie.bakingTime = 30;
        }

        public void CreateDough()
        {
            Pie.dough = "yeast dough";
        }

        public void CreateFilling()
        {
            Pie.filling = new string[] { "cherry"};
        }

        public BakeryProduct GetProduct()
        {
            return Pie;
        }

        public CherryPieRecipe()
        {
            Pie = new BakeryProduct();
        }
    }
}
