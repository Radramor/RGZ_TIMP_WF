using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGZ_TIMP_WF
{
    internal class BarChart
    {
        private List<List<PointF>> XYCharts  = new List<List<PointF>>();
        private List<List<float>> YCharts  = new List<List<float>>();
        private float minY, maxY;
        private Color color;
        private Pen pen;
        public void CreateChart(DataGridView BarDataGridView, DataGridView InfoDataGridView, PictureBox PictureBox)
        {
            Random random = new Random();
            Graphics graphics = PictureBox.CreateGraphics();
            graphics.Clear(Color.LightGray);
            graphics.ScaleTransform(1, -1);
            InfoDataGridView.Rows.Clear();
            int step = 0;

            CreateListCharts(BarDataGridView);
            int countLines = 0;
            int maxLinesInChart = 0;
            foreach (var chart in YCharts)
            {
                if (chart.Count == 0)
                    throw new ArgumentException("Столбчатая диаграмма: для графика необходима минимум одна точка");
                countLines = 0;
                foreach (var Point in chart)
                {
                    countLines++;
                }
                maxLinesInChart = maxLinesInChart < countLines ? countLines : maxLinesInChart;
            }

            SearchMinMax();
            AdjustPointsForPictureBox(PictureBox, InfoDataGridView, maxLinesInChart);            
            CreateXYAxes(PictureBox, InfoDataGridView, BarDataGridView, maxLinesInChart);
            

            foreach (var XYPoints in XYCharts)
            {
                color = Color.FromArgb(random.Next() % 255, random.Next() % 200, random.Next() % 200);
                pen = new Pen(color, 60 / (maxLinesInChart + countLines));
                for (int i = 0; i < XYPoints.Count; i++)
                {
                    PointF[] pointFs = new PointF[2] 
                    { 
                        new PointF(XYPoints[i].X, -PictureBox.Height + 50),
                        new PointF(XYPoints[i].X, XYPoints[i].Y)
                    };
                    graphics.DrawLines(pen, pointFs);
                }
                FillInfoChartDataGridView(InfoDataGridView, color, step);
                step++;
            }

        }
        private void CreateListCharts(DataGridView BarDataGridView)
        {
            try
            {
                YCharts.Clear();
                for (int i = 1; i < BarDataGridView.ColumnCount; i++)
                {
                    List<float> YPoints = new List<float>();
                    for (int j = 0; j < BarDataGridView.RowCount - 1; j++)
                    {
                        if (BarDataGridView.Rows[j].Cells[i].Value == null)
                            continue;

                        float y = float.Parse(BarDataGridView.Rows[j].Cells[i].Value.ToString());
                        YPoints.Add(y);
                    }
                    YCharts.Add(YPoints);
                }
            }
            catch (FormatException)
            {
                throw new FormatException("Некоректно введены значения X и Y");
            }
        }

        private void AdjustPointsForPictureBox(PictureBox pictureBox, DataGridView dataGridView, int countLines)
        {
            int XYAxesSize = 50;
            int PicBoxSizeX = pictureBox.Width - dataGridView.Width - XYAxesSize;
            int PicBoxSizeY = pictureBox.Height - XYAxesSize;
            int ShiftY = pictureBox.Height;
            List<List<PointF>> result = new List<List<PointF>>();
            List<PointF> resultPoints;
            PointF pf;
            float pfX, pfY;
            float X;
            //отступ между столбцами с разными значениями X
            float indentX = PicBoxSizeX / (countLines + 1);
            //отстутп между столбцами с одинаковыми значениями X
            float stepX = indentX / (YCharts.Count + 3);

            float YMultiplier = PicBoxSizeY / (maxY - minY);

            for (int i = 0; i < YCharts.Count; i++)
            {
                X = XYAxesSize + indentX + (stepX * i);
                resultPoints = new List<PointF>();
                foreach (var point in YCharts[i])
                {
                    //pfX = point.X * XMultiplier - minX * XMultiplier + XYAxesSize / 2;
                    pfX = X;
                    pfY = point * YMultiplier - minY * YMultiplier - ShiftY + XYAxesSize / 2;
                    pf = new PointF(pfX, pfY);
                    resultPoints.Add(pf);
                    X += indentX;
                }
                result.Add(resultPoints);
            }
            XYCharts = result;
        }
        private protected void FillInfoChartDataGridView(DataGridView ChartInfoDataGridView, Color color, int numChart)
        {
            ChartInfoDataGridView.Rows.Add();
            int LastRow = ChartInfoDataGridView.RowCount - 1;
            ChartInfoDataGridView.Rows[LastRow].Cells[0].Style.BackColor = color;
            ChartInfoDataGridView.Rows[LastRow].Cells[1].Value = numChart;
            ChartInfoDataGridView.ClearSelection();
        }

        private void CreateXYAxes(PictureBox ChartPictureBox, DataGridView infoDataGridView, DataGridView barDataGridView, int maxLinesInChart)
        {
            Graphics graphics = ChartPictureBox.CreateGraphics();
            Pen pen = new Pen(Color.Black, 1);
            int leftBorder = 50;
            int rightBorder = ChartPictureBox.Width - infoDataGridView.Width;
            int topBorder = 25;
            int bottomBorder = ChartPictureBox.Height - (topBorder*2);
            float stepX = (rightBorder - leftBorder) / (maxLinesInChart+1);

            PointF[] XAxes = new PointF[2]
            {
                new PointF(leftBorder - 10, bottomBorder),
                new PointF(rightBorder + 100, bottomBorder),
            };
            graphics.DrawLines(pen, XAxes);

            PointF topPoint = new PointF(leftBorder + stepX, bottomBorder - 10);
            PointF botPoint = new PointF(leftBorder + stepX, bottomBorder + 10);
            for (int i = 0; i < barDataGridView.RowCount - 1; i++)
            {
                XAxes = new PointF[2]
                {
                    topPoint,
                    botPoint
                };
                graphics.DrawLines(pen, XAxes);
                graphics.DrawString
                (
                    barDataGridView.Rows[i].Cells[0].Value != null ?
                    barDataGridView.Rows[i].Cells[0].Value.ToString() : "",
                    new Font("Arial", 8),
                    Brushes.Black,
                    botPoint.X - 10,
                    botPoint.Y + 5
                ); ;
                topPoint.X += stepX;
                botPoint.X += stepX;
            }


            PointF[] YAxes = new PointF[2]
            {
                new PointF(leftBorder, bottomBorder),
                new PointF(leftBorder, 0),
            };
            graphics.DrawLines(pen, YAxes);
            maxLinesInChart = 10;
            PointF rightPoint = new PointF(leftBorder + 10, bottomBorder);
            PointF leftPoint = new PointF(leftBorder - 10, bottomBorder);
            float stepY = (bottomBorder - topBorder) / maxLinesInChart;
            float valuesY = minY;
            float stepValuesY = (maxY - minY) / maxLinesInChart;
            for (int i = 0; i <= maxLinesInChart; i++)
            {
                YAxes = new PointF[2]
                {
                    rightPoint,
                    leftPoint
                };
                graphics.DrawLines(pen, YAxes);
                graphics.DrawString(Math.Round(valuesY, 2).ToString(), new Font("Arial", 8), Brushes.Black, leftPoint.X - 35, leftPoint.Y - 10);
                valuesY += stepValuesY;
                rightPoint.Y -= stepY;
                leftPoint.Y -= stepY;
            }
        }
        private protected void SearchMinMax()
        {
            maxY = float.MinValue;
            minY = float.MaxValue;
            foreach (var YPoints in YCharts)
            {
                foreach (var point in YPoints)
                {
                    minY = minY > point ? point : minY;
                    maxY = maxY < point ? point : maxY;
                }
            }
            minY = -maxY + minY;
        }
    }
}
