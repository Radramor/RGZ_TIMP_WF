using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGZ_TIMP_WF
{
    internal class BarChart : XYChart
    {
        public override void CreateChart(DataGridView XYDataGridView, DataGridView InfoDataGridView, PictureBox PictureBox)
        {

            XYCharts = CreateListCharts(XYDataGridView);
            int countLines = 0;
            foreach(var chart in XYCharts)
            {
                if (chart.Count == 0)
                    throw new ArgumentException("Столбчатая диаграмма: для графика необходима минимум одна точка");
                foreach (var Point in chart)
                {
                    countLines++;
                }

            }
            SearchMinMax();
            minY = -maxY /10;
            XYCharts = AdjustBarPointsForPictureBox(PictureBox.Width, PictureBox.Height, InfoDataGridView.Width);

            Random random = new Random();
            Graphics graphics = PictureBox.CreateGraphics();
            graphics.Clear(Color.LightGray);
            graphics.ScaleTransform(1, -1);
            CreateXYAxesBarChart(PictureBox);
            InfoDataGridView.Rows.Clear();
            int step = 0;
            foreach (var XYPoints in XYCharts)
            {
                Color color = Color.FromArgb(random.Next() % 255, random.Next() % 255, random.Next() % 255);
                Pen pen = new Pen(color, 300/ countLines);
                for (int i = 0; i < XYPoints.Count; i++)
                {
                    PointF[] pointFs = new PointF[2];
                    float indent = (float)(random.NextDouble() - 0.5) * 10
                        ;
                    pointFs[0] = new PointF(XYPoints[i].X, -335);
                    pointFs[1] = new PointF(XYPoints[i].X, XYPoints[i].Y);
                    graphics.DrawLines(pen, pointFs);
                }
                FillInfoChartDataGridView(InfoDataGridView, color, step);
                step++;
            }

        }

        private List<List<PointF>> AdjustBarPointsForPictureBox(int widthPictureBox, int heightPictureBox, int widthDataGridView)
        {
            
            int countLines = 0;
            
            int ShiftY = heightPictureBox;
            
            List<List<PointF>> result = new List<List<PointF>>();
            List<PointF> resultPoints;
            PointF pf;
            float pfX, pfY;

            foreach (var chart in XYCharts)
            {
                foreach (var Point in chart)
                {
                    countLines++;
                }

            }
            int XYAxesSize = 100 / countLines;
            int PicBoxSizeX = widthPictureBox - widthDataGridView - XYAxesSize;
            int PicBoxSizeY = heightPictureBox - XYAxesSize;
            float XMultiplier = PicBoxSizeX;
            float YMultiplier = PicBoxSizeY;
            if (minX != maxX)
            {
                XMultiplier = PicBoxSizeX / countLines + XYAxesSize;
            }

            if (minY != maxY)
            {
                if (minY < 0)
                    YMultiplier = PicBoxSizeY / (maxY + Math.Abs(minY));
                else
                    YMultiplier = PicBoxSizeY / (maxY - Math.Abs(minY));
            }
            float stepX = XMultiplier / 1.5f;
            foreach (var XYPoints in XYCharts)
            {
                resultPoints = new List<PointF>();
                foreach (var point in XYPoints)
                {
                    if (minX > 0)
                        pfX = stepX - XYAxesSize / 2;
                    else
                        pfX = point.X * XMultiplier + XYAxesSize / 2;

                    pfY = point.Y * YMultiplier - minY * YMultiplier - ShiftY + XYAxesSize / 2;
                    pf = new PointF(pfX, pfY);
                    resultPoints.Add(pf);
                    stepX += XMultiplier;
                }
                result.Add(resultPoints);
            }
            return result;
        }

        private void CreateXYAxesBarChart(PictureBox ChartPictureBox)
        {
            Graphics graphics = ChartPictureBox.CreateGraphics();
            Pen pen = new Pen(Color.Black, 1);
            int CountPoint = 0;
            foreach (var XYPoins in XYCharts)
            {
                foreach (var point in XYPoins)
                {
                    CountPoint++;
                }
            }
    
            int CountLineInAxes = CountPoint - 1;
            int leftBorder = 50;
            int rightBorder = 541;
            int topBorder = 50;
            int bottomBorder = 335;
            float stepX;
            float stepValuesX;
            float valuesX = minX;
            if (CountLineInAxes == 0)
            {
                stepX = (rightBorder - leftBorder) / 2;
                stepValuesX = (maxX - minX) / 2;
            }
            else
            {
                stepX = (rightBorder - leftBorder) / CountLineInAxes;
                stepValuesX = (maxX - minX) / CountLineInAxes;
            }


            PointF[] XAxes = new PointF[2]
            {
                new PointF(leftBorder - 10, bottomBorder),
                new PointF(rightBorder + 100, bottomBorder),
            };
            graphics.DrawLines(pen, XAxes);
            PointF topPoint = new PointF(leftBorder, bottomBorder - 10);
            PointF botPoint = new PointF(leftBorder, bottomBorder + 10);
            for (int i = 0; i <= CountLineInAxes; i++)
            {
                XAxes = new PointF[2]
                {
                    topPoint,
                    botPoint
                };
                graphics.DrawLines(pen, XAxes);
                graphics.DrawString(Math.Round(valuesX, 2).ToString(), new Font("Arial", 8), Brushes.Black, botPoint.X - 10, botPoint.Y + 5);
                valuesX += stepValuesX;
                topPoint.X += stepX;
                botPoint.X += stepX;
            }


            PointF[] YAxes = new PointF[2]
            {
                new PointF(leftBorder, bottomBorder),
                new PointF(leftBorder, 0),
            };
            graphics.DrawLines(pen, YAxes);

            PointF rightPoint = new PointF(leftBorder + 10, bottomBorder);
            PointF leftPoint = new PointF(leftBorder - 10, bottomBorder);
            float valuesY = minY;
            float stepY = (bottomBorder - topBorder) / (CountLineInAxes + 1) + 0.5f;
            float stepValuesY = (maxY - minY) / CountLineInAxes;
            for (int i = 0; i <= CountLineInAxes; i++)
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
    }
}
