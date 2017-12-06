using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
namespace lab4
{
    [ImmediateDraw]
    public class FunctionVd:FunctionUd
    {
        public override float GetInputFunction(float Left)
        {
            return (float)Math.Sqrt(2)* (float)Math.Sin(Math.PI*2*160*Left)*base.GetInputFunction(Left);
        }

        public FunctionVd():base()
        {
            Series.Name = "Функция vd";
        }
    }
}
