using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGZ_TIMP_WF
{
    public partial class Form1 : Form
    {
        PieChart pieChart = new PieChart();
        LineChart lineChart = new LineChart();
        BarChart barChart = new BarChart();
        public Form1()
        {
            InitializeComponent();    
        }

        private void PieChartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PieChartDataGridView.RowCount == 0) return;
                pieChart.CreatePieChart(PieChartDataGridView, PieChartPictureBox, InfoPieChartDataGridView);
                ErrorLabel.Text = "";
            }
            catch (Exception ex)
            {
                ErrorLabel.Text = ex.Message;
            }
        }
        private void LineChartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (XYDataGridView.RowCount == 0) return;
                lineChart.CreateChart(XYDataGridView, LineChartInfoDataGridView, LineChartPictureBox);
                ErrorLabel.Text = "";
            }
            catch (Exception ex)
            {
               ErrorLabel.Text = ex.Message;
            }
        }

        private void BarChartButton_Click(object sender, EventArgs e)
        {
            //try
            {
                if (XYDataGridView.RowCount == 0) return;
                barChart.CreateChart(XYDataGridView, BarChartInfoDataGridView, BarChartPictureBox);
                ErrorLabel.Text = "";
            }
            //catch (Exception ex)
            {
               // ErrorLabel.Text = ex.Message;
            }
        }
        private void CreateXYbutton_Click(object sender, EventArgs e)
        {
            int numberXY = XYDataGridView.ColumnCount / 2;
            XYDataGridView.Columns.Add("columnX", "X" + numberXY);
            XYDataGridView.Columns.Add("columnX", "Y" + numberXY);
            ErrorLabel.Text = "";
        }

        private void DeleteLastChartButton_Click(object sender, EventArgs e)
        {
            try
            {
                XYDataGridView.Columns.RemoveAt(XYDataGridView.ColumnCount - 1);
                XYDataGridView.Columns.RemoveAt(XYDataGridView.ColumnCount - 1);
                ErrorLabel.Text = "";
            }
            catch (ArgumentOutOfRangeException ex)
            {
                 ErrorLabel.Text = "Все значения X и Y уже удалены";
            }
        }
    }
}
