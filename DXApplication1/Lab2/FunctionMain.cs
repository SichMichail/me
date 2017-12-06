using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using System.Drawing;

namespace Lab2
{
    public class FunctionMain :Function
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;

        public override float GetInputFunction(float Left)
        {
            return 5 * (float)Math.Sin(omega* Left);
        }

        int periodCount;
        float T;
        protected float omega;
        protected float dt;
        public int garmonicCount=4;
        public FunctionMain(int periodCount)
        {
            this.periodCount = periodCount;
            Series.Name = "Основная функция";
            Series.ChangeView(DevExpress.XtraCharts.ViewType.Spline);
            Left = 0;     
            T = 2 * (float)Math.PI;
            omega = 2 * (float)Math.PI / T;
            Right = T*periodCount;
            dt = (float)((2 * Math.PI) / (garmonicCount * omega)) / 5;
        }

        protected override void FillList()
        {
            for (float i = Left; i <=Right+0.3f ; i+=dt)
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
