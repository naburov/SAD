using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2
{
    class Program
    {
        static void Main(string[] args)
        {
            var pieRecipe = new CherryPieRecipe();
            var donutRecipe = new StrawberryDonutRecipe();

            var pieBaker = new Baker(pieRecipe);
            var donutBaker = new Baker(donutRecipe);

            var pie = pieBaker.CreateProduct();
            var donut = donutBaker.CreateProduct();

        }
    }
}
