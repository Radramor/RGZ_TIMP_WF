using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGZ_TIMP_WF
{
    internal class PieChart
    {
        private List<float> numbers = new List<float>();
        public void CreatePieChart(DataGridView dataGridView, PictureBox pictureBox, DataGridView infoDataGridView)
        {
            infoDataGridView.Rows.Clear();
            numbers.Clear();
            float sum = CountSumAndFillList(dataGridView);
            Random random = new Random();
            Graphics graphics = pictureBox.CreateGraphics();
            Rectangle rectangle = new Rectangle(30, 3, 330, 330);
            int degreesInCircle = 360;
            float startAngle = 0;
            float sweepAngle;

            foreach (var num in numbers)
            {
                sweepAngle = num / sum * degreesInCircle;
                Color color = Color.FromArgb(random.Next() % 255, random.Next() % 255, random.Next() % 255);
                Brush brush = new SolidBrush(color);
                graphics.FillPie(brush, rectangle, startAngle, sweepAngle);
                startAngle += sweepAngle;
                FillInfoPieChartDataGridView(num, sum, color, infoDataGridView);
            }
        }
        private void FillInfoPieChartDataGridView(float num, float sum, Color color, DataGridView infoDataGridView)
        {
            infoDataGridView.Rows.Add();
            infoDataGridView.Rows[infoDataGridView.RowCount - 1].Cells[0].Style.BackColor = color;
            infoDataGridView.Rows[infoDataGridView.RowCount - 1].SetValues("", num, Math.Round(num / sum, 2));
            infoDataGridView.ClearSelection();
        }
        private float CountSumAndFillList(DataGridView dataGridView)
        {
            try
            {
                float sum = 0;
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    numbers.Add(float.Parse(dataGridView.Rows[i].Cells[0].Value.ToString()));
                    if (numbers.Last() < 0)
                        throw new ArgumentException("Круговая диаграмма: некоторые ячейки содержат отрицательные числа");
                    sum += float.Parse(dataGridView.Rows[i].Cells[0].Value.ToString());
                }
                return sum;
            }
            catch (FormatException)
            {
                throw new FormatException("Круговая диаграмма: некоторые ячейки не содержат положительные числа");
            }
        }
    }
}
