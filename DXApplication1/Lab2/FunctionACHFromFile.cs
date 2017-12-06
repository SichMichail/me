using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using static alglib;
using System.Numerics;

namespace Lab2
{
    [ImmediateDraw]
    public class FunctionACHFromFile :FunctionFromFile
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;
        public FunctionFromFile _inpF;
        public List<Complex> data;

        public FunctionACHFromFile(FunctionFromFile inpFunc)
        {
            _inpF = inpFunc;
            Series.Name = "АЧХ Сигнала";
        }

        protected override void FillList()
        {
            complex[] arr;
            data=new List<Complex>();
            fftr1d(_inpF.Select(a => (double)a.Y).ToArray(), out arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Complex complex = new Complex(arr[i].x, arr[i].y);
                data.Add(complex);
                Add(new System.Drawing.PointF(i,(float)complex.Magnitude));
            }
        }
    }
}
