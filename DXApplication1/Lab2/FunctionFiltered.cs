using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static alglib;

namespace Lab2
{
    [ImmediateDraw]
    class FunctionFiltered :Function
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;
        FunctionACHFromFile _inpFunc;

        public FunctionFiltered(FunctionACHFromFile inpFunc)
        {
            Series.Name = "Восстановленный сигнал";
            _inpFunc = inpFunc;
            Series.ChangeView(DevExpress.XtraCharts.ViewType.Spline);
        }
        protected override void FillList()
        {
            double[] arrres;
            fftr1dinv(_inpFunc.data.Select(a => { return new complex(a.Real, a.Imaginary); }).ToArray(), out arrres);
            var step = 0f;
            foreach (var item in arrres)
            {
                Add(new System.Drawing.PointF(step, (float)item));
                step += _inpFunc._inpF.dt;
            }        
        }
    }
}
