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
    public class FunctionU :Function
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;


        public override float GetInputFunction(float Left)
        {
            return (float)Math.Exp(-0.05 * (Math.Abs(Left - 110)));
        }
        public FunctionU()
        {
            QuantumAbs= 4;
            Series.Name = "Функция U";
            Series.ChangeView(DevExpress.XtraCharts.ViewType.Spline);
        }

        protected override void FillList()
        {
            Left = -250;
            Right = 250;
            for (float i = Left; i <= Right + 0.3f; i += QuantumAbs)
            {
                var func = GetInputFunction(i);
                PointF point = new PointF(i, func);
                Add(point);
                if (!OnlyResult)
                {
                    OnNewPoint?.Invoke(this, new FuncEventArgs(point));
                }
            }
        }
    }
}
