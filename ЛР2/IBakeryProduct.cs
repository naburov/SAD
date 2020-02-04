using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2
{
    interface IBakeryRecipe
    {
        void CreateDough();
        void CreateFilling();
        void bake();
        BakeryProduct GetProduct();
    }
}
