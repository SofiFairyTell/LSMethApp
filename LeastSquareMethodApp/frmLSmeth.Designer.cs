
namespace LeastSquareMethodApp
{
    partial class frmLS
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grParameters = new System.Windows.Forms.GroupBox();
            this.ExpNumCount = new System.Windows.Forms.NumericUpDown();
            this.lbCounter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPhi1 = new System.Windows.Forms.Label();
            this.grExpData = new System.Windows.Forms.GroupBox();
            this.dataX = new System.Windows.Forms.DataGridView();
            this.ChartOfFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grMode = new System.Windows.Forms.GroupBox();
            this.rbModeDefine = new System.Windows.Forms.RadioButton();
            this.cbPhi1 = new System.Windows.Forms.ComboBox();
            this.cbPhi2 = new System.Windows.Forms.ComboBox();
            this.grCoff = new System.Windows.Forms.GroupBox();
            this.lbA = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSolution = new System.Windows.Forms.Button();
            this.ExpNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpNumCount)).BeginInit();
            this.grExpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOfFunction)).BeginInit();
            this.grMode.SuspendLayout();
            this.grCoff.SuspendLayout();
            this.SuspendLayout();
            // 
            // grParameters
            // 
            this.grParameters.Controls.Add(this.cbPhi2);
            this.grParameters.Controls.Add(this.cbPhi1);
            this.grParameters.Controls.Add(this.ExpNumCount);
            this.grParameters.Controls.Add(this.lbCounter);
            this.grParameters.Controls.Add(this.label1);
            this.grParameters.Controls.Add(this.lbPhi1);
            this.grParameters.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grParameters.Location = new System.Drawing.Point(27, 90);
            this.grParameters.Margin = new System.Windows.Forms.Padding(4);
            this.grParameters.Name = "grParameters";
            this.grParameters.Padding = new System.Windows.Forms.Padding(4);
            this.grParameters.Size = new System.Drawing.Size(390, 121);
            this.grParameters.TabIndex = 0;
            this.grParameters.TabStop = false;
            this.grParameters.Text = "Параметры";
            // 
            // ExpNumCount
            // 
            this.ExpNumCount.Location = new System.Drawing.Point(216, 82);
            this.ExpNumCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ExpNumCount.Name = "ExpNumCount";
            this.ExpNumCount.Size = new System.Drawing.Size(150, 22);
            this.ExpNumCount.TabIndex = 5;
            this.ExpNumCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ExpNumCount.ValueChanged += new System.EventHandler(this.ExpNumCount_ValueChanged);
            // 
            // lbCounter
            // 
            this.lbCounter.AutoSize = true;
            this.lbCounter.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbCounter.Location = new System.Drawing.Point(213, 42);
            this.lbCounter.Name = "lbCounter";
            this.lbCounter.Size = new System.Drawing.Size(153, 32);
            this.lbCounter.TabIndex = 4;
            this.lbCounter.Text = "Введите количество \r\nданных эксперимента";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ф_2(x):";
            // 
            // lbPhi1
            // 
            this.lbPhi1.AutoSize = true;
            this.lbPhi1.Location = new System.Drawing.Point(10, 42);
            this.lbPhi1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPhi1.Name = "lbPhi1";
            this.lbPhi1.Size = new System.Drawing.Size(58, 16);
            this.lbPhi1.TabIndex = 0;
            this.lbPhi1.Text = "ф_1 (x):";
            // 
            // grExpData
            // 
            this.grExpData.Controls.Add(this.dataX);
            this.grExpData.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grExpData.Location = new System.Drawing.Point(27, 218);
            this.grExpData.Name = "grExpData";
            this.grExpData.Size = new System.Drawing.Size(390, 184);
            this.grExpData.TabIndex = 1;
            this.grExpData.TabStop = false;
            this.grExpData.Text = "Данные эксперимента";
            // 
            // dataX
            // 
            this.dataX.AllowUserToAddRows = false;
            this.dataX.AllowUserToDeleteRows = false;
            this.dataX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExpNum});
            this.dataX.Location = new System.Drawing.Point(6, 31);
            this.dataX.Name = "dataX";
            this.dataX.Size = new System.Drawing.Size(378, 78);
            this.dataX.TabIndex = 0;
            // 
            // ChartOfFunction
            // 
            this.ChartOfFunction.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea2.Name = "ChartArea1";
            this.ChartOfFunction.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartOfFunction.Legends.Add(legend2);
            this.ChartOfFunction.Location = new System.Drawing.Point(445, 26);
            this.ChartOfFunction.Name = "ChartOfFunction";
            this.ChartOfFunction.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ChartOfFunction.Series.Add(series2);
            this.ChartOfFunction.Size = new System.Drawing.Size(379, 327);
            this.ChartOfFunction.TabIndex = 2;
            this.ChartOfFunction.Text = "chart1";
            // 
            // grMode
            // 
            this.grMode.Controls.Add(this.rbModeDefine);
            this.grMode.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grMode.Location = new System.Drawing.Point(27, 26);
            this.grMode.Name = "grMode";
            this.grMode.Size = new System.Drawing.Size(390, 57);
            this.grMode.TabIndex = 3;
            this.grMode.TabStop = false;
            this.grMode.Text = "Режимы";
            // 
            // rbModeDefine
            // 
            this.rbModeDefine.AutoSize = true;
            this.rbModeDefine.Location = new System.Drawing.Point(13, 22);
            this.rbModeDefine.Name = "rbModeDefine";
            this.rbModeDefine.Size = new System.Drawing.Size(198, 21);
            this.rbModeDefine.TabIndex = 0;
            this.rbModeDefine.TabStop = true;
            this.rbModeDefine.Text = "Определить коэффициенты";
            this.rbModeDefine.UseCompatibleTextRendering = true;
            this.rbModeDefine.UseVisualStyleBackColor = true;
            // 
            // cbPhi1
            // 
            this.cbPhi1.FormattingEnabled = true;
            this.cbPhi1.Items.AddRange(new object[] {
            "√x",
            "x^2",
            "x",
            "sin ⁡x"});
            this.cbPhi1.Location = new System.Drawing.Point(76, 42);
            this.cbPhi1.Name = "cbPhi1";
            this.cbPhi1.Size = new System.Drawing.Size(121, 24);
            this.cbPhi1.TabIndex = 6;
            // 
            // cbPhi2
            // 
            this.cbPhi2.FormattingEnabled = true;
            this.cbPhi2.Items.AddRange(new object[] {
            "ln⁡x",
            "cos⁡x",
            "1/x",
            "x",
            "x^2"});
            this.cbPhi2.Location = new System.Drawing.Point(76, 81);
            this.cbPhi2.Name = "cbPhi2";
            this.cbPhi2.Size = new System.Drawing.Size(121, 24);
            this.cbPhi2.TabIndex = 7;
            // 
            // grCoff
            // 
            this.grCoff.Controls.Add(this.textBox1);
            this.grCoff.Controls.Add(this.lbA);
            this.grCoff.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grCoff.Location = new System.Drawing.Point(445, 377);
            this.grCoff.Name = "grCoff";
            this.grCoff.Size = new System.Drawing.Size(379, 72);
            this.grCoff.TabIndex = 4;
            this.grCoff.TabStop = false;
            this.grCoff.Text = "Коэффициенты";
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(6, 41);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(67, 16);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "a0, a1, a2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btnSolution
            // 
            this.btnSolution.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSolution.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSolution.Location = new System.Drawing.Point(112, 417);
            this.btnSolution.Name = "btnSolution";
            this.btnSolution.Size = new System.Drawing.Size(204, 23);
            this.btnSolution.TabIndex = 5;
            this.btnSolution.Text = "Провести аппроксимацию";
            this.btnSolution.UseVisualStyleBackColor = false;
            this.btnSolution.Click += new System.EventHandler(this.btnSolution_Click);
            // 
            // ExpNum
            // 
            this.ExpNum.Frozen = true;
            this.ExpNum.HeaderText = "i";
            this.ExpNum.Name = "ExpNum";
            this.ExpNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ExpNum.ToolTipText = "i-е значение";
            this.ExpNum.Width = 25;
            // 
            // frmLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 461);
            this.Controls.Add(this.btnSolution);
            this.Controls.Add(this.grCoff);
            this.Controls.Add(this.grMode);
            this.Controls.Add(this.ChartOfFunction);
            this.Controls.Add(this.grExpData);
            this.Controls.Add(this.grParameters);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLS";
            this.Text = "Метод наименьших квадратов";
            this.Load += new System.EventHandler(this.frmLS_Load);
            this.grParameters.ResumeLayout(false);
            this.grParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpNumCount)).EndInit();
            this.grExpData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOfFunction)).EndInit();
            this.grMode.ResumeLayout(false);
            this.grMode.PerformLayout();
            this.grCoff.ResumeLayout(false);
            this.grCoff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grParameters;
        private System.Windows.Forms.Label lbPhi1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ExpNumCount;
        private System.Windows.Forms.Label lbCounter;
        private System.Windows.Forms.GroupBox grExpData;
        private System.Windows.Forms.DataGridView dataX;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartOfFunction;
        private System.Windows.Forms.GroupBox grMode;
        private System.Windows.Forms.RadioButton rbModeDefine;
        private System.Windows.Forms.ComboBox cbPhi2;
        private System.Windows.Forms.ComboBox cbPhi1;
        private System.Windows.Forms.GroupBox grCoff;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Button btnSolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpNum;
    }
}

