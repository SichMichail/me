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
    class FunctionZd1 :FunctionZd
    {

        protected override void FillList()
        {
            Left = 9.4f;
            Right = 11.4f;
            QuantumAbs = 0.002f;
            for (float i = Left; i <= Right; i += QuantumAbs)
            {
                var func = GetInputFunction(i+1);
                PointF point = new PointF(i+1, func);
                Add(point);
            }
        }

        public FunctionZd1(FunctionUd funcU, FunctionVd funcV) : base(funcU, funcV)
        {
            Series.Name = "zd1";
        }
    }
}
