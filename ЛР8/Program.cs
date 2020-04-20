using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР8
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.SetVariable("a", false);
            context.SetVariable("b", false);
            context.SetVariable("c", true);

            // (a || b) && c
            var expression = new AndExpression()
            {
                Left = new OrExpression()
                {
                    Left = new TerminalExpression("a"),
                    Right = new TerminalExpression("b")
                },
                Right = new TerminalExpression("c")
            };
            var result = expression.Interpret(context);
            Console.WriteLine(result);
        }
    }
}
