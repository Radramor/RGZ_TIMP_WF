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
            SearchMinMax();
            minX--;
            minY--;
            XYCharts = AdjustPointsForPictureBox(PictureBox.Width, PictureBox.Height, InfoDataGridView.Width);

            Random random = new Random();
            Graphics graphics = PictureBox.CreateGraphics();
            graphics.Clear(Color.LightGray);
            graphics.ScaleTransform(1, -1);
            CreateXYAxes(PictureBox);
            InfoDataGridView.Rows.Clear();
            int step = 0;
            foreach (var XYPoints in XYCharts)
            {
                Color color = Color.FromArgb(random.Next() % 255, random.Next() % 255, random.Next() % 255);
                Pen pen = new Pen(color, 10);
                for (int i = 0; i < XYPoints.Count; i++)
                {
                    PointF[] pointFs = new PointF[2];
                    float indent = (float)(random.NextDouble() - 0.5) * 15
                        ;
                    pointFs[0] = new PointF(XYPoints[i].X + indent, -335);
                    pointFs[1] = new PointF(XYPoints[i].X + indent, XYPoints[i].Y);
                    graphics.DrawLines(pen, pointFs);
                }
                FillInfoChartDataGridView(InfoDataGridView, color, step);
                step++;
            }

        }
    }
}
