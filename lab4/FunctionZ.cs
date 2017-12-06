using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace lab4
{
    [ImmediateDraw]
    public class FunctionZ:FunctionU
    {
        FunctionU _funcU;
        FunctionV _funcV;

        public override float GetInputFunction(float Left)
        {
            var sum= _funcU.Find((a) => { return a.X == Left; }).Y + _funcV.Find((a) => { return a.X == Left; }).Y;
            return sum;
        }

        public FunctionZ(FunctionU funcU, FunctionV funcV)
        {
            Series.Name = "Сумма функций";
            _funcU = funcU;
            _funcV = funcV;
        }
    }
}
