using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using System.Numerics;

namespace Lab2
{
    [ImmediateDraw]
    public class FunctionFilteredAch :Function
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;
        List<Complex> _compList;
        public FunctionFilteredAch(List<Complex> inpList)
        {
            _compList = inpList;
            Series.Name = "АЧХ восстановленного сигнала";
        }
        protected override void FillList()
        {
            for (int i = 0; i < _compList.Count; i++)
            {
                Add(new System.Drawing.PointF(i, (float)_compList[i].Magnitude));
            }
        }
    }
}
