using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGZ_TIMP_WF
{
    internal class LineChart : XYChart
    {
        public override void CreateChart(DataGridView XYDataGridView, DataGridView InfoDataGridView, PictureBox PictureBox) 
        {
            try
            {
                XYCharts = CreateListCharts(XYDataGridView);

                SearchMinMax();

                XYCharts = AdjustPointsForPictureBox(PictureBox.Width, PictureBox.Height, InfoDataGridView.Width);

                Random random = new Random();
                Graphics graphics = PictureBox.CreateGraphics();
                graphics.Clear(Color.LightGray);
                graphics.ScaleTransform(1, -1);

                
                InfoDataGridView.Rows.Clear();
                int step = 0;
                foreach (var XYPoints in XYCharts)
                {
                    Color color = Color.FromArgb(random.Next() % 255, random.Next() % 255, random.Next() % 255);
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
                CreateXYAxes(PictureBox);
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("Кусочно-линейная диаграмма: для построния диаграммы необходимо минимум 2 точки");
            }
        }       
    }
}
