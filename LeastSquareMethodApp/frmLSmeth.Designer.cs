
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grParameters = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbCounter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPhi1 = new System.Windows.Forms.Label();
            this.grExpData = new System.Windows.Forms.GroupBox();
            this.dataY = new System.Windows.Forms.DataGridView();
            this.Yi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataX = new System.Windows.Forms.DataGridView();
            this.Xi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChartOfFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grMode = new System.Windows.Forms.GroupBox();
            this.rbModeDefine = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.grCoff = new System.Windows.Forms.GroupBox();
            this.lbA = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.grExpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOfFunction)).BeginInit();
            this.grMode.SuspendLayout();
            this.grCoff.SuspendLayout();
            this.SuspendLayout();
            // 
            // grParameters
            // 
            this.grParameters.Controls.Add(this.comboBox2);
            this.grParameters.Controls.Add(this.comboBox1);
            this.grParameters.Controls.Add(this.numericUpDown1);
            this.grParameters.Controls.Add(this.lbCounter);
            this.grParameters.Controls.Add(this.label1);
            this.grParameters.Controls.Add(this.lbPhi1);
            this.grParameters.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grParameters.Location = new System.Drawing.Point(27, 108);
            this.grParameters.Margin = new System.Windows.Forms.Padding(4);
            this.grParameters.Name = "grParameters";
            this.grParameters.Padding = new System.Windows.Forms.Padding(4);
            this.grParameters.Size = new System.Drawing.Size(390, 136);
            this.grParameters.TabIndex = 0;
            this.grParameters.TabStop = false;
            this.grParameters.Text = "Параметры";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(216, 82);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 22);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.grExpData.Controls.Add(this.dataY);
            this.grExpData.Controls.Add(this.dataX);
            this.grExpData.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grExpData.Location = new System.Drawing.Point(27, 265);
            this.grExpData.Name = "grExpData";
            this.grExpData.Size = new System.Drawing.Size(390, 184);
            this.grExpData.TabIndex = 1;
            this.grExpData.TabStop = false;
            this.grExpData.Text = "Данные эксперимента";
            // 
            // dataY
            // 
            this.dataY.AllowUserToAddRows = false;
            this.dataY.AllowUserToDeleteRows = false;
            this.dataY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Yi});
            this.dataY.Location = new System.Drawing.Point(6, 112);
            this.dataY.Name = "dataY";
            this.dataY.Size = new System.Drawing.Size(378, 57);
            this.dataY.TabIndex = 1;
            // 
            // Yi
            // 
            this.Yi.Frozen = true;
            this.Yi.HeaderText = "Yi";
            this.Yi.Name = "Yi";
            this.Yi.ToolTipText = "i-е значение";
            this.Yi.Width = 25;
            // 
            // dataX
            // 
            this.dataX.AllowUserToAddRows = false;
            this.dataX.AllowUserToDeleteRows = false;
            this.dataX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Xi});
            this.dataX.Location = new System.Drawing.Point(6, 31);
            this.dataX.Name = "dataX";
            this.dataX.Size = new System.Drawing.Size(378, 57);
            this.dataX.TabIndex = 0;
            // 
            // Xi
            // 
            this.Xi.Frozen = true;
            this.Xi.HeaderText = "Xi";
            this.Xi.Name = "Xi";
            this.Xi.ToolTipText = "i-е значение";
            this.Xi.Width = 25;
            // 
            // ChartOfFunction
            // 
            this.ChartOfFunction.BorderlineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.ChartOfFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartOfFunction.Legends.Add(legend1);
            this.ChartOfFunction.Location = new System.Drawing.Point(445, 26);
            this.ChartOfFunction.Name = "ChartOfFunction";
            this.ChartOfFunction.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartOfFunction.Series.Add(series1);
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
            this.grMode.Size = new System.Drawing.Size(390, 66);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "√x",
            "x^2",
            "x",
            "sin ⁡x"});
            this.comboBox1.Location = new System.Drawing.Point(76, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ln⁡x",
            "cos⁡x",
            "1/x",
            "x",
            "x^2"});
            this.comboBox2.Location = new System.Drawing.Point(76, 81);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 7;
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
            // frmLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 461);
            this.Controls.Add(this.grCoff);
            this.Controls.Add(this.grMode);
            this.Controls.Add(this.ChartOfFunction);
            this.Controls.Add(this.grExpData);
            this.Controls.Add(this.grParameters);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLS";
            this.Text = "Метод наименьших квадратов";
            this.grParameters.ResumeLayout(false);
            this.grParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.grExpData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataY)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbCounter;
        private System.Windows.Forms.GroupBox grExpData;
        private System.Windows.Forms.DataGridView dataY;
        private System.Windows.Forms.DataGridView dataX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Xi;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartOfFunction;
        private System.Windows.Forms.GroupBox grMode;
        private System.Windows.Forms.RadioButton rbModeDefine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yi;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox grCoff;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbA;
    }
}

