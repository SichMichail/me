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

namespace Lab2
{
    public partial class lab2 :DevExpress.XtraBars.TabForm
    {
        const int periodCount = 3;
        public lab2()
        {
            InitializeComponent();
            FunctionMain fmain = new FunctionMain(periodCount);
            FunctionSequence fseq = new FunctionSequence(periodCount);
            FunctionWithFreeComponent ffree = new FunctionWithFreeComponent(periodCount);
            chartMainFunc.AddFunc(fmain);
            chartMainFunc.AddFunc(fseq);
            chartMainFunc.AddFunc(ffree);
            chartMainFunc.DrawFunc();
        }

        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            lab2 form = new lab2();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;

        private void tabFormControl1_SelectedPageChanged(object sender, TabFormSelectedPageChangedEventArgs e)
        {
            #region FuncFurie
            if (e.Page==FuncFurie)
            {
                var funcSeg = chartMainFunc.internalDrawList.Find((a) => { return (string)a.Series.Tag == typeof(FunctionSequence).Name; });
                if (funcSeg == null || FuncFurie.Equals(funcSeg))
                {
                    return;
                }
                var funcSegWithFreeComp = chartMainFunc.internalDrawList.Find((a) => { return (string)a.Series.Tag == typeof(FunctionWithFreeComponent).Name; });
                if (funcSegWithFreeComp == null || chartFunctionAmplitudes.Equals(funcSegWithFreeComp))
                {
                    return;
                }
                FunctionSinCos fsincos = new FunctionSinCos(periodCount, "без а0", (FunctionSequence)funcSeg);
                fsincos.Build();
                memoFurieCoefs.Text = string.Empty;
                foreach (var item in fsincos.FurieRowCoeffs)
                {
                    memoFurieCoefs.Text += item.Key + "=" + Math.Round(item.Value, 2) + Environment.NewLine;
                }
                FunctionSinCos fsincosWithFreeComp = new FunctionSinCos(periodCount, "с а0", (FunctionSequence)funcSegWithFreeComp);
                fsincosWithFreeComp.Build();
                memoFurieCoefs.Text += "*******************" + Environment.NewLine;
                foreach (var item in fsincosWithFreeComp.FurieRowCoeffs)
                {
                    memoFurieCoefs.Text += item.Key + "=" + Math.Round(item.Value, 2)+ Environment.NewLine;
                }
                FunctionAch famain = new FunctionAch(fsincos.ComplexArray, "основной функции");
                FunctionAch fWithFreeComp = new FunctionAch(fsincosWithFreeComp.ComplexArray, "со свободным членом");
                chartFunctionAmplitudes.AddFunc(famain);
                chartFunctionAmplitudes.AddFunc(fWithFreeComp);
                //chartFunctionAmplitudes.AddFunc(funcSeg.FurieTransform().GetAFR);
                chartFunctionAmplitudes.DrawFunc();
            }
            #endregion
            #region FuncNormal            
            if (e.Page==FuncFilterNorma)
            {
                FunctionFromFile fff = new FunctionFromFile();
                fff.Build();
                var funcFromFileFiltere = chartFuncFilterACH.internalDrawList.Find((a) => { return (string)a.Series.Tag == typeof(FunctionApplyFilter).Name; });
                if (funcFromFileFiltere != null)
                {
                    FunctionFiltered ffed = new FunctionFiltered((FunctionACHFromFile)funcFromFileFiltere);
                    ffed.Build();
                    chartFiltre.AddFunc(ffed);
                }
                chartFiltre.AddFunc(fff);
                chartFiltre.DrawFunc();
            }
            #endregion
            #region FuncNormalAch
            if (e.Page==FuncFilterNormalACH)
            {
                var funcFromFile = chartFiltre.internalDrawList.Find((a) => { return (string)a.Series.Tag == typeof(FunctionFromFile).Name; });
                if (funcFromFile == null || FuncFurie.Equals(funcFromFile))
                {
                    return;
                }
                FunctionACHFromFile faff = new FunctionACHFromFile((FunctionFromFile)funcFromFile);
                faff.Build();
                FunctionFilter fil = new FunctionFilter(200, 300);
                fil.Build();
                FunctionApplyFilter faf = new FunctionApplyFilter(faff, fil);
                faf.Build();
                chartFuncFilterACH.AddFunc(faff);
                chartFuncFilterACH.AddFunc(faf);
                chartFuncFilterACH.AddFunc(fil);
                chartFuncFilterACH.DrawFunc();

            }
            #endregion

        }
    }
}
