using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using System.Numerics;

namespace Lab2
{
    public class FunctionAch :Function
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;
        List<Complex> _inpData;

        public FunctionAch(List<Complex> inpData, string funcName)
        {
            _inpData = inpData;
            Series.Name = "АЧХ"+funcName;
        }

        protected override void FillList()
        {
            for (int i = 0; i < _inpData.Count; i++)
            {
                OnNewPoint?.Invoke(this, new FuncEventArgs(new System.Drawing.PointF(i, (float)_inpData[i].Magnitude)));
            }
        }
    }
}
