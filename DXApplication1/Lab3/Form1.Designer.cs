namespace Lab3
{
    partial class Form1
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
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chrtWindows1 = new Core.ChartForFunction();
            this.chrtWindows2 = new Core.ChartForFunction();
            this.chrtWindows3 = new Core.ChartForFunction();
            this.chrtWindows4 = new Core.ChartForFunction();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Manager = this.tabFormDefaultManager1;
            this.tabFormControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPage1);
            this.tabFormControl1.SelectedPage = this.tabFormPage1;
            this.tabFormControl1.Size = new System.Drawing.Size(907, 61);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStop = false;
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
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(907, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 605);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(907, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 605);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(907, 0);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 605);
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.xtraScrollableControl1;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.Text = "Page 0";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.tableLayoutPanel1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 61);
            this.xtraScrollableControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(907, 544);
            this.xtraScrollableControl1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chrtWindows1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chrtWindows2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chrtWindows3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chrtWindows4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(907, 544);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // chrtWindows1
            // 
            this.chrtWindows1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrtWindows1.Loaded = true;
            this.chrtWindows1.Location = new System.Drawing.Point(3, 2);
            this.chrtWindows1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chrtWindows1.Name = "chrtWindows1";
            this.chrtWindows1.Size = new System.Drawing.Size(447, 268);
            this.chrtWindows1.TabIndex = 0;
            this.chrtWindows1.Click += new System.EventHandler(this.chrtWindows_Click);
            this.chrtWindows1.DoubleClick += new System.EventHandler(this.chrtWindows_DoubleClick);
            // 
            // chrtWindows2
            // 
            this.chrtWindows2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrtWindows2.Loaded = true;
            this.chrtWindows2.Location = new System.Drawing.Point(456, 2);
            this.chrtWindows2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chrtWindows2.Name = "chrtWindows2";
            this.chrtWindows2.Size = new System.Drawing.Size(448, 268);
            this.chrtWindows2.TabIndex = 1;
            // 
            // chrtWindows3
            // 
            this.chrtWindows3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrtWindows3.Loaded = true;
            this.chrtWindows3.Location = new System.Drawing.Point(3, 274);
            this.chrtWindows3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chrtWindows3.Name = "chrtWindows3";
            this.chrtWindows3.Size = new System.Drawing.Size(447, 268);
            this.chrtWindows3.TabIndex = 2;
            // 
            // chrtWindows4
            // 
            this.chrtWindows4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chrtWindows4.Loaded = true;
            this.chrtWindows4.Location = new System.Drawing.Point(456, 274);
            this.chrtWindows4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chrtWindows4.Name = "chrtWindows4";
            this.chrtWindows4.Size = new System.Drawing.Size(448, 268);
            this.chrtWindows4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 605);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Controls.Add(this.tabFormControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private Core.ChartForFunction chrtWindows1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Core.ChartForFunction chrtWindows2;
        private Core.ChartForFunction chrtWindows3;
        private Core.ChartForFunction chrtWindows4;
    }
}

