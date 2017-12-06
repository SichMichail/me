using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraCharts;
using System.Windows.Forms;
using System.Drawing;

namespace Core
{
    public static class Extensions
    {
        public static SeriesPoint ToSeriesPoint(this PointF inpPoint)
        { 
            return new SeriesPoint(inpPoint.X, new object[] { ((object)(inpPoint.Y)) });
        }

        
        
    }
}
