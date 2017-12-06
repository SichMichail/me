using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Graphic
{
    public class KotelnikovSmooth :Function
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;
        KotelnikovFunction inpFunc;

        public KotelnikovSmooth(KotelnikovFunction inpF)
        {
            FunctionName = "Гладкая восстановленная";
            Series.Name = FunctionName;
            Series.ChangeView(ViewType.Spline);
            olviewType = ViewType.Spline;
            inpFunc = inpF;
        }
        protected override void FillList()
        {
            var max = inpFunc.Select(a => a.Y).Max()*0.001;
            var min = max * 0.0001;
            for (int i = 0; i < inpFunc.Count; i++)
            {
                if (Math.Abs(inpFunc[i].Y)>max|| Math.Abs(inpFunc[i].Y)<min)
                {
                    Add(inpFunc[i]);
                    OnNewPoint?.Invoke(this, new FuncEventArgs(inpFunc[i]));
                }
            }
        }
    }
}
