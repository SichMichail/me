using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Graphic
{
    public class KotelnikovFunction :FunctionFromTask
    {
        Function InpFunction;
        double nu;
        public KotelnikovFunction(Function InpFunction) : base()
        {
            FunctionName = "Восстановленная функция";
            this.InpFunction = InpFunction;
            Series.Name = FunctionName;
            nu = (Math.Abs(InpFunction.Right) - Math.Abs(InpFunction.Left)) / InpFunction.QuantumAbs;
            QuantumAbs = InpFunction.QuantumAbs / 2;
            Series.ChangeView(DevExpress.XtraCharts.ViewType.Bar);
        }
        public override event EventHandler<FuncEventArgs> OnNewPoint;
        protected override void FillList()
        {
            Left = InpFunction.Left;
            Right = InpFunction.Right;
            
            float omega = (float)((Math.PI)/ InpFunction.QuantumAbs);//(float)((Math.PI) * nu);
            for (float i = Left; i < Right; i += QuantumAbs)
            {
                var sum = 0d;
                foreach (var item in InpFunction)
                {
                    if (i - item.X == 0)
                    {
                        sum += item.Y;
                        continue;
                    }
                    var coeff = omega * (i-item.X);
                    sum += item.Y * ((float)Math.Sin(coeff) / coeff);
                }
                if (!OnlyResult)
                {
                    OnNewPoint?.Invoke(this, new FuncEventArgs(new System.Drawing.PointF(i, (float)sum)));
                }
                

                
                Add(new System.Drawing.PointF(i, (float)sum));
            }
        }
    }
}
