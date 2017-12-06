using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Graphic
{
    static public class DPF
    {

        static int getNearTwoPow(int count)
        {
            int pow = 0;
            while (Math.Pow(2, pow) < count)
            {
                pow++;
            }
            return (int)Math.Pow(2, pow - 1);
        }

        public static Action<int, Complex> CallBack;
        

    }
}
