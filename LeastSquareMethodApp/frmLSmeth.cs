using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeastSquareMethodApp
{
    public partial class frmLS : Form
    {
        // переменные с данными
        int[] arrY;
        int[] arrX;

        public frmLS()
        {
            InitializeComponent();


        }
        private void frmLS_Load(object sender, EventArgs e)
        {
            // Добавляем две строки в DataGridView
            DataGridViewRow rowX = new DataGridViewRow();
            DataGridViewRow rowY = new DataGridViewRow();
            rowX.CreateCells(dataX);
            rowX.Cells[0].Value = 0;
            rowX.HeaderCell.Value = "X";
            rowY.CreateCells(dataX);
            rowY.Cells[0].Value = 0;
            rowY.HeaderCell.Value = "Y";
            dataX.Rows.Add(rowX);
            dataX.Rows.Add(rowY);
        }

        private void btnSolution_Click(object sender, EventArgs e)
        {
            arrX = new int[dataX.ColumnCount];
            arrY= new int[dataX.ColumnCount];
            int[] locArr = new int[dataX.ColumnCount];

            for (int i = 0; i < dataX.RowCount; i++)
            {                          
                for (int j=0; j < dataX.ColumnCount; j++)
                {
                    locArr[j] = Convert.ToInt32((dataX[j, i].Value.ToString()));
                }
                if (i != 1) arrX = locArr;
                else  arrY = locArr;
            }
        }

        private void ExpNumCount_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
