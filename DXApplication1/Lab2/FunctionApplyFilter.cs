using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using System.Drawing;
using System.Numerics;

namespace Lab2
{
    [ImmediateDraw]
    public class FunctionApplyFilter :FunctionACHFromFile
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;
        FunctionACHFromFile _inpFunction;
        FunctionFilter _filter;


        public FunctionApplyFilter(FunctionACHFromFile inpFunction, FunctionFilter filter):base(inpFunction._inpF)
        {
            Series.Name = "АЧХ после фильтрации";
            _inpFunction = inpFunction;
            _filter = filter;
        }

        protected override void FillList()
        {
            data = new List<Complex>();
           AddRange(_inpFunction.Zip(_filter, (inpFY, filY) => { return new PointF(inpFY.X, inpFY.Y * filY.Y); }));
           data.AddRange(_inpFunction.data.Zip(_filter, (inpf, filt) => { return inpf*filt.Y; }));
        }
    }
}
