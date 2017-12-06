using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using static alglib;

namespace Core
{
    [ImmediateDraw]
    public class FurieFunction :Function
    {
        public override event EventHandler<FuncEventArgs> OnNewPoint;
        public List<Complex> ComplexArr { get; protected set; }
        public float oldDt { get; set; }
        Function _inpFunction;


        public FurieFunction ConjugateSpectre
        {
            get
            {
                if (ComplexArr.Count > 0)
                {
                    
                    for (int i = 0; i < ComplexArr.Count; i++)
                    {
                        ComplexArr[i] = Complex.Conjugate(ComplexArr[i]);
                    }
                    return this;
                }
                else
                    throw new Exception("No Complex Data");
            }
        }


        public FurieFunction GetAFR
        {
            get {
                if (ComplexArr.Count > 0)
                {                                                  
                    for (int i = 0; i < ComplexArr.Count; i++)
                    {                     
                        Add(new System.Drawing.PointF( i<ComplexArr.Count/2?i:-(ComplexArr.Count-i), (float)ComplexArr[i].Magnitude/ (ComplexArr.Count())));
                    }
                    return this;
                }
                else
                    throw new Exception("No Complex Data");
                
            }
        }


        public FurieFunction()
        {
            
        }

        public FurieFunction(Function inpFunction)
        {
            _inpFunction = inpFunction;
            Series.Name = "спектр:" + _inpFunction.Series.Name;
            oldDt = _inpFunction.QuantumAbs;
        }

        int getNearTwoPow(int count)
        {
            int pow = 0;
            while (Math.Pow(2, pow) < count)
            {
                pow++;
            }
            return (int)Math.Pow(2, pow);
        }



        protected override void FillList()
        {
            var arguments = _inpFunction.Select(a => (double)a.Y).ToArray();
            complex[] inparr;
            alglib.fftr1d(arguments.ToArray(), out inparr);
            ComplexArr = new List<Complex>();
            foreach (var item in inparr)
            {                
                Complex comp = new Complex(item.x, item.y);
                ComplexArr.Add(comp);
            }
        }
    }
}
