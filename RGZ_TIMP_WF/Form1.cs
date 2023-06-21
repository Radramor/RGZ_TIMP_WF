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
                PieChartErrorLabel.Text = "";
            }
            catch (Exception ex)
            {
                PieChartErrorLabel.Text = ex.Message;
            }
        }
        private void LineChartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (XYDataGridView.RowCount == 0) return;
                lineChart.CreateChart(XYDataGridView, LineChartInfoDataGridView, LineChartPictureBox);
                LineChartErrorlabel.Text = "";
            }
            catch (Exception ex)
            {
                LineChartErrorlabel.Text = ex.Message;
            }
        }

        private void BarChartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (BarDataGridView.RowCount == 0) return;
                barChart.CreateChart(BarDataGridView, BarChartInfoDataGridView, BarChartPictureBox);
                BarErrorLabel.Text = "";
            }
            catch (Exception ex)
            {
                BarErrorLabel.Text = ex.Message;
            }
        }
        private void CreateXYbutton_Click(object sender, EventArgs e)
        {
            int numberXY = XYDataGridView.ColumnCount / 2;
            XYDataGridView.Columns.Add("columnX", "X" + numberXY);
            XYDataGridView.Columns.Add("columnY", "Y" + numberXY);
            LineChartErrorlabel.Text = "";
        }

        private void DeleteLastChartButton_Click(object sender, EventArgs e)
        {
            try
            {
                XYDataGridView.Columns.RemoveAt(XYDataGridView.ColumnCount - 1);
                XYDataGridView.Columns.RemoveAt(XYDataGridView.ColumnCount - 1);
                LineChartErrorlabel.Text = "";
            }
            catch (ArgumentOutOfRangeException ex)
            {
                LineChartErrorlabel.Text = "Все значения X и Y уже удалены";
            }
        }

        private void AddBarChartButton_Click(object sender, EventArgs e)
        {
            BarDataGridView.Columns.Add("ColumnChart", "Значения графика " + (BarDataGridView.ColumnCount - 1));
        }

        private void DeleteLastBarChartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (BarDataGridView.ColumnCount == 1)
                    throw new ArgumentOutOfRangeException();
                BarDataGridView.Columns.RemoveAt(BarDataGridView.ColumnCount - 1);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                BarErrorLabel.Text = "Все графики уже удалены";
            }
        }
    }
}
