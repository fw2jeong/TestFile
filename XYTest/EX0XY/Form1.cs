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
using ControlFlots.fXY;


namespace EX0XY
{
    public partial class Form1 : Form
    {
        CXYPlot XYPlot;

        public Form1()
        {
            InitializeComponent();



            ////생성시 인자로 컨트롤 할 formsplot 객체를 넘겨줍니다.
            //XYPlot = new CXYPlot(formsPlot1);
            ////채널의 색과 보임여부를 설정합니다. : 현재 CH.1의 Up 영역의 색을 Red로 보임여부를 true로 설정
            //XYPlot.Display.Line(CH.ch1, UpDown.Up, Color.Red, true);
            ////현재 차트가 보여줄 영역을 설정 : 현재 xmin -1 xmax 1 ymin -1 ymax 1 로 설정
            //XYPlot.Display.Screen(-2, 2, -2, 2);
            ////데이터를 입력합니다. CH.1에 Up영역에 0,0의 데이터를 입력 
            ////확인을 위해 1cycle의 원을 sin과 cos의 360개의 점으로 표현
            //for (int i = 0; i < 360; i++)
            //{
            //    XYPlot.Data.Input(CH.ch1, UpDown.Up, Math.Cos(Math.PI / 180 * i), Math.Sin(Math.PI / 180 * i));
            //}
            ////모든 설정 후 호출 시 적용
            //XYPlot.UpdatePlot();


            //생성시 인자로 컨트롤 할 formsplot 객체를 넘겨줍니다.
            XYPlot = new CXYPlot(formsPlot1);
            //채널의 색과 보임여부를 설정합니다. : 현재 CH.1의 Up 영역의 색을 Red로 보임여부를 true로 설정
            XYPlot.Display.Line(CH.ch2, UpDown.Up, Color.Blue, true);
            //현재 차트가 보여줄 영역을 설정 : 현재 xmin -1 xmax 1 ymin -1 ymax 1 로 설정
            XYPlot.Display.Screen(0, 4095, 0, 4095);

            for (int i = 0; i < 4095; i += 10)
            {
                XYPlot.Data.Input(CH.ch2, UpDown.Up, i, i);
            }
            //모든 설정 후 호출 시 적용
            XYPlot.UpdatePlot();




        }
    }
}
