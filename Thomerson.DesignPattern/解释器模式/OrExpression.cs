using System;
using System.Collections.Generic;
using System.Text;

namespace 解释器模式
{
    public class OrExpression : IExpression
    {

        private IExpression expr1 = null;
        private IExpression expr2 = null;

        public OrExpression(IExpression expr1, IExpression expr2)
        {
            this.expr1 = expr1;
            this.expr2 = expr2;
        }


        public bool Interpret(String context)
        {
            return expr1.Interpret(context) || expr2.Interpret(context);
        }
    }
}
