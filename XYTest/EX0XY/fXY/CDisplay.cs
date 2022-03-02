using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ControlFlots;

namespace ControlFlots.fXY
{

    public partial class CXYPlot
    {
        /// <summary>
        /// 디스플레이 처리를 위한 기능을 모은 클래스 입니다.
        /// </summary>
        public class CDisplay
        {
            CXYPlot XYPlot;
            public CDisplay(CXYPlot XYPlot)
            {
                this.XYPlot = XYPlot;
            }

            /// <summary>
            /// 데이터의 디스플레이를 설정합니다.
            /// </summary>
            /// <param name="ch">채널 설정</param>
            /// <param name="upDown">영역 설정</param>
            /// <param name="color">색 설정</param>
            /// <param name="isVisible">보임여부 설정</param>
            public void Line(CH ch, UpDown upDown, Color? color = null, bool? isVisible = null)
            {
                CXYPlot.XYHandler XYHandler = (upDown == UpDown.Up) ? XYPlot.Up : XYPlot.Down;
                if (color != null)
                {
                    XYHandler.ScatterHandler[(int)ch].Color = (Color)color;
                }
                if (isVisible != null)
                {
                    XYHandler.ScatterHandler[(int)ch].IsVisible = (bool)isVisible;
                }
            }
            /// <summary>
            /// 축의 디스플레이를 설정합니다.
            /// </summary>
            /// <param name="ch">채널 설정</param>
            /// <param name="upDown">영역 설정</param>
            /// <param name="color">색 설정</param>
            /// <param name="isVisible">보임 여부 설정</param>
            public void Axis(CH ch, UpDown upDown, Color? color = null, bool? isVisible = null)
            {
                CXYPlot.XYHandler XYHandler = (upDown == UpDown.Up) ? XYPlot.Up : XYPlot.Down;

                if (color != null)
                {
                    XYHandler.yAxis[(int)ch].Color((Color)color);
                }
                if (isVisible != null)
                {
                    XYHandler.yAxis[(int)ch].IsVisible = (bool)isVisible;
                }
            }

            /// <summary>
            /// 차트에서 데이터가 보여지는 부분을 수정합니다.
            /// </summary>
            /// <param name="xmin">Chart X 최소값</param>
            /// <param name="xmax">Chart X 최대값</param>
            /// <param name="ymin">Chart Y 최소값</param>
            /// <param name="ymax">Chart Y 최대값</param>
            public void Screen(double xmin, double xmax, double ymin, double ymax)
            {
                XYPlot.formsPlot.Plot.SetAxisLimits(xmin, xmax, ymin, ymax, 0, 0);
                for (int i = 0; i < 12; i++)
                {
                    XYPlot.formsPlot.Plot.SetAxisLimits(xmin, xmax, ymin, ymax, 0, 2 + i);
                }

            }
        }
    }

}