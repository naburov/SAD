using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР8
{
    public enum Type
    {
        expression,
        set, 
        sub, 
        print,
        rem
    }

    abstract class AbstractExpression
    {
        public AbstractExpression()
        {

        }
    }
}
