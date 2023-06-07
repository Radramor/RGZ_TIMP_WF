using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGZ_TIMP_WF
{
    abstract internal class XYChart
    {
        public List<List<PointF>> XYCharts { get; private protected set; } = new List<List<PointF>>();
        private protected float minX, minY, maxX, maxY;

        public abstract void CreateChart(DataGridView XYDataGridView, DataGridView InfoDataGridView, PictureBox PictureBox);

        private protected void SearchMinMax()
        {
            minX = float.MaxValue;
            minY = float.MaxValue;
            maxX = float.MinValue;
            maxY = float.MinValue;
            foreach (var XYPoints in XYCharts)
            {
                foreach (var point in XYPoints)
                {
                    minX = minX > point.X ? point.X : minX;
                    minY = minY > point.Y ? point.Y : minY;
                    maxX = maxX < point.X ? point.X : maxX;
                    maxY = maxY < point.Y ? point.Y : maxY;
                }
            }
        }
        private protected List<List<PointF>> AdjustPointsForPictureBox(int widthPictureBox, int heightPictureBox ,int widthDataGridView)
        {
            int XYAxesSize = 100;
            int PicBoxSizeX = widthPictureBox - widthDataGridView - XYAxesSize;
            int PicBoxSizeY = heightPictureBox - XYAxesSize;
            int ShiftY = heightPictureBox;
            float XMultiplier = PicBoxSizeX;
            float YMultiplier = PicBoxSizeY;
            List<List<PointF>> result = new List<List<PointF>>();
            List<PointF> resultPoints;
            PointF pf;
            float pfX, pfY;

            if (minX != maxX)
            {
                if (minX > 0)
                    XMultiplier = PicBoxSizeX / (maxX - Math.Abs(minX));
                else
                    XMultiplier = PicBoxSizeX / (maxX + Math.Abs(minX));
            }

            if (minY != maxY)
            {
                if (minY < 0)
                    YMultiplier = PicBoxSizeY / (maxY + Math.Abs(minY));
                else
                    YMultiplier = PicBoxSizeY / (maxY - Math.Abs(minY));
            }

            foreach (var XYPoints in XYCharts)
            {
                resultPoints = new List<PointF>();
                foreach (var point in XYPoints)
                {
                    if (minX > 0)
                        pfX = point.X * XMultiplier - Math.Abs(minX) * XMultiplier + XYAxesSize / 2;
                    else
                        pfX = point.X * XMultiplier + Math.Abs(minX) * XMultiplier + XYAxesSize / 2;

                    pfY = point.Y * YMultiplier - minY * YMultiplier - ShiftY + XYAxesSize / 2;
                    pf = new PointF(pfX, pfY);
                    resultPoints.Add(pf);
                }
                result.Add(resultPoints);
            }
            return result;
        }
        private protected void FillInfoChartDataGridView(DataGridView ChartInfoDataGridView, Color color, int numChart)
        {
            ChartInfoDataGridView.Rows.Add();
            int LastRow = ChartInfoDataGridView.RowCount - 1;
            ChartInfoDataGridView.Rows[LastRow].Cells[0].Style.BackColor = color;
            ChartInfoDataGridView.Rows[LastRow].Cells[1].Value = numChart;
            ChartInfoDataGridView.ClearSelection();
        }

        private protected List<List<PointF>> CreateListCharts(DataGridView XYdataGridView)
        {
            try
            {
                List<List<PointF>> XYCharts = new List<List<PointF>>();

                for (int i = 0; i < XYdataGridView.ColumnCount; i += 2)
                {
                    List<PointF> XYPoints = new List<PointF>();

                    for (int j = 0; j < XYdataGridView.RowCount - 1; j++)
                    {
                        if (XYdataGridView.Rows[j].Cells[i].Value == null &&
                            XYdataGridView.Rows[j].Cells[i + 1].Value == null)
                            continue;
                        if (!float.TryParse(XYdataGridView.Rows[j].Cells[i].Value.ToString(), out float x) ||
                            !float.TryParse(XYdataGridView.Rows[j].Cells[i + 1].Value.ToString(), out float y))
                            throw new NullReferenceException();

                        PointF point = new PointF(x, y);
                        XYPoints.Add(point);
                    }
                    XYPoints.Sort((left, right) => left.X.CompareTo(right.X));
                    XYCharts.Add(XYPoints);
                }
                return XYCharts;
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("Некоректно введены значения X и Y");
            }
            catch (FormatException)
            {
                throw new FormatException("Кусочно-линейная диаграмма: некоторые значениях X или Y состоят не из чисел");
            }
        }
        private protected void CreateXYAxes(PictureBox ChartPictureBox)
        {
            Graphics graphics = ChartPictureBox.CreateGraphics();
            Pen pen = new Pen(Color.Black, 1);
            int CountLineInAxes = 10;
            int leftBorder = 50;
            int rightBorder = 541;
            int topBorder = 50;
            int bottomBorder = 335;
            float stepX = (rightBorder - leftBorder) / CountLineInAxes;
            float stepValuesX = (maxX - minX) / CountLineInAxes;
            float valuesX = minX;

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
            float stepY = (bottomBorder - topBorder) / CountLineInAxes + 0.5f;
            float valuesY = minY;
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
