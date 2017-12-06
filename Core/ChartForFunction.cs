using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using System.IO;

namespace Core
{
    public partial class ChartForFunction :UserControl, IEquatable<Function>
    {
        public bool Loaded { get; set; } = false;

        public List<Function> internalDrawList;
        public void AddFunc(Function inpFunction)
        {
            var func = internalDrawList.Find((a) => { return (string)a.Series.Name == (string)inpFunction.Series.Name; });
            if (func != null)
            {
                internalDrawList.Remove(func);
                internalDrawList.Add(inpFunction);
                return;
            }
            internalDrawList.Add(inpFunction);
        }

        public void DrawFunc()
        {
            //chart.D
            Action asyncAction = () => {
                chart.Series.Clear();
                chart.BeginInit();
                foreach (var function in internalDrawList)
                {
                    chart.Series.Add(function.Series);
                    function.Series.Points.Clear();
                    
                    if (function.GetType().GetCustomAttributes(typeof(ImmediateDrawAttribute), false).Count()>0)
                    {
                        if (function.Count==0)
                        {
                            function.Build();
                        }                        
                        foreach (var point in function)
                        {
                            chart.Series[function.Series.Name].Points.Add(point.ToSeriesPoint());
                        }                        
                        continue;
                    }
                    function.OnNewPoint += (sen, arg) =>
                    {
                        chart.BeginInvoke((Action)(() =>
                        {
                            chart.Series[function.Series.Name].Points.Add(arg.point.ToSeriesPoint());
                            chart.Refresh();
                        }));
                    };
                    function.Build();
                }
                chart.EndInit();
            };
            if (chart.IsHandleCreated)
            {
                asyncAction();
            }
            else
                chart.HandleCreated += (sen, arg) => { asyncAction(); };            
        }

        public bool Equals(Function other)
        {
            foreach (var item in internalDrawList)
            {
                if (item.Left == other.Left && item.Right == other.Right && item.QuantumAbs == other.QuantumAbs && item.QuantumOrd == other.QuantumOrd && item.Series.Name == other.Series.Name)
                {
                    return true;
                }
            }
            return false;
        }

        public ChartForFunction()
        {
            InitializeComponent();
            chart.CacheToMemory = true;
            chart.RefreshDataOnRepaint = false;
            chart.RuntimeHitTesting = false;
            internalDrawList = new List<Function>();
            
        }

        private void chart_Click(object sender, EventArgs e)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                chart.ExportToImage(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                Bitmap bm = new Bitmap(ms);
                Clipboard.SetImage(bm);
            }
        }
        private void ChartForFunction_Load(object sender, EventArgs e)
        {
            Loaded = true;
        }

        private void chart_CustomPaint(object sender, CustomPaintEventArgs e)
        {
          //  e.Graphics.DrawRectangle(Pens.White, 0, 0, 20, 20);
          
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in internalDrawList)
            {
                if (item.Series.CheckedInLegend)
                {
                    return;
                }
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
