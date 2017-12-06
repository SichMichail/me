using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Lab2
{
    [ImmediateDraw]
    public class FunctionFilter :Function
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;
        protected const int countdowns = 2048;

        public FunctionFilter(int left, int right)
        {
            Left = left;
            Right = right;
            Series.Name = "АЧХ фильтра";
        }

        protected override void FillList()
        {
            for (int i = 0; i < countdowns; i++)
            {
                if (i>=Left&&i<=Right)
                {
                    Add(new System.Drawing.PointF(i, 1));
                }
                else
                    Add(new System.Drawing.PointF(i, 0));
            }
        }
    }
}
