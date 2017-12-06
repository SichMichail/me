using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Graphic
{
    public class ACHFunction :Function
    {
        protected Dictionary<int, Complex> listOfHarminics = new Dictionary<int, Complex>();

        public override event EventHandler<FuncEventArgs> OnNewPoint;

        public ACHFunction(Function InpFunction)
        {
            Series.Name = "АЧХ"+InpFunction.FunctionName;
            Series.ChangeView(ViewType.Bar);
            olviewType = ViewType.Bar;
            ReliseDpf(InpFunction);
        }

        int getNearTwoPow(int count)
        {
            int pow = 0;
            while (Math.Pow(2, pow) < count)
            {
                pow++;
            }
            return (int)Math.Pow(2, pow - 1);
        }


        protected void ReliseDpf(Function func)
        {
            listOfHarminics.Clear();
            alglib.complex[] carr;
            var arr1 = (func.Select(a => (double)a.Y)).ToList();
            var nearpow = getNearTwoPow(arr1.Count);
            arr1.RemoveRange(nearpow, arr1.Count - nearpow);
            alglib.fftr1d(arr1.ToArray(), out carr);
            var arr3 = carr.ToList().GetRange(carr.Count() / 2, carr.Count() / 2);
            var arr2 = carr.ToList().GetRange(0, carr.Count() / 2);
            for (int i = 0; i < arr2.Count; i++)
            {
                if (i == 0)
                {
                    listOfHarminics.Add(i, new Complex(0, 0));
                    continue;
                }
                listOfHarminics.Add(i, new Complex(arr2[i].x, arr2[i].y));
                listOfHarminics.Add(i - arr2.Count, new Complex(arr3[i].x, arr3[i].y));
            }
        }


        protected override void FillList()
        {
            foreach (var item in listOfHarminics)
            {
                var p = new PointF(item.Key, (float)item.Value.Magnitude);
                Add(p);
                OnNewPoint?.Invoke(this, new FuncEventArgs(p));
            }
        }
    }
}
