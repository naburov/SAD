using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ЛР2;

namespace ЛР2
{
    class Baker
    {
        IBakeryRecipe builder;

        public BakeryProduct CreateProduct()
        {
            builder.CreateDough();
            builder.CreateFilling();
            builder.bake();
            return builder.GetProduct();
        }

        public Baker(IBakeryRecipe recipe)
        {
            builder = recipe;
        }

    }
}
