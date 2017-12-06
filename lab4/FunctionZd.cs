using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using System.Drawing;

namespace lab4
{
    [ImmediateDraw]
    class FunctionZd:FunctionUd
    {
        protected FunctionUd _funcU;
        protected FunctionVd _funcV;

        public override float GetInputFunction(float Left)
        {
            var sum = _funcU.GetInputFunction(Left) + _funcV.GetInputFunction(Left);
            return sum;
        }

        

        public FunctionZd(FunctionUd funcU, FunctionVd funcV):base()
        {
            Series.Name = "zd";
            _funcU = funcU;
            _funcV = funcV;
        }

        

    }
}
