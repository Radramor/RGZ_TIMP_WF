using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGZ_TIMP_WF
{
    internal class LineChart
    {
        private List<List<PointF>> XYCharts = new List<List<PointF>>();
        private float minX, minY, maxX, maxY;
        private Color color;
        private Pen pen;
        public void CreateChart(DataGridView XYDataGridView, DataGridView InfoDataGridView, PictureBox PictureBox)
        {
            Random random = new Random();
            Graphics graphics = PictureBox.CreateGraphics();
            graphics.Clear(Color.LightGray);
            graphics.ScaleTransform(1, -1);
            InfoDataGridView.Rows.Clear();

            CreateListCharts(XYDataGridView);
            SearchMinMax();
            AdjustPointsForPictureBox(PictureBox.Width, PictureBox.Height, InfoDataGridView.Width);
            
            int step = 0;
            foreach (var XYPoints in XYCharts)
            {
                Color color = Color.FromArgb(random.Next() % 255, random.Next() % 170, random.Next() % 70);
                Pen pen = new Pen(color, 5);
                PointF[] pointFs = new PointF[XYPoints.Count];
                for (int i = 0; i < XYPoints.Count; i++)
                {
                    pointFs[i] = XYPoints[i];
                }
                graphics.DrawLines(pen, pointFs);
                FillInfoChartDataGridView(InfoDataGridView, color, step);
                step++;
            }
            CreateXYAxes(PictureBox, InfoDataGridView);         
        }
        private void SearchMinMax()
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
        private void AdjustPointsForPictureBox(int widthPictureBox, int heightPictureBox, int widthDataGridView)
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
                XMultiplier = PicBoxSizeX / (maxX - minX);
            }

            if (minY != maxY)
            {
                YMultiplier = PicBoxSizeY / (maxY - minY);
            }

            foreach (var XYPoints in XYCharts)
            {
                resultPoints = new List<PointF>();
                foreach (var point in XYPoints)
                {
                    pfX = point.X * XMultiplier - minX * XMultiplier + XYAxesSize / 2;
                    pfY = point.Y * YMultiplier - minY * YMultiplier - ShiftY + XYAxesSize / 2;
                    pf = new PointF(pfX, pfY);
                    resultPoints.Add(pf);
                }
                result.Add(resultPoints);
            }
            XYCharts = result;
        }
        private void FillInfoChartDataGridView(DataGridView ChartInfoDataGridView, Color color, int numChart)
        {
            ChartInfoDataGridView.Rows.Add();
            int LastRow = ChartInfoDataGridView.RowCount - 1;
            ChartInfoDataGridView.Rows[LastRow].Cells[0].Style.BackColor = color;
            ChartInfoDataGridView.Rows[LastRow].Cells[1].Value = numChart;
            ChartInfoDataGridView.ClearSelection();
        }

        private void CreateListCharts(DataGridView XYdataGridView)
        {
            try
            {
                XYCharts = new List<List<PointF>>();

                for (int i = 0; i < XYdataGridView.ColumnCount; i += 2)
                {
                    List<PointF> XYPoints = new List<PointF>();

                    for (int j = 0; j < XYdataGridView.RowCount - 1; j++)
                    {
                        if (XYdataGridView.Rows[j].Cells[i].Value == null &&
                            XYdataGridView.Rows[j].Cells[i + 1].Value == null)
                            continue;
                        float x = float.Parse(XYdataGridView.Rows[j].Cells[i].Value.ToString());
                        float y = float.Parse(XYdataGridView.Rows[j].Cells[i + 1].Value.ToString());

                        PointF point = new PointF(x, y);
                        XYPoints.Add(point);
                    }
                    if (XYPoints.Count < 2) throw new ArgumentException();
                    XYPoints.Sort((left, right) => left.X.CompareTo(right.X));
                    XYCharts.Add(XYPoints);
                }
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("Для построния диаграммы необходимо минимум 2 точки");
            }
            catch (FormatException)
            {
                throw new FormatException("Некоректно введены значения X и Y");
            }
        }
        private void CreateXYAxes(PictureBox ChartPictureBox, DataGridView infoDataGridView)
        {
            Graphics graphics = ChartPictureBox.CreateGraphics();
            Pen pen = new Pen(Color.Black, 1);
            int CountLineInAxes = 10;
            int leftBorder = 50;
            int rightBorder = ChartPictureBox.Width - infoDataGridView.Width - leftBorder;
            int topBorder = 50;
            int bottomBorder = ChartPictureBox.Height - topBorder;
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
