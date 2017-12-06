using Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    [ImmediateDraw]
    public class FunctionUd :Function
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;

        public override float GetInputFunction(float Left)
        {
            return (float)Math.Exp(-4 * Math.Pow(10, 14) * Math.Pow(Math.Abs(Left - 11), 12));
        }

        public FunctionUd()
        {
            Series.Name = "u";
            Series.ChangeView(DevExpress.XtraCharts.ViewType.Spline);
        }

        public void MadeDiscret()
        {
            Series.Name += "d";
            for (int i = 0; i < Count; i++)
            {
                PointF p = this[i];
                p.X = i;
                this[i] = p;
            }
        }

        protected override void FillList()
        {
            Left = 9.4f;
            Right = 11.4f;
            QuantumAbs = 0.002f;
            for (float i = Left; i <= Right; i += QuantumAbs)
            {
                var func = GetInputFunction(i);
                PointF point = new PointF(i, func);
                Add(point);
            }
        }
    }
}
