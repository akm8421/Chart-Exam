using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Chart_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create a new chart.
            string[] legend = { "A", "B", "C" };
            string[] xAxis = { "Jan 2011", "Feb 2011", "Mar 2011", "Apr 2011", "May 2011", "Jun 2011", "Jul 2011", "Aug 2011" };
            double[] a = { 20, 10, 30, 15, 25, 50, 30, 70 };
            double[] b = { 40, 45, 65, 15, 98, 40, 80, 100 };
            double[] c = { 40, 55, 82, 22, 84, 10, 90, 5 };

            Series s1 = new Series();
            Series s2 = new Series();
            Series s3 = new Series();

            s1.Name = "Series1";
            s1.ChartArea = "ChartArea1";
            s1.ChartType = SeriesChartType.StackedColumn;
            s1["StackedGroupName"] = "Group1";

            s2.Name = "Series2";
            s2.ChartArea = "ChartArea1";
            s2.ChartType = SeriesChartType.StackedColumn;
            s2["StackedGroupName"] = "Group1";

            s3.Name = "Series3";
            s3.ChartArea = "ChartArea1";
            s3.ChartType = SeriesChartType.StackedColumn;
            s3["StackedGroupName"] = "Group1";

            chart1.Series.Clear();
            chart1.Titles.Add("매출실적");  // Chart 제목

            chart1.Series.Add(s1);
            chart1.Series.Add(s2);
            chart1.Series.Add(s3);

            chart1.Series["Series1"].LegendText = legend[0];  // 범례
            chart1.Series["Series2"].LegendText = legend[1];
            chart1.Series["Series3"].LegendText = legend[2];

            chart1.Series["Series1"].ChartType = SeriesChartType.StackedColumn;
            chart1.Series["Series2"].ChartType = SeriesChartType.StackedColumn;
            chart1.Series["Series3"].ChartType = SeriesChartType.StackedColumn;

            for (int i=0; i < xAxis.Length; i++)
            {
                string tip = string.Format("{0} \n {1} : {2} \n {3} : {4} \n {5} : {6}"
                            , xAxis[i], legend[2], c[i].ToString(), legend[1], b[i].ToString(), legend[0], a[i].ToString());

                chart1.Series["Series1"].Points.AddXY(xAxis[i], a[i]);
                chart1.Series["Series2"].Points.AddXY(xAxis[i], b[i]);
                chart1.Series["Series3"].Points.AddXY(xAxis[i], c[i]);

                chart1.Series["Series1"].Points[i].ToolTip = string.Format("{0}", tip);
                chart1.Series["Series2"].Points[i].ToolTip = string.Format("{0}", tip);
                chart1.Series["Series3"].Points[i].ToolTip = string.Format("{0}", tip);
            }

            

        }
    }
}
