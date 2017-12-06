using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    [Serializable]
    public abstract class Function :List<PointF>, ICloneable
    {
        public float Left { get; set; }
        public float Right { get; set; }
        public float QuantumAbs { get; set; }
        public float QuantumOrd { get; set; }

        public bool OnlyResult { get; set; } = false;

        //public bool ImediateDraw { get; set; } = false;
        //public Series Serieses;

        protected ViewType olviewType;

        public string FunctionName;

        public Series Series { get; set; }
        

        public void DestroySeries()
        {
            var tag = Series.Tag;

            Series = new Series();
            Series.ChangeView(olviewType);
            Series.Name = FunctionName;
            Series.Tag = tag;
        }


        protected float T;
        public abstract event EventHandler<FuncEventArgs> OnNewPoint;
        public void Build()
        {
            if (QuantumAbs != -1 && QuantumOrd != -1)
            {
                Clear();
                FillList();
            }
            
        }
        public virtual float GetInputFunction(float Left)
        {
            return (float)Math.Abs(Math.Sin(Left)) + (float)Math.Abs(Math.Sin(2 * Left));
            //return (float)(Math.Sin(Math.Sqrt(1 + Left * Left)));
            //return (float)Math.Sin(Left) * (float)Math.Pow(Math.E, (Math.Cos(Left / 3)));
        }
        public Function()
        {
            Series = new DevExpress.XtraCharts.Series();
            Series.Tag = GetType().Name;
            //Series.CheckedInLegend = false;
        }
        protected abstract void FillList();

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    public class FuncEventArgs :EventArgs
    {
        public PointF point { get; private set; }

        public FuncEventArgs(PointF nP)
        {
            point = nP;
        }
    }



}
