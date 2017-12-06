using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Graphic
{
    public class FunctionFromTask :Function
    {
        public FunctionFromTask() : base()
        {
            Series.ChangeView(ViewType.Spline);
            olviewType = ViewType.Spline;
        }

        public override event EventHandler<FuncEventArgs> OnNewPoint;

        

        protected override void FillList()
        {

            //
            for (float Left = this.Left; Left <= Right;)
            {//(float)Math.Pow(Math.Cos(5 * Left), 2) * (float)Math.Exp(-Math.Sin(Left/2));
                var NotQuantedOrd = GetInputFunction(Left);

                Add(new PointF(Left, NotQuantedOrd));
                if (QuantumOrd == 0||!OnlyResult)
                {
                    OnNewPoint?.Invoke(this, new FuncEventArgs(new PointF(Left, NotQuantedOrd)));
                }
                Left += QuantumAbs;
            }

           
        }
    }
}
