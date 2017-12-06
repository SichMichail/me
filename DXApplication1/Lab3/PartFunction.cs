using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2;
using Core;
using System.Drawing;

namespace Lab3
{
    public enum Quarter
    {
        First=1,
        Second,
        Third,
        Fourth
    }
    [ImmediateDraw]
    public class PartFunction:FunctionFromFile
    {
        Quarter FQuater;
        public PartFunction(Quarter AQuater)
        {
            FQuater = AQuater;
            Series.Name = "Функция " + ((int)AQuater).ToString() + "Часть";
        }

        protected override void FillList()
        {
            base.FillList();
            var Pointlist = new List<PointF>();
            for (int i = 0; i < Count; i++)
            {
                if (i >= ((Count / 4) * ((int)FQuater - 1)) && i <= ((Count / 4) * ((int)FQuater)))
                {
                    Pointlist.Add(this[i]);
                }
            }
            Clear();
            AddRange(Pointlist);
        }

    }
}
