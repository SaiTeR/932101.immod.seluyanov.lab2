using System.Windows.Forms.DataVisualization.Charting;

namespace Lab2
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labDay = new System.Windows.Forms.Label();
            this.btStop = new System.Windows.Forms.Button();
            this.inputDollar = new System.Windows.Forms.NumericUpDown();
            this.labDollar = new System.Windows.Forms.Label();
            this.inputPrice = new System.Windows.Forms.NumericUpDown();
            this.btCalculate = new System.Windows.Forms.Button();
            this.labDays = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.outEuro = new System.Windows.Forms.Label();
            this.outDollar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputDollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Конечный курс Доллара:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Конечный курс Евро:";
            // 
            // labDay
            // 
            this.labDay.AutoSize = true;
            this.labDay.Location = new System.Drawing.Point(96, 103);
            this.labDay.Name = "labDay";
            this.labDay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labDay.Size = new System.Drawing.Size(13, 13);
            this.labDay.TabIndex = 8;
            this.labDay.Text = "0";
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(542, 77);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(216, 64);
            this.btStop.TabIndex = 7;
            this.btStop.Text = "Стоп";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // inputDollar
            // 
            this.inputDollar.Location = new System.Drawing.Point(159, 35);
            this.inputDollar.Name = "inputDollar";
            this.inputDollar.Size = new System.Drawing.Size(120, 20);
            this.inputDollar.TabIndex = 6;
            this.inputDollar.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            // 
            // labDollar
            // 
            this.labDollar.AutoSize = true;
            this.labDollar.Location = new System.Drawing.Point(12, 42);
            this.labDollar.Name = "labDollar";
            this.labDollar.Size = new System.Drawing.Size(141, 13);
            this.labDollar.TabIndex = 5;
            this.labDollar.Text = "Начальный курс Доллара:";
            // 
            // inputPrice
            // 
            this.inputPrice.Location = new System.Drawing.Point(159, 7);
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(120, 20);
            this.inputPrice.TabIndex = 3;
            this.inputPrice.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(542, 7);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(216, 64);
            this.btCalculate.TabIndex = 2;
            this.btCalculate.Text = "Рассчитать";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click_1);
            // 
            // labDays
            // 
            this.labDays.AutoSize = true;
            this.labDays.Location = new System.Drawing.Point(12, 103);
            this.labDays.Name = "labDays";
            this.labDays.Size = new System.Drawing.Size(78, 13);
            this.labDays.TabIndex = 1;
            this.labDays.Text = "Дней прошло:";
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(12, 14);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(121, 13);
            this.labPrice.TabIndex = 0;
            this.labPrice.Text = "Начальный курс Евро:";
            // 
            // chart1
            // 
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Minimum = 40D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(2, 147);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.IsValueShownAsLabel = true;
            series3.LabelFormat = "f4";
            series3.Legend = "Legend1";
            series3.LegendText = "Курс Евро";
            series3.Name = "Series1";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series4.IsValueShownAsLabel = true;
            series4.LabelFormat = "f4";
            series4.Legend = "Legend1";
            series4.LegendText = "Курс Доллара";
            series4.Name = "Series2";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(756, 462);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // outEuro
            // 
            this.outEuro.AutoSize = true;
            this.outEuro.Location = new System.Drawing.Point(476, 14);
            this.outEuro.Name = "outEuro";
            this.outEuro.Size = new System.Drawing.Size(19, 13);
            this.outEuro.TabIndex = 12;
            this.outEuro.Text = " ...";
            // 
            // outDollar
            // 
            this.outDollar.AutoSize = true;
            this.outDollar.Location = new System.Drawing.Point(476, 42);
            this.outDollar.Name = "outDollar";
            this.outDollar.Size = new System.Drawing.Size(19, 13);
            this.outDollar.TabIndex = 13;
            this.outDollar.Text = " ...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 612);
            this.Controls.Add(this.outDollar);
            this.Controls.Add(this.outEuro);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labPrice);
            this.Controls.Add(this.labDay);
            this.Controls.Add(this.labDays);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.inputPrice);
            this.Controls.Add(this.inputDollar);
            this.Controls.Add(this.labDollar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inputDollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown inputPrice;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Label labDays;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

        private System.Windows.Forms.NumericUpDown inputDollar;
        private System.Windows.Forms.Label labDollar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labDay;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label outEuro;
        private System.Windows.Forms.Label outDollar;
    }
}

