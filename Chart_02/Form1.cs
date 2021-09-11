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

namespace Chart_02
{
    public partial class frmChar2 : Form
    {
        public frmChar2()
        {
            InitializeComponent();
        }

        private void frmChar2_Load(object sender, EventArgs e)
        {
            // Create a new chart.
            string[] xAxis = { "Jan 2011", "Feb 2011", "Mar 2011", "Apr 2011", "May 2011", "Jun 2011", "Jul 2011", "Aug 2011" };
            double[] yAxisDevBacklog = { 220, 200, 120, 30, 25, 50, 30, 590 };
            double[] yAxisDevDaysCompleted = { 140, 145, 165, 105, 98, 140, 80, 100 };
            double[] yAxisDevCapacity = { 140, 155, 182, 122, 184, 210, 190, 205 };
            double[] yAxisNewDaysScheduled = { 29, 40, 55, 48, 59, 75, 70, 182 };

            chart1.Series["DevelopmentBacklog"].Points.DataBindXY(xAxis, yAxisDevBacklog);
            chart1.Series["DevelopmentBacklog"].ChartType = SeriesChartType.StackedColumn;
            chart1.Series["DevelopmentBacklog"].BorderWidth = 3;
            chart1.Series["DevelopmentBacklog"].Color = Color.Blue;
            //// Uncomment this line to use the secondary y axis
            //// chart1.Series["DevelopmentBacklog"].YAxisType = AxisType.Secondary;
            chart1.Series["DevelopmentBacklog"]["StackedGroupName"] = "DevelopmentBacklog";

            chart1.Series["NewDaysScheduled"].Points.DataBindXY(xAxis, yAxisNewDaysScheduled);
            chart1.Series["NewDaysScheduled"].ChartType = SeriesChartType.StackedColumn;
            chart1.Series["NewDaysScheduled"].BorderWidth = 3;
            chart1.Series["NewDaysScheduled"].Color = Color.Green;
            chart1.Series["NewDaysScheduled"]["StackedGroupName"] = "NewDaysScheduled";

            chart1.Series["DevDaysCompleted"].Points.DataBindXY(xAxis, yAxisDevDaysCompleted);
            chart1.Series["DevDaysCompleted"].ChartType = SeriesChartType.StackedColumn;
            chart1.Series["DevDaysCompleted"].BorderWidth = 3;
            chart1.Series["DevDaysCompleted"].Color = Color.LightGray;
            chart1.Series["DevDaysCompleted"]["StackedGroupName"] = "DevDaysCompleted";

            chart1.Series["DevCapacity"].Points.DataBindXY(xAxis, yAxisDevCapacity);
            chart1.Series["DevCapacity"].ChartType = SeriesChartType.StackedColumn;
            chart1.Series["DevCapacity"].BorderWidth = 3;
            chart1.Series["DevCapacity"].Color = Color.OrangeRed;
            chart1.Series["DevCapacity"]["StackedGroupName"] = "DevDaysCompleted";

            chart1.ChartAreas["chartArea"].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas["chartArea"].AxisY2.MajorGrid.Enabled = false;
        }
    }
}
