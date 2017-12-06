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
using DevExpress.XtraEditors;

namespace lab4
{
    public partial class frmMain :DevExpress.XtraBars.TabForm
    {
        #region Definition

        FunctionUd funcud;

        FunctionVd funcvd;

        FunctionZd funczd;

        FunctionUd funcudiscr;

        FunctionVd funcvdiscr;

        FunctionZd funczdiscr;

        FunctionZd1 funczd1;

        FurieFunction spectreU;

        FurieFunction spectreV;

        FurieFunction spectreZ;

        FurieFunction energyspectreZ;

        FurieFunction energyspectreV;

        FurieFunction energyspectreU;

        FunctionDiscretCorrelation acfu;

        FunctionDiscretCorrelation acfv;

        FunctionDiscretCorrelation acfz;

        FunctionDiscretCorrelation acfuv;

        FunctionDiscretCorrelation acfvz;

        FunctionDiscretCorrelation acfuz;

        FurieFunction enuvrel;

        FurieFunction enuzrel;

        FurieFunction envzrel;

        FurieFunction enuz1rel;

        FurieFunction envz1rel;

        FunctionDiscretCorrelation relcorz1ud;

        FunctionDiscretCorrelation relcorz1vd;
        #endregion



        public frmMain()
        {
            InitializeComponent();
            FunctionU funcu = new FunctionU();
            funcu.Build();
            FunctionV funcV = new FunctionV();
            funcV.Build();
            FunctionZ funcZ = new FunctionZ(funcu, funcV);
            funcZ.Build();
            var powerU = funcu.Power();
            var powerV = funcV.Power();
            var powerZ = funcZ.Power();
            var spectreU = funcu.FurieTransform().GetAFR;
            var spectreV = funcV.FurieTransform().GetAFR;
            var spectreZ = funcZ.FurieTransform().GetAFR;
            var energySpectU = funcu.EnergySpectre().GetAFR;
            var energySpectV = funcV.EnergySpectre().GetAFR;
            var energySpectZ = funcZ.EnergySpectre().GetAFR;
            var relativeSpectre = funcu.RelativeEnergySpectre(funcV).GetAFR;
            chartForMainSignals.AddFunc(powerU);
            chartForMainSignals.AddFunc(powerV);
            chartForMainSignals.AddFunc(powerZ);
            chartForMainSignals.AddFunc(funcu);
            chartForMainSignals.AddFunc(funcV);
            chartForMainSignals.AddFunc(funcZ);
            chartForMainSignals.AddFunc(spectreU);
            chartForMainSignals.AddFunc(spectreV);
            chartForMainSignals.AddFunc(spectreZ);
            chartForMainSignals.AddFunc(energySpectU);
            chartForMainSignals.AddFunc(energySpectV);
            chartForMainSignals.AddFunc(energySpectZ);
            chartForMainSignals.AddFunc(relativeSpectre);
            chartForMainSignals.DrawFunc();
            ResultOutPut(memoResults, funcu);
            ResultOutPut(memoResults, funcV);
            ResultOutPut(memoResults, funcZ);
            memoResults.Text += "Скалярное произведение v и u =" + funcu.ScalarProduct(funcV) + Environment.NewLine;
            memoResults.Text += "косинус угла между v и u =" + funcu.ScalarProduct(funcV)/(funcu.Norma() * funcV.Norma()) + Environment.NewLine;
            memoResults.Text += energySpectU.FullEnergy() + Environment.NewLine;
            memoResults.Text += energySpectV.FullEnergy() + Environment.NewLine;
            memoResults.Text += energySpectZ.FullEnergy() + Environment.NewLine;
            //memoResults.Text += relativeSpectre.FullEnergy() + Environment.NewLine;
        }

        public void ResultOutPut(MemoEdit inpMemo, Function inpFunc)
        {
            inpMemo.Text += "Норма сигнала" + inpFunc.Series.Name + "=" + inpFunc.Norma() + Environment.NewLine;
            var power = inpFunc.Power();
            inpMemo.Text += "Энергия сигнала" + inpFunc.Series.Name + "=" + power.Integral() + Environment.NewLine;
        }


        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            frmMain form = new frmMain();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;

        private void tabFormControl1_SelectedPageChanged(object sender, TabFormSelectedPageChangedEventArgs e)
        {
            if (e.Page == tabpPart2)
            {
                funcud = new FunctionUd();
                funcud.Build();
                funcvd = new FunctionVd();
                funcvd.Build();
                funczd = new FunctionZd(funcud, funcvd);
                funczd.Build();
                funczd1 = new FunctionZd1(funcud, funcvd);
                funczd1.Build();

                funcudiscr = new FunctionUd();
                funcudiscr.Build();
                funcudiscr.MadeDiscret();

                funcvdiscr = new FunctionVd();
                funcvdiscr.Build();
                funcvdiscr.MadeDiscret();

                funczdiscr = new FunctionZd(funcudiscr, funcvdiscr);
                funczdiscr.Build();
                funczdiscr.MadeDiscret();

                spectreU = funcud.FurieTransform().GetAFR;
                spectreV = funcvd.FurieTransform().GetAFR;
                spectreZ = funczd.FurieTransform().GetAFR;

                energyspectreZ = funczd.EnergySpectre().GetAFR;
                energyspectreV = funcvd.EnergySpectre().GetAFR;
                energyspectreU = funcud.EnergySpectre().GetAFR;

                acfu = funcud.AutoCorrelationFunctionDiscret(500);
                acfv = funcvd.AutoCorrelationFunctionDiscret(500);
                acfz = funczd.AutoCorrelationFunctionDiscret(500);

                acfuv = funcud.CorrelationFunctionDiscret(funcvd, 500);
                acfuz = funcud.CorrelationFunctionDiscret(funczd, 500);
                acfvz = funcvd.CorrelationFunctionDiscret(funczd, 500);

                enuvrel = funcud.RelativeEnergySpectre(funcvd).GetAFR;
                enuzrel = funcud.RelativeEnergySpectre(funczd).GetAFR;
                envzrel = funcvd.RelativeEnergySpectre(funczd).GetAFR;


                enuz1rel = funcud.RelativeEnergySpectre(funczd1).GetAFR;
                envz1rel = funcvd.RelativeEnergySpectre(funczd1).GetAFR;

                relcorz1vd = funczd1.CorrelationFunctionDiscret(funcvd, 500);
                relcorz1ud = funczd1.CorrelationFunctionDiscret(funcud, 500);

                //var energyvz = acfvz.FurieTransform().GetAFR;

                //chartForPart2.AddFunc(spectreU);
                //chartForPart2.AddFunc(spectreV);
                //chartForPart2.AddFunc(spectreZ);
                //chartForPart2.AddFunc(energyspectreU);
                //chartForPart2.AddFunc(energyspectreV);
                //chartForPart2.AddFunc(energyspectreZ);
                //chartForPart2.AddFunc(funcud.AutoCorrelationContinous(1));
                //chartForPart2.AddFunc(funcvd.AutoCorrelationContinous(1));
                //chartForPart2.AddFunc(funczd.AutoCorrelationContinous(1));
                //chartForPart2.AddFunc(funcud.AutoCovariationDiscret(500));
                //chartForPart2.AddFunc(funcvd.AutoCovariationDiscret(500));
                //chartForPart2.AddFunc(acfu);
                //chartForPart2.AddFunc(acfv);
                //chartForPart2.AddFunc(acfz);
                //chartForPart2.AddFunc(acfuv);
                //chartForPart2.AddFunc(acfvz);
                //chartForPart2.AddFunc(acfuz);

                //chartForPart2.AddFunc(enuvrel);
                //chartForPart2.AddFunc(envzrel);
                //chartForPart2.AddFunc(enuzrel);

                //chartForPart2.AddFunc(acfuv.FurieTransform().GetAFR);
                //chartForPart2.AddFunc(energyvz);
                //chartForPart2.AddFunc(acfuz.FurieTransform().GetAFR);



                //chartForPart2.AddFunc(funczd.AutoCovariationDiscret(500));
                //chartForPart2.AddFunc(funczd);
                //chartForPart2.AddFunc(funczd1);
                //chartForPart2.AddFunc(funcud);

                //chartForPart2.AddFunc(funcvd);
                //chartForPart2.AddFunc(energyspectreV.FurieTransformInversion());
                //chartForPart2.AddFunc(energyspectreU.FurieTransformInversion());
                //chartForPart2.AddFunc(energyspectreZ.FurieTransformInversion());
                //chartForPart2.AddFunc(enuvrel.FurieTransformInversion());
                //chartForPart2.AddFunc(enuzrel.FurieTransformInversion());
                //chartForPart2.AddFunc(envzrel.FurieTransformInversion());
                memoPart2.Text += "Скалярное произведение ud и vd =" + funcud.ScalarProduct(funcvd) + Environment.NewLine;
                memoPart2.Text += "Скалярное произведение ud и zd =" + funcud.ScalarProduct(funczd) + Environment.NewLine;
                memoPart2.Text += "Скалярное произведение vd и zd =" + funcvd.ScalarProduct(funczd) + Environment.NewLine;
                //memoResults.Text += "косинус угла между v и u =" + funcu.Norma() / funcV.Norma() + Environment.NewLine;

                //ResultOutPut(memoPart2, funcud);
                //ResultOutPut(memoPart2, funcvd);
                //ResultOutPut(memoPart2, funczd);
                //memoPart2.Text += "энерг из вкф вз" + energyvz.FullEnergy() + Environment.NewLine;
                //memoPart2.Text += "энерг чистая вз" + envzrel.FullEnergy() + Environment.NewLine;
                //chartForPart2.DrawFunc();



            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBoxControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartForPart2.internalDrawList.Clear();
            switch (listBoxControl2.SelectedIndex)
            {
                case 0:
                    {
                        chartForPart2.AddFunc(funcud);
                        chartForPart2.AddFunc(funcvd);
                        chartForPart2.AddFunc(funczd);
                        chartForPart2.AddFunc(funcudiscr);
                        chartForPart2.AddFunc(funcvdiscr);
                        chartForPart2.AddFunc(funczdiscr);

                        break;
                    }
                case 1:
                    {
                        chartForPart2.AddFunc(funcud.AutoCorrelationContinous(1));
                        chartForPart2.AddFunc(funcvd.AutoCorrelationContinous(1));
                        chartForPart2.AddFunc(funczd.AutoCorrelationContinous(1));
                        break;
                    }
                case 2:
                    {
                        chartForPart2.AddFunc(acfu);
                        chartForPart2.AddFunc(acfv);
                        chartForPart2.AddFunc(acfz);
                        break;
                    }
                case 3:
                case 4:
                    {
                        chartForPart2.AddFunc(spectreU);
                        chartForPart2.AddFunc(spectreV);
                        chartForPart2.AddFunc(spectreZ);
                        break;
                    }

                case 5:
                case 6:
                    {
                        chartForPart2.AddFunc(energyspectreU);
                        chartForPart2.AddFunc(energyspectreV);
                        chartForPart2.AddFunc(energyspectreZ);
                        break;
                    }

                case 8:
                case 7:
                    {
                        chartForPart2.AddFunc(energyspectreV.FurieTransformInversion());
                        chartForPart2.AddFunc(energyspectreU.FurieTransformInversion());
                        chartForPart2.AddFunc(energyspectreZ.FurieTransformInversion());
                        break;
                    }
                case 9:
                case 10:
                    {
                        chartForPart2.AddFunc(funcud.AutoCovariationDiscret(500));
                        chartForPart2.AddFunc(funcvd.AutoCovariationDiscret(500));
                        chartForPart2.AddFunc(funczd.AutoCovariationDiscret(500));
                        break;
                    }
                case 11:
                    {
                        chartForPart2.AddFunc(funcud.CorrelationFunctionContinous(funcvd, 1));
                        chartForPart2.AddFunc(funcud.CorrelationFunctionContinous(funczd, 1));
                        chartForPart2.AddFunc(funcvd.CorrelationFunctionContinous(funczd, 1));
                        break;
                    }
                case 12:
                    {
                        chartForPart2.AddFunc(acfuv);
                        chartForPart2.AddFunc(acfvz);
                        chartForPart2.AddFunc(acfuz);
                        break;
                    }
                case 13:
                    {
                        chartForPart2.AddFunc(enuvrel);
                        chartForPart2.AddFunc(enuzrel);
                        chartForPart2.AddFunc(envzrel);
                        break;
                    }
                case 14:
                    {
                        chartForPart2.AddFunc(enuvrel.FurieTransformInversion());
                        chartForPart2.AddFunc(enuzrel.FurieTransformInversion());
                        chartForPart2.AddFunc(envzrel.FurieTransformInversion());
                        break;
                    }
                case 15:
                    {
                        chartForPart2.AddFunc(funczd1);
                        break;
                    }
                case 16:
                    {
                        chartForPart2.AddFunc(envz1rel);
                        chartForPart2.AddFunc(enuz1rel);
                        break;
                    }
                case 17:
                    {
                        chartForPart2.AddFunc(envz1rel.FurieTransformInversion());
                        chartForPart2.AddFunc(enuz1rel.FurieTransformInversion());
                        break;
                    }
                case 18:
                    {
                        chartForPart2.AddFunc(relcorz1ud);
                        chartForPart2.AddFunc(relcorz1vd);
                        break;
                    }








                default:
                    break;
            }
            chartForPart2.DrawFunc();
        }
    }
}
