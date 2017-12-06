namespace lab4
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.memoResults = new DevExpress.XtraEditors.MemoEdit();
            this.chartForMainSignals = new Core.ChartForFunction();
            this.tabpPart2 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartForPart2 = new Core.ChartForFunction();
            this.memoPart2 = new DevExpress.XtraEditors.MemoEdit();
            this.listBoxControl2 = new DevExpress.XtraEditors.ListBoxControl();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoResults.Properties)).BeginInit();
            this.xtraScrollableControl2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoPart2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Manager = this.tabFormDefaultManager1;
            this.tabFormControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPage1);
            this.tabFormControl1.Pages.Add(this.tabpPart2);
            this.tabFormControl1.SelectedPage = this.tabFormPage1;
            this.tabFormControl1.Size = new System.Drawing.Size(1093, 61);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1093, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 621);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1093, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 61);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 560);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1093, 61);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 560);
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.xtraScrollableControl1;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Page 0";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.memoResults);
            this.xtraScrollableControl1.Controls.Add(this.chartForMainSignals);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 61);
            this.xtraScrollableControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1093, 560);
            this.xtraScrollableControl1.TabIndex = 1;
            // 
            // memoResults
            // 
            this.memoResults.Dock = System.Windows.Forms.DockStyle.Right;
            this.memoResults.Location = new System.Drawing.Point(878, 0);
            this.memoResults.MenuManager = this.tabFormDefaultManager1;
            this.memoResults.Name = "memoResults";
            this.memoResults.Size = new System.Drawing.Size(215, 560);
            this.memoResults.TabIndex = 1;
            // 
            // chartForMainSignals
            // 
            this.chartForMainSignals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartForMainSignals.Loaded = true;
            this.chartForMainSignals.Location = new System.Drawing.Point(0, 0);
            this.chartForMainSignals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartForMainSignals.Name = "chartForMainSignals";
            this.chartForMainSignals.Size = new System.Drawing.Size(872, 560);
            this.chartForMainSignals.TabIndex = 0;
            // 
            // tabpPart2
            // 
            this.tabpPart2.ContentContainer = this.xtraScrollableControl2;
            this.tabpPart2.Name = "tabpPart2";
            this.tabpPart2.Text = "Page 1";
            // 
            // xtraScrollableControl2
            // 
            this.xtraScrollableControl2.Controls.Add(this.tableLayoutPanel1);
            this.xtraScrollableControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl2.Location = new System.Drawing.Point(0, 61);
            this.xtraScrollableControl2.Name = "xtraScrollableControl2";
            this.xtraScrollableControl2.Size = new System.Drawing.Size(1093, 560);
            this.xtraScrollableControl2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chartForPart2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.memoPart2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxControl2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.89286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.10714F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1093, 560);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // chartForPart2
            // 
            this.chartForPart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartForPart2.Loaded = true;
            this.chartForPart2.Location = new System.Drawing.Point(3, 2);
            this.chartForPart2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartForPart2.Name = "chartForPart2";
            this.chartForPart2.Size = new System.Drawing.Size(540, 449);
            this.chartForPart2.TabIndex = 0;
            // 
            // memoPart2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.memoPart2, 2);
            this.memoPart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoPart2.Location = new System.Drawing.Point(3, 456);
            this.memoPart2.MenuManager = this.tabFormDefaultManager1;
            this.memoPart2.Name = "memoPart2";
            this.memoPart2.Size = new System.Drawing.Size(1087, 101);
            this.memoPart2.TabIndex = 1;
            // 
            // listBoxControl2
            // 
            this.listBoxControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.listBoxControl2.Appearance.Options.UseFont = true;
            this.listBoxControl2.Appearance.Options.UseTextOptions = true;
            this.listBoxControl2.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
            this.listBoxControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.listBoxControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl2.ItemAutoHeight = true;
            this.listBoxControl2.Items.AddRange(new object[] {
            resources.GetString("listBoxControl2.Items"),
            "Вычислите АКФ сигналов в непрерывном варианте И постройте график получившихся АКФ" +
                "",
            "Вычислите АКФ сигналов ud, vd, zd в дискретном варианте И постройте график получи" +
                "вшихся АКФ.",
            "Вычислите плотности спектров сигналов u и v в непрерывном варианте и постройте их" +
                " графики.",
            "Вычислите плотности спектров сигналов ud и vd с использованием БПФ и постройте их" +
                " графики",
            "Вычислите спектральные плотности мощности сигналов u, v, z и постройте их графики" +
                "",
            "Вычислите спектральные плотности мощности сигналов ud, vd, zd и постройте их граф" +
                "ики",
            "Вычислите функцию автокорреляции сигналов u и v через спектральные плотности мощн" +
                "ости и постройте ее график.",
            "Вычислите функции автокорреляции сигналов ud и vd через спектральные плотности мо" +
                "щности и постройте их графики.",
            "Вычислите функции автоковариации сигналов u, v, z.",
            "Вычислите автоковариационную функцию сигналов u, v, z и постройте их графики.",
            "Постройте графики взаимных корреляционных функций сигналов u, v, z.",
            "Вычислите взаимные корреляционные функции сигналов ud и vd, ud и zd, vd и zd, и п" +
                "остройте их графики.",
            "Вычислите спектральные плотности мощности сигналов ud и vd, ud и zd, vd и zd, и п" +
                "остройте их графики.",
            "Вычислите функции взаимной корреляции сигналов ud и vd, ud и zd, vd и zd через сп" +
                "ектральные плотности мощности, и постройте их графики.",
            "Сдвиньте сигнал zd по временной оси на 1и постройте их графики.",
            "Вычислите спектральные плотности взаимной мощности сигналов ud и z1, vd и z1, и п" +
                "остройте их графики.",
            "Вычислите функции взаимной корреляции сигналов ud и z1, vd и z1 через спектральны" +
                "е плотности мощности, и постройте их графики.",
            "Вычислите функции взаимной корреляции сигналов z1 и ud, z1 и vd, и постройте их г" +
                "рафики.",
            "Вычислите функцию взаимной ковариации сигналов ud и vd, ud и zd, vd и zd, и постр" +
                "ойте их графики.",
            "Вычислите функцию взаимной ковариации сигналов ud и vd, ud и zd, vd и zd через сп" +
                "ектральные плотности мощности, и постройте их графики."});
            this.listBoxControl2.Location = new System.Drawing.Point(549, 3);
            this.listBoxControl2.Name = "listBoxControl2";
            this.listBoxControl2.Size = new System.Drawing.Size(541, 447);
            this.listBoxControl2.TabIndex = 2;
            this.listBoxControl2.SelectedIndexChanged += new System.EventHandler(this.listBoxControl2_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(889, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 526);
            this.panel2.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 621);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Controls.Add(this.tabFormControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoResults.Properties)).EndInit();
            this.xtraScrollableControl2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoPart2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl2)).EndInit();
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
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private Core.ChartForFunction chartForMainSignals;
        private DevExpress.XtraEditors.MemoEdit memoResults;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl2;
        private DevExpress.XtraBars.TabFormPage tabpPart2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.MemoEdit memoPart2;
        private Core.ChartForFunction chartForPart2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl2;
    }
}

