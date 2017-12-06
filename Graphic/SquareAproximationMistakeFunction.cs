using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Graphic
{
    class SquareAproximationMistakeFunction :Function
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;
        Function InpF2;
        public SquareAproximationMistakeFunction(Function InpF2)
        {
            FunctionName = "Ошибка восстановления";         
            this.InpF2 = InpF2;
            Series.Name = FunctionName;
            Series.ChangeView(DevExpress.XtraCharts.ViewType.Spline);
            InpF2.Build();
            //Series.ChangeView(DevExpress.XtraCharts.ViewType.Line);
        }

        protected override void FillList()
        {
            foreach (var item in InpF2)
            {
                var mistake =(float)Math.Pow(GetInputFunction(item.X)-item.Y,2);
                PointF exception = new PointF(item.X, mistake);
                Add(exception);
                if (!OnlyResult)
                {
                    OnNewPoint?.Invoke(this, new FuncEventArgs(exception));
                }
                
            }
        }
    }
}
