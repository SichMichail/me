namespace Lab2
{
    partial class lab2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            if (--OpenFormCount == 0) System.Windows.Forms.Application.Exit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.FuncAll = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.chartMainFunc = new Core.ChartForFunction();
            this.FuncFurie = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.memoFurieCoefs = new DevExpress.XtraEditors.MemoEdit();
            this.chartFunctionAmplitudes = new Core.ChartForFunction();
            this.FuncFilterNormalACH = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl4 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.chartFuncFilterACH = new Core.ChartForFunction();
            this.FuncFilterNormal = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl3 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.chartFiltres = new Core.ChartForFunction();
            this.xtraScrollableControl5 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.FuncFilterNorma = new DevExpress.XtraBars.TabFormPage();
            this.chartFiltre = new Core.ChartForFunction();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            this.xtraScrollableControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoFurieCoefs.Properties)).BeginInit();
            this.xtraScrollableControl4.SuspendLayout();
            this.xtraScrollableControl3.SuspendLayout();
            this.xtraScrollableControl5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Manager = this.tabFormDefaultManager1;
            this.tabFormControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.FuncAll);
            this.tabFormControl1.Pages.Add(this.FuncFurie);
            this.tabFormControl1.Pages.Add(this.FuncFilterNorma);
            this.tabFormControl1.Pages.Add(this.FuncFilterNormalACH);
            this.tabFormControl1.SelectedPage = this.FuncFilterNorma;
            this.tabFormControl1.Size = new System.Drawing.Size(915, 61);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStop = false;
            this.tabFormControl1.SelectedPageChanged += new DevExpress.XtraBars.TabFormSelectedPageChangedEventHandler(this.tabFormControl1_SelectedPageChanged);
            this.tabFormControl1.OuterFormCreating += new DevExpress.XtraBars.OuterFormCreatingEventHandler(this.OnOuterFormCreating);
            // 
            // tabFormDefaultManager1
            // 
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
            this.tabFormDefaultManager1.Form = this;
            this.tabFormDefaultManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 61);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(915, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 585);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(915, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 61);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 524);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(915, 61);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 524);
            // 
            // FuncAll
            // 
            this.FuncAll.ContentContainer = this.xtraScrollableControl1;
            this.FuncAll.Name = "FuncAll";
            this.FuncAll.Text = "Page 0";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.chartMainFunc);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 61);
            this.xtraScrollableControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(915, 524);
            this.xtraScrollableControl1.TabIndex = 1;
            // 
            // chartMainFunc
            // 
            this.chartMainFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMainFunc.Loaded = true;
            this.chartMainFunc.Location = new System.Drawing.Point(0, 0);
            this.chartMainFunc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartMainFunc.Name = "chartMainFunc";
            this.chartMainFunc.Size = new System.Drawing.Size(915, 524);
            this.chartMainFunc.TabIndex = 0;
            // 
            // FuncFurie
            // 
            this.FuncFurie.ContentContainer = this.xtraScrollableControl2;
            this.FuncFurie.Name = "FuncFurie";
            this.FuncFurie.Text = "Page 1";
            // 
            // xtraScrollableControl2
            // 
            this.xtraScrollableControl2.Controls.Add(this.memoFurieCoefs);
            this.xtraScrollableControl2.Controls.Add(this.chartFunctionAmplitudes);
            this.xtraScrollableControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl2.Location = new System.Drawing.Point(0, 61);
            this.xtraScrollableControl2.Name = "xtraScrollableControl2";
            this.xtraScrollableControl2.Size = new System.Drawing.Size(915, 524);
            this.xtraScrollableControl2.TabIndex = 6;
            // 
            // memoFurieCoefs
            // 
            this.memoFurieCoefs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoFurieCoefs.EditValue = "";
            this.memoFurieCoefs.Location = new System.Drawing.Point(711, 0);
            this.memoFurieCoefs.MenuManager = this.tabFormDefaultManager1;
            this.memoFurieCoefs.Name = "memoFurieCoefs";
            this.memoFurieCoefs.Size = new System.Drawing.Size(204, 524);
            this.memoFurieCoefs.TabIndex = 1;
            // 
            // chartFunctionAmplitudes
            // 
            this.chartFunctionAmplitudes.Dock = System.Windows.Forms.DockStyle.Left;
            this.chartFunctionAmplitudes.Loaded = true;
            this.chartFunctionAmplitudes.Location = new System.Drawing.Point(0, 0);
            this.chartFunctionAmplitudes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartFunctionAmplitudes.Name = "chartFunctionAmplitudes";
            this.chartFunctionAmplitudes.Size = new System.Drawing.Size(711, 524);
            this.chartFunctionAmplitudes.TabIndex = 0;
            // 
            // FuncFilterNormalACH
            // 
            this.FuncFilterNormalACH.ContentContainer = this.xtraScrollableControl4;
            this.FuncFilterNormalACH.Name = "FuncFilterNormalACH";
            this.FuncFilterNormalACH.Text = "Page 3";
            // 
            // xtraScrollableControl4
            // 
            this.xtraScrollableControl4.Controls.Add(this.chartFuncFilterACH);
            this.xtraScrollableControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl4.Location = new System.Drawing.Point(0, 61);
            this.xtraScrollableControl4.Name = "xtraScrollableControl4";
            this.xtraScrollableControl4.Size = new System.Drawing.Size(915, 524);
            this.xtraScrollableControl4.TabIndex = 8;
            // 
            // chartFuncFilterACH
            // 
            this.chartFuncFilterACH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartFuncFilterACH.Loaded = true;
            this.chartFuncFilterACH.Location = new System.Drawing.Point(0, 0);
            this.chartFuncFilterACH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartFuncFilterACH.Name = "chartFuncFilterACH";
            this.chartFuncFilterACH.Size = new System.Drawing.Size(915, 524);
            this.chartFuncFilterACH.TabIndex = 0;
            // 
            // FuncFilterNormal
            // 
            this.FuncFilterNormal.ContentContainer = this.xtraScrollableControl3;
            this.FuncFilterNormal.Name = "FuncFilterNormal";
            this.FuncFilterNormal.Text = "Page 2";
            // 
            // xtraScrollableControl3
            // 
            this.xtraScrollableControl3.Controls.Add(this.chartFiltres);
            this.xtraScrollableControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl3.Location = new System.Drawing.Point(0, 61);
            this.xtraScrollableControl3.Name = "xtraScrollableControl3";
            this.xtraScrollableControl3.Size = new System.Drawing.Size(921, 526);
            this.xtraScrollableControl3.TabIndex = 7;
            // 
            // chartFiltres
            // 
            this.chartFiltres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartFiltres.Loaded = true;
            this.chartFiltres.Location = new System.Drawing.Point(0, 0);
            this.chartFiltres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartFiltres.Name = "chartFiltres";
            this.chartFiltres.Size = new System.Drawing.Size(921, 526);
            this.chartFiltres.TabIndex = 0;
            // 
            // xtraScrollableControl5
            // 
            this.xtraScrollableControl5.Controls.Add(this.chartFiltre);
            this.xtraScrollableControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl5.Location = new System.Drawing.Point(0, 61);
            this.xtraScrollableControl5.Name = "xtraScrollableControl5";
            this.xtraScrollableControl5.Size = new System.Drawing.Size(915, 524);
            this.xtraScrollableControl5.TabIndex = 7;
            // 
            // FuncFilterNorma
            // 
            this.FuncFilterNorma.ContentContainer = this.xtraScrollableControl5;
            this.FuncFilterNorma.Name = "FuncFilterNorma";
            this.FuncFilterNorma.Text = "Page 3";
            // 
            // chartFiltre
            // 
            this.chartFiltre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartFiltre.Loaded = true;
            this.chartFiltre.Location = new System.Drawing.Point(0, 0);
            this.chartFiltre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartFiltre.Name = "chartFiltre";
            this.chartFiltre.Size = new System.Drawing.Size(915, 524);
            this.chartFiltre.TabIndex = 0;
            // 
            // lab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 585);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.xtraScrollableControl5);
            this.Controls.Add(this.tabFormControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "lab2";
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoFurieCoefs.Properties)).EndInit();
            this.xtraScrollableControl4.ResumeLayout(false);
            this.xtraScrollableControl3.ResumeLayout(false);
            this.xtraScrollableControl5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormDefaultManager tabFormDefaultManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraBars.TabFormPage FuncAll;
        private Core.ChartForFunction chartMainFunc;
        private DevExpress.XtraBars.TabFormPage FuncFurie;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl2;
        private Core.ChartForFunction chartFunctionAmplitudes;
        private DevExpress.XtraEditors.MemoEdit memoFurieCoefs;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl3;
        private Core.ChartForFunction chartFiltres;
        private DevExpress.XtraBars.TabFormPage FuncFilterNormal;
        private DevExpress.XtraBars.TabFormPage FuncFilterNormalACH;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl4;
        private Core.ChartForFunction chartFuncFilterACH;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl5;
        private DevExpress.XtraBars.TabFormPage FuncFilterNorma;
        private Core.ChartForFunction chartFiltre;
    }
}

