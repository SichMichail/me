using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using System.Numerics;

namespace Lab2
{
    public class FunctionSinCos :FunctionMain
    {
        public List<Complex> ComplexArray;
        FunctionSequence funcseg;
        public override event EventHandler<FuncEventArgs> OnNewPoint;
        public Dictionary<string, float> FurieRowCoeffs;
        string funcGroup;
        public FunctionSinCos(int periodCount, string FuncGroup, FunctionSequence inpFunc) : base(periodCount)
        {
            funcGroup = FuncGroup;
            funcseg = inpFunc;
            //funcseg.Build();
            Series.ChangeView(DevExpress.XtraCharts.ViewType.Bar);
         
        }

        protected override void FillList()
        {
            ComplexArray = new List<Complex>();
            FurieRowCoeffs = new Dictionary<string, float>();
            for (int i = 0; i <= funcseg.garmonicCount; i++)
            {
                var sumCos = 0f;
                var sumSin = 0f;
                for (int j = 0; j < funcseg.Count-1; j++)
                {
                    sumCos += funcseg[j].Y * (float)Math.Cos(i * omega * j * dt);
                    sumSin += funcseg[j].Y * (float)Math.Sin(i * omega * j * dt);
                }
                var resSin = (2 / (float)funcseg.Count) * sumSin;
                var resCos = (2 / (float)funcseg.Count) * sumCos;
                FurieRowCoeffs.Add($"a{i} {funcGroup}", resSin);
                FurieRowCoeffs.Add($"b{i} {funcGroup}", resCos);
                ComplexArray.Add(new Complex(resCos, resSin));
                if (!OnlyResult)
                {
                    OnNewPoint?.Invoke(this, new FuncEventArgs(new System.Drawing.PointF(i,resSin)));
                    OnNewPoint?.Invoke(this, new FuncEventArgs(new System.Drawing.PointF(i, resCos)));
                }
            }
            
        }
    }
}
