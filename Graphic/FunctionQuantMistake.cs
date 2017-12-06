using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Graphic
{
    public class FunctionQuantMistake :Function
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;
        Function inpFunction;

        public FunctionQuantMistake(Function inpFunc)
        {
            FunctionName = "Ошибка восстановления";
            Series.Name = FunctionName;
            inpFunction = inpFunc;
            Series.ChangeView(DevExpress.XtraCharts.ViewType.Spline);
        }

        protected override void FillList()
        {
            for (float i = 0.1f; i < Math.Abs(inpFunction.Right-inpFunction.Left); i+=1f)
            {
                FunctionFromTask fft = new FunctionFromTask();
                fft.Left = inpFunction.Left;
                fft.Right = inpFunction.Right;
                fft.QuantumAbs = i;
                fft.QuantumOrd = inpFunction.QuantumOrd;
                fft.OnlyResult = true;
                fft.Build();
                KotelnikovFunction kf = new KotelnikovFunction(fft);
                kf.OnlyResult = true;
                kf.Build();
                KotelnikovFunction kf2 = new KotelnikovFunction(kf);
                kf2.OnlyResult = true;
                kf2.QuantumAbs = 0.4f;
                kf2.Build();             
                SquareAproximationMistakeFunction aprox = new SquareAproximationMistakeFunction(kf2) { OnlyResult = true };
                aprox.Build();
                var sum = aprox.Sum(a => Math.Abs(a.Y));
                OnNewPoint(this, new FuncEventArgs(new System.Drawing.PointF(i, sum)));

            }
        }
    }
}
