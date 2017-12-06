using DevExpress.XtraBars;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Core;

namespace Graphic
{
    public partial class Form1 :DevExpress.XtraBars.TabForm
    {
        public Form1()
        {
            InitializeComponent();
            OnChangeHandler(null, null);
            
        }

        public float TryConvert(TextEdit control)
        {
            var result = 1F;
            if (float.TryParse(control.Text, out result))
            {
                return result != 0 ? result : 0.1F;
            }
            return -1;
        }

        void DrawFunction(Function inpFunc, Series whereDraw, bool isInterpolated)
        {
            
            //whereDraw.Points.Clear();

            //inpFunc.OnNewPoint += (sen, e) =>
            //{
            //    chartControl1.Invoke((Action)(() =>
            //    {
            //        chartControl1.Update();
            //        whereDraw.Points.Add(e.point.ToSeriesPoint());
            //    }));
            //};
            //chartControl1.BeginInit();
            //inpFunc.Build();
            //chartControl1.EndInit();
        }

        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            Form1 form = new Form1();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;

        void OnChangeHandler(object sender, EventArgs e)
        {
            //chartControl1.Series["meme"].ChangeView(ViewType.Bar);
            //DrawFunction(new FunctionFromTask(), chart.Series[0], true);
            //DrawFunction(new FunctionFromTask(), chartControl1.Series[0], false);
            //DrawFunction(new FunctionFromTask(), chartControl1.Series[1], true);
            //DrawFunction(new ACHFunction(currFunctions[0]), chartSpectr.Series[0], true);
        }

        private void chart_Click(object sender, EventArgs e)
        {

        }

        private void tabFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            //DrawFunction(new FunctionFromTask(), chartControl1.Series[0], false);

            //switch (((CheckBox)sender).CheckState)
            //{
            //    case CheckState.Unchecked:
            //        {
            //            chartControl1.Series[0].ChangeView(ViewType.Bar);
            //            break;
            //        }
            //    case CheckState.Checked:

            //        {
            //            chartControl1.Series[0].ChangeView(ViewType.Line);
            //            break;
            //        }
            //    case CheckState.Indeterminate:

            //        break;

            //}
        }

        public void tabFormControl1_SelectedPageChanged(object sender, TabFormSelectedPageChangedEventArgs e)
        {
            if (e.Page == FunctionDiscret)
            {

                var func = FuncAnalog.internalDrawList.Find((a) => { return (string)a.Series.Tag == typeof(FunctionFromTask).Name; });
                if (func == null || FuncDiscretn.Equals(func))
                {
                    return;
                }
                FunctionFromTaskQuantum fc = new FunctionFromTaskQuantum(func);
                fc.QuantumOrd = func.QuantumOrd;
                func.DestroySeries();
                FuncDiscretn.AddFunc(fc);
                //FuncDiscretn.AddFunc(func);
                //func.OnlyResult = true;
                KotelnikovFunction kf = new KotelnikovFunction(func);
                //kf.OnlyResult = true;
                //kf.Build();
                //KotelnikovSmooth ks = new KotelnikovSmooth(kf);
                FuncDiscretn.AddFunc(kf);
                
                FuncDiscretn.DrawFunc();

            }
            if (e.Page == FunctionACH)
            {

                var func = FuncDiscretn.internalDrawList.Find((a) => { return (string)a.Series.Tag == typeof(FunctionFromTaskQuantum).Name; });
                if (func == null || FuncAch.Equals(func))
                {
                    return;
                }
                var func1 = FuncAnalog.internalDrawList.Find((a) => { return (string)a.Series.Tag == typeof(FunctionFromTask).Name; });
                if (func1 == null)
                {
                    return;
                }
                ACHFunction fun = new ACHFunction(func);
                ACHFunction fun1 = new ACHFunction(func1);
                FuncAch.AddFunc(fun1);
                FuncAch.AddFunc(fun);
                FCHFunction ffun = new FCHFunction(func);
                FuncAch.AddFunc(ffun);
                FCHFunction ffun1 = new FCHFunction(func1);
                FuncAch.AddFunc(ffun1);
                FuncAch.DrawFunc();

            }
            if (e.Page == FunctionMistakes)
            {                
                var func = (KotelnikovFunction)FuncDiscretn.internalDrawList.Find((a) => { return (string)a.Series.Tag == typeof(KotelnikovFunction).Name; });
                if (func == null)
                {
                    return;
                }
                //func.Series.ChangeView(ViewType.Spline);
                
                //func.DestroySeries();
                
                SquareAproximationMistakeFunction apx = new SquareAproximationMistakeFunction(func);
                
                //FuncMistakes.AddFunc(func);
                FuncMistakes.AddFunc(apx);
                FuncMistakes.DrawFunc();
            }
            if (e.Page==FunctionQMistake)
            {
                var funcan = FuncAnalog.internalDrawList.Find((a) => { return (string)a.Series.Tag == typeof(FunctionFromTask).Name; });
                if (funcan == null)
                {
                    return;
                }
                FunctionQuantMistake fq = new FunctionQuantMistake(funcan);
                FuncQMistake.AddFunc(fq);
                FuncQMistake.DrawFunc();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FunctionFromTask inpFunc = new FunctionFromTask();
            inpFunc.Left = 0;
            inpFunc.Right = (float)Math.PI*6+0.1f;
            inpFunc.QuantumOrd = 0.2f;//TryConvert(ConrainsQVOrd);
            inpFunc.QuantumAbs = 0.2f;
            FuncAnalog.AddFunc(inpFunc);
            FuncAnalog.DrawFunc();
        }


        private void FuncDiscretn_Load_1(object sender, EventArgs e)
        {

        }

        private void FuncAch_Load(object sender, EventArgs e)
        {

        }
    }
}
