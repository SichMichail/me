using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core;
using Core.WindowsList;
using Lab2;
using Core.Sound;
using System.Threading;

namespace Lab3
{
    public partial class Form1 :DevExpress.XtraBars.TabForm
    {
        public Form1()
        {
            InitializeComponent();
            Action<ChartForFunction, Quarter> AddChart = (chart, quarter) =>
            {
                PartFunction pf = new PartFunction(quarter);
                pf.Build();
                WindowBarlette wb = new WindowBarlette(pf);
                wb.Build();
                var winFunc = pf.ApplyWindow(Windows.Barlette);
                chart.AddFunc(wb);
                chart.AddFunc(pf);
                chart.AddFunc(winFunc.GetAFR);
                chart.AddFunc(winFunc.FurieTransformInversion());
                chart.AddFunc(pf.FurieTransform().GetAFR);
                chart.DrawFunc();
            };
            AddChart(chrtWindows1, Quarter.First);
            AddChart(chrtWindows2, Quarter.Second);
            AddChart(chrtWindows3, Quarter.Third);
            AddChart(chrtWindows4, Quarter.Fourth);
        }





        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            Form1 form = new Form1();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;

        private void chrtWindows_Click(object sender, EventArgs e)
        {

        }

        private void chrtWindows_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
