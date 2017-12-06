using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Lab2
{
    public class FunctionSequence :FunctionMain
    {
        public FunctionSequence(int periodCount) : base(periodCount)
        {
            Series.Name = "Функция с гармониками";
        }
        public override float GetInputFunction(float Left)
        {
            garmonicCount = 4;
            return base.GetInputFunction(Left)+10*(float)Math.Sin(2*omega*Left)+ 6 * (float)Math.Cos(2 * omega * Left)+ 3 * (float)Math.Sin(3 * omega * Left)+ 7 * (float)Math.Cos(3 * omega * Left)+ 3 * (float)Math.Sin(4 * omega * Left);
        }

    }
}
