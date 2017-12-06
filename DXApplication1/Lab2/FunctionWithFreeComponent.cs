using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class FunctionWithFreeComponent :FunctionSequence
    {
        public FunctionWithFreeComponent(int periodCount) : base(periodCount)
        {
            Series.Name = "Функция со свободной состовляющей 10";
        }

        public override float GetInputFunction(float Left)
        {
            return base.GetInputFunction(Left)+10;
        }
    }
}
