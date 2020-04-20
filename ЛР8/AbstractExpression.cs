using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР8
{

    class OrExpression : AbstractExpression
    {
        public AbstractExpression Left { get; set; }
        public AbstractExpression Right { get; set; }

        public override bool Interpret(Context context) => 
            Left.Interpret(context) || Right.Interpret(context);

        public OrExpression()
        {

        }
    }

    class AndExpression: AbstractExpression
    {
        public AbstractExpression Left { get; set; }
        public AbstractExpression Right { get; set; }

        public override bool Interpret(Context context) =>
            Left.Interpret(context) && Right.Interpret(context);

        public AndExpression()
        {

        }
    }

    class TerminalExpression : AbstractExpression
    {
        string variableName;

        public override bool Interpret(Context context) =>
            context.GetVariable(variableName);

        public TerminalExpression(string variableName)
        {
            this.variableName = variableName;
        }
    }


    abstract class AbstractExpression
    {
        public abstract bool Interpret(Context context);
    }

    class Context 
    {
        public Dictionary<string, bool> variables;

        public void SetVariable(string name, bool value)
        {
            if (variables.ContainsKey(name))
                variables[name] = value;
            else
                variables.Add(name, value);
        }

        public bool GetVariable(string name) => variables[name];

        public Context()
        {
            variables = new Dictionary<string, bool>();
        }
    }

}
