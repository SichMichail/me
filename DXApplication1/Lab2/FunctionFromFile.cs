using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Core;
using System.Globalization;

namespace Lab2
{
    [ImmediateDraw]
    public class FunctionFromFile :Function
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;
        public const float T = 1f;
        public const int countdowns = 2048;
        public readonly float dt= T / countdowns;

        public FunctionFromFile()
        {
            Series.Name = "Исходный сигнал";
            Series.ChangeView(DevExpress.XtraCharts.ViewType.Spline);
            QuantumAbs = dt;
        }

        protected override void FillList()
        {
            var startTime = 0f;
            foreach (var item in File.ReadLines(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "signal_3.dat")))
            {
                Add(new System.Drawing.PointF(startTime, float.Parse(item, CultureInfo.InvariantCulture)));
                startTime += dt;                                        
            }
        }
    }
}
