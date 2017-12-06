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
    public class FCHFunction :ACHFunction
    {

        public override event EventHandler<FuncEventArgs> OnNewPoint;

        public FCHFunction(Function InpFunction):base(InpFunction)
        {
            Series.Name = "ФЧХ" + InpFunction.FunctionName;
        }

        protected override void FillList()
        {
            foreach (var item in listOfHarminics)
            {
                var p = new PointF(item.Key, (float)item.Value.Phase);
                Add(p);
                OnNewPoint?.Invoke(this, new FuncEventArgs(p));
            }
        }

    }
}
