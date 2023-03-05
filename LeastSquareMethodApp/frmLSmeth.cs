using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LeastSquareMethodApp
{
    public partial class frmLS : Form
    {
        // переменные с данными
        double[] arrY;
        double[] arrX;

        public frmLS()
        {
            InitializeComponent();
        }

        private void dataX_AddRowColumns(int ColNum)
        {
            if (ColNum != 0)
            {
                for (int i = 0; i < ColNum; i++)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.HeaderText = "I" + (i + 1);
                    column.Width = 40;
                    dataX.Columns.Add(column);
                };
                // Добавляем две строки в DataGridView
                DataGridViewRow rowX = new DataGridViewRow();
                DataGridViewRow rowY = new DataGridViewRow();
                rowX.CreateCells(dataX);
                rowX.HeaderCell.Value = "X";
                rowY.CreateCells(dataX);
                rowY.HeaderCell.Value = "Y";
                dataX.Rows.Add(rowX);
                dataX.Rows.Add(rowY);
            }
        }
        private void frmLS_Load(object sender, EventArgs e)
        {
            dataX_AddRowColumns(0);
        }

        private void btnSolution_Click(object sender, EventArgs e)
        {
            arrX = new double[dataX.ColumnCount];
            arrY = new double[dataX.ColumnCount];
            double[] locArr = new double[dataX.ColumnCount];

            for (int i = 0; i < dataX.RowCount; i++)
            {
                for (int j = 0; j < dataX.ColumnCount; j++)
                {
                    if (i != 1)                   
                        arrX[j] = Convert.ToDouble((dataX[j, i].Value.ToString()));
                    else 
                        arrY[j] =  Convert.ToDouble((dataX[j, i].Value.ToString()));                    
                }
            }

            string phiBox1 = cbPhi1.SelectedItem.ToString();
            string phiBox2 = cbPhi2.SelectedItem.ToString();

            double[] phi1;  double[] phi2;
            phi1 = returnPhi(phiBox1, arrX);
            phi2 = returnPhi(phiBox2, arrX);
            double a0, a1, a2 = 0.0;
            LeastSquares(arrX, arrY, phi1, phi2,out a0,out a1, out a2);
            double[] appY = CountApprY(a0, a1, a2, phi1, phi2,arrX.Length);
            //выводы на экран
            string ResultA = String.Concat(a0.ToString(),";", a1.ToString(), ";", a2.ToString()) ;
            tbCoff.Clear();
            tbCoff.AppendText(ResultA);
            DrawChart(arrX, arrY, appY);
        }


        public void DrawChart(double[] X, double[] Y, double[] Y1)
        {
            
            // Устанавливаем размеры и местоположение Chart
            ChartOfFunction.Size= new Size(380, 330);
            //ChartOfFunction.Location = new Point(10, 10);

            // Создаем новую область Chart
            ChartArea chartArea1 = new ChartArea();
            ChartOfFunction.ChartAreas.Add(chartArea1);
            
            // Создаем новый объект Series для хранения точек графика
            Series series1 = new Series();
            Series series2 = new Series();
            series1.ChartType = SeriesChartType.Point;          
            series2.ChartType = SeriesChartType.Point;
            series1.Color = Color.Red;
            series2.Color = Color.Blue;
            series1.LegendText = "Эксперименты";
            series1.LegendText = "Результаты аппроксимации";
            // Добавляем точки в Series
            for (int i = 0; i < X.Length; i++)
            {
                series1.Points.AddXY(X[i], Y[i]);
                series2.Points.AddXY(X[i], Y1[i]);
            }          

            if (ChartOfFunction.Series.Count>0)
            {
                ChartOfFunction.Series.Clear();
            };

            // Добавляем Series в Chart
            ChartOfFunction.Series.Add(series1);
            ChartOfFunction.Series.Add(series2);
        }
        private double[] returnPhi(string PhiBox, double[] arX)
        {
            double[] phi = new double[arX.Length];
            switch (PhiBox)
            {
                case "√x": 
                    phi = SquareX(arX);
                    return phi;
                case "x^2":
                    phi = MultX(arX);
                    return phi;
                case "sin x": break;
                case "x": return arX;
                case "1/x":
                    phi = DivX(arX);
                    return phi;
                default:
                    return phi;
            }
            return phi;
        }

        private void ExpNumCount_ValueChanged(object sender, EventArgs e)
        {
            int ColNum = Convert.ToInt32(ExpNumCount.Value.ToString());
            // Удаляем все столбцы из dataX
            for (int i = dataX.Columns.Count - 1; i >= 0; i--)
            {
                dataX.Columns.Remove(dataX.Columns[i]);
            }         
            dataX_AddRowColumns(ColNum);
        }

        #region Функции которые могут быть расчитаны в программе
        private double[] SquareX(double[] arX)
        {
            double[] phi = new double[arX.Length];
            for (int i = 0; i < arX.Length - 1; i++)
            {
                //здесь должна быть обработка на <0 но мне лень
                phi[i] = Math.Sqrt(arX[i]);
            }
            return phi;
        }

        private double[] MultX(double[] arX)
        {
            double[] phi = new double[arX.Length];
            for (int i = 0; i < arX.Length - 1; i++)
            {
                //здесь должна быть обработка на <0 но мне лень
                phi[i] = arX[i]* arX[i];
            }
            return phi;
        }
        private double[] DivX(double[] arX)
        {
            double[] phi = new double[arX.Length];
            for (int i = 0; i < arX.Length; i++)
            {
                //здесь должна быть обработка на <0 но мне лень
                phi[i] = 1.0/arX[i];
            }
            return phi;
        }

        #endregion


        private double[] CountApprY(double a0, double a1, double a2, double[] phi1, double[] phi2, int NumX)
        {
            double[] apprY = new double[NumX];
            for(int i=0; i<NumX; i++)
            {
                apprY[i] = a0 + a1 * phi1[i] + a2 * phi2[i];
            }
            return apprY;
        }


        // Метод наименьших квадратов для аппроксимации зависимой переменной y по двум функциям phi1(x) и phi2(x)
        // с использованием матричных операций

        public void LeastSquares(double[] x, double[] y, double[] phi1, double[] phi2, out double a0, out double a1, out double a2)
        {
            // Построение матрицы X и вектора y на основе данных
            int n = x.Length;
            double[,] X = new double[n, 3];
            double[] Y = new double[n];
            for (int i = 0; i < n; i++)
            {
                X[i, 0] = 1.0;
                X[i, 1] = phi1[i];
                X[i, 2] = phi2[i];
                Y[i] = y[i];
            }

            // Решение системы линейных уравнений X'X*a = X'y
            double[,] Xt = Transpose(X);
            double[,] XtX = Multiply(Xt, X);
            double[] XtY = MultiplyVector(Xt, Y);
            double[,] invXtX = Inverse(XtX);
            double[] a = MultiplyVector(invXtX, XtY);

            // Извлечение коэффициентов
            a0 = Math.Round(a[0], 2);
            a1 = Math.Round(a[1], 2);
            a2 = Math.Round(a[2], 2);
        }

        // Транспонирование матрицы
        public double[,] Transpose(double[,] A)
        {
            int m = A.GetLength(0);
            int n = A.GetLength(1);
            double[,] B = new double[n, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    B[j, i] = A[i, j];
                }
            }
            return B;
        }

        // Умножение матриц
        public double[,] Multiply(double[,] A, double[,] B)
        {
            int m = A.GetLength(0);
            int n = A.GetLength(1);
            int p = B.GetLength(1);
            double[,] C = new double[m, p];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
            return C;
        }

        // Умножение матрицы на вектор
        public double[] MultiplyVector(double[,] A, double[] x)
        {
            int m = A.GetLength(0);
            int n = A.GetLength(1);
            double[] y = new double[m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    y[i] += A[i, j] * x[j];
                }
            }
            return y;
        }

        // Вычисление обратной матрицы методом Гаусса-Жордана
        public double[,] Inverse(double[,] A)
        {
            int n = A.GetLength(0);
            double[,] B = new double[n, n * 2];

            // Создание расширенной матрицы
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    B[i, j] = A[i, j];
                }
                B[i, n + i] = 1.0;
            }

            // Прямой ход метода Гаусса
            for (int i = 0; i < n; i++)
            {
                // Поиск максимального элемента в столбце i
                int maxRow = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (Math.Abs(B[j, i]) > Math.Abs(B[maxRow, i]))
                    {
                        maxRow = j;
                    }
                }

                // Обмен строк i и maxRow
                if (maxRow != i)
                {
                    for (int j = 0; j < n * 2; j++)
                    {
                        double temp = B[i, j];
                        B[i, j] = B[maxRow, j];
                        B[maxRow, j] = temp;
                    }
                }

                // Нормализация строки i
                double pivot = B[i, i];
                if (pivot == 0.0)
                {
                    return null;
                }
                for (int j = i; j < n * 2; j++)
                {
                    B[i, j] /= pivot;
                }

                // Вычитание i-й строки из всех строк, кроме i-й
                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                    {
                        double factor = B[j, i];
                        for (int k = i; k < n * 2; k++)
                        {
                            B[j, k] -= factor * B[i, k];
                        }
                    }
                }
            }

            // Извлечение обратной матрицы
            double[,] invA = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    invA[i, j] = B[i, n + j];
                }
            }

            return invA;
        }

    }
}
