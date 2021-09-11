using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chart_01
{
    public partial class frmChart1 : Form
    {
        public frmChart1()
        {
            InitializeComponent();
        }

        private void frmChart1_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("중간고사 성적");  // Chart 제목을 중간고사 성적으로 설정
            chart1.Series.Add("Series2");      // 디폴트로 Series1 이 있는데, Series2라는 이름의 Series를 추가
            chart1.Series["Series1"].LegendText = "수학";  // 범례를 수학, 영어로 정해준다
            chart1.Series["Series2"].LegendText = "영어";

            chart1.ChartAreas.Add("ChartArea2"); // 디폴트로 ChartArea1라는 차트 영역이있는데 ChartArea2라는 차트 영역을 추가해준다.    
            chart1.Series["Series2"].ChartArea = "ChartArea2"; // Series2의 ChartArea를 ChartArea2로 지정해준다. 이러면 영어 점수가 두번째 차트 영역에 표시된다.

            Random r = new Random();  // 랜덤 객체 생성
            for (int i = 0; i < 10; i++)   // Series1, Series2를 랜덤하게 10개의 데이터를 추가
            {
                chart1.Series["Series1"].Points.AddXY(i, r.Next(101));
                chart1.Series["Series2"].Points.AddXY(i, r.Next(101));
            }
        }

        private void btnOneCharArea_Click(object sender, EventArgs e)
        {
            // 버튼을 클릭했을때 ChartArea2를 삭제하고 Series2의 ChartArea를 ChartArea1으로 지정해준다.
            int ix = chart1.ChartAreas.IndexOf("ChartArea2");
            if (ix < 1) return;

            chart1.ChartAreas.RemoveAt(chart1.ChartAreas.IndexOf("ChartArea2"));
            chart1.Series["Series2"].ChartArea = "ChartArea1"; // ChartArea1에 두 개의 시리즈가 다 표시된다.
        }

        private void btnTwoChartArea_Click(object sender, EventArgs e)
        {
            // 버튼을 클릭하면 ChartArea2를 추가하고 Series2의 ChartArea를 ChartArea2로 지정해준다.
            int ix = chart1.ChartAreas.IndexOf("ChartArea2");
            if (ix >= 1) return;

            chart1.ChartAreas.Add("ChartArea2");
            chart1.Series["Series2"].ChartArea = "ChartArea2";
        }
    }
}
