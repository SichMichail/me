using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace lab4
{
    [ImmediateDraw]
    public class FunctionV:FunctionU
    {
        public FunctionV()
        {
            Series.Name = "Функция V";
        }

        public override float GetInputFunction(float Left)
        {
            return 1.2f* (float)Math.Exp(-0.05 * (Math.Abs(Left - 60)));
        }

    }
}
