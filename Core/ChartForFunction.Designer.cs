namespace Core
{
    partial class ChartForFunction
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.ppPlayer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            this.ppPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            xyDiagram1.AxisX.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero;
            xyDiagram1.AxisX.Color = System.Drawing.Color.Black;
            xyDiagram1.AxisX.GridLines.Color = System.Drawing.Color.Gray;
            xyDiagram1.AxisX.GridLines.MinorColor = System.Drawing.Color.Black;
            xyDiagram1.AxisX.GridLines.MinorVisible = true;
            xyDiagram1.AxisX.GridLines.Visible = true;
            xyDiagram1.AxisX.InterlacedColor = System.Drawing.Color.Black;
            xyDiagram1.AxisX.Label.TextColor = System.Drawing.Color.Black;
            xyDiagram1.AxisX.MinorCount = 1;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Zero;
            xyDiagram1.AxisY.Color = System.Drawing.Color.Black;
            xyDiagram1.AxisY.GridLines.Color = System.Drawing.Color.Gray;
            xyDiagram1.AxisY.GridLines.MinorColor = System.Drawing.Color.Black;
            xyDiagram1.AxisY.GridLines.MinorVisible = true;
            xyDiagram1.AxisY.Label.TextColor = System.Drawing.Color.Black;
            xyDiagram1.AxisY.MinorCount = 1;
            xyDiagram1.AxisY.Title.TextColor = System.Drawing.Color.White;
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.DefaultPane.BackColor = System.Drawing.Color.White;
            xyDiagram1.EnableAxisXScrolling = true;
            xyDiagram1.EnableAxisXZooming = true;
            xyDiagram1.EnableAxisYScrolling = true;
            xyDiagram1.EnableAxisYZooming = true;
            this.chart.Diagram = xyDiagram1;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.BackColor = System.Drawing.Color.Black;
            this.chart.Legend.TextColor = System.Drawing.Color.White;
            this.chart.Legend.UseCheckBoxes = true;
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chart.Name = "chart";
            this.chart.PaletteName = "Палитра1";
            this.chart.PaletteRepository.Add("Палитра1", new DevExpress.XtraCharts.Palette("Палитра1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(251)))), ((int)(((byte)(90))))), System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(251)))), ((int)(((byte)(90)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))))}));
            this.chart.PaletteRepository.Add("Палитра11", new DevExpress.XtraCharts.Palette("Палитра11", DevExpress.XtraCharts.PaletteScaleMode.Repeat, new DevExpress.XtraCharts.PaletteEntry[] {
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(251)))), ((int)(((byte)(90))))), System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(251)))), ((int)(((byte)(90)))))),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.Red, System.Drawing.Color.Red),
                new DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))))}));
            series1.Name = "Ряд 1";
            series1.View = lineSeriesView1;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chart.Size = new System.Drawing.Size(634, 489);
            this.chart.TabIndex = 1;
            this.chart.CustomPaint += new DevExpress.XtraCharts.CustomPaintEventHandler(this.chart_CustomPaint);
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // ppPlayer
            // 
            this.ppPlayer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ppPlayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.ppPlayer.Name = "ppPlayer";
            this.ppPlayer.Size = new System.Drawing.Size(110, 52);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // ChartForFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.ppPlayer;
            this.Controls.Add(this.chart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChartForFunction";
            this.Size = new System.Drawing.Size(634, 489);
            this.Load += new System.EventHandler(this.ChartForFunction_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ppPlayer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraCharts.ChartControl chart;
        private System.Windows.Forms.ContextMenuStrip ppPlayer;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
    }
}
