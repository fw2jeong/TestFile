using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ControlFlots;
using ControlFlots.fScope;
using ScottPlot;

namespace firstExp
{
    public partial class Form1 : Form
    {
        CScope ScopePlot;

        public Form1()
        {
            InitializeComponent();

            ScopePlot = new CScope(formsPlot1);

            //CH.1 Source.Currnt영역의 그래프가 보이도록 설정.
            ScopePlot.Display.Line(CH.ch1, Source.Current, null, true);

            //Time Scale을 Scale은 50 Time/div frequncy는 100으로 설정. 
            ScopePlot.TimeScaleInit(50, 100);

            //차트의 변경사항을 적용시킵니다.
            ScopePlot.UpdatePlot();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }


        //100ms Timer 사용
        private void timer1_Tick(object sender, EventArgs e)
        {
            //sin Data를 입력합니다.
            ScopePlot.Data.Input(CH.ch1, DataGen.Sin(10, 1, 0, 200));
            //차트의 변경사항을 적용시킵니다.
            ScopePlot.UpdatePlot();
        }

        private void grid_button_click(object sender, EventArgs e)
        {
            string btnName = ((Button)sender).Name;

            switch (btnName)
            {
                case "btn_grid_50":
                    //차트 Time Scale을 50 Time/div 로 변경.
                    ScopePlot.TimeScaleInit(50);
                    break;
                case "btn_grid_100":
                    //차트 Time Scale을 100 Time/div 로 변경.
                    ScopePlot.TimeScaleInit(100);
                    break;
                case "btn_grid_200":
                    //차트 Time Scale을 200 Time/div 로 변경.
                    ScopePlot.TimeScaleInit(200);
                    break;
                case "btn_grid_500":
                    //차트 Time Scale을 500 Time/div 로 변경.
                    ScopePlot.TimeScaleInit(500);
                    break;
                case "btn_grid_1000":
                    //차트 Time Scale을 1000 Time/div 로 변경.
                    ScopePlot.TimeScaleInit(1000);
                    break;
                default:
                    break;
            }

        }

        private void btn_OpenColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //데이터표현의 색을 변경합니다.
                ScopePlot.Display.Line(CH.ch1, Source.Current, colorDialog1.Color);
            }
        }

        private void btn_OnOff_Click(object sender, EventArgs e)
        {
            //차트의 선의 보임 여부를 출력받아 토글시킵니다.
            bool Temp = !ScopePlot.Info.GetLineVisible(CH.ch1, Source.Current);
            ScopePlot.Display.Line(CH.ch1, Source.Current, null, Temp);
            ScopePlot.UpdatePlot();
        }
    }
}
