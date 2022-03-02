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
        /// 데이터 처리를 위한 기능을 모은 클래스 입니다.
        /// </summary>
        public class CData
        {
            CXYPlot XYPlot;
            XYHandler Up;
            XYHandler Down;

            public CData(CXYPlot XYPlot)
            {
                this.XYPlot = XYPlot;
                Up = XYPlot.Up;
                Down = XYPlot.Down;
            }

            /// <summary>
            /// 데이터를 입력합니다. 한번에 (채널,UpDown)에 2000개의 데이터를 넣을 수 있습니다.
            /// 그 이상의 데이터가 들어오면 Error가 발생합니다.
            /// </summary>
            /// <param name="ch">채널 선택</param>
            /// <param name="X">X 값</param>
            /// <param name="Y">Y 값</param>
            /// <param name="upDown">Up,Down 영역을 구분하기 위한 열거형</param>
            public void Input(CH ch, UpDown upDown, double X, double Y)
            {
                int index;

                if (upDown == UpDown.Up)
                {
                    index = Up.index[(int)ch];
                    Up.xArray[(int)ch][index] = X;
                    Up.yArray[(int)ch][index] = Y;
                    Up.index[(int)ch]++;
                }
                else
                {
                    index = Down.index[(int)ch];
                    Down.xArray[(int)ch][index] = X;
                    Down.yArray[(int)ch][index] = Y;
                    Down.index[(int)ch]++;
                }
            }
            /// <summary>
            /// 특정 채널과 영역에 해당하는 데이터를 지웁니다.
            /// </summary>
            /// <param name="ch">채널 선택</param>
            /// <param name="upDown">영역을 구분하기 위한 열거형 null 입력시 Up,Down 모두 클리어</param>
            public void Clear(CH ch, UpDown? upDown = null)
            {
                if (upDown == null)
                {
                    Up.index[(int)ch] = 0;
                    Down.index[(int)ch] = 0;
                    Array.Clear(Up.xArray[(int)ch], 0, Up.xArray[(int)ch].Length);
                    Array.Clear(Up.yArray[(int)ch], 0, Up.yArray[(int)ch].Length);
                    Array.Clear(Down.xArray[(int)ch], 0, Down.xArray[(int)ch].Length);
                    Array.Clear(Down.yArray[(int)ch], 0, Down.yArray[(int)ch].Length);
                }
                else
                {
                    if ((UpDown)upDown == UpDown.Up)
                    {
                        Up.index[(int)ch] = 0;
                        Array.Clear(Up.xArray[(int)ch], 0, Up.xArray[(int)ch].Length);
                        Array.Clear(Up.yArray[(int)ch], 0, Up.yArray[(int)ch].Length);
                    }
                    else
                    {
                        Down.index[(int)ch] = 0;
                        Array.Clear(Down.xArray[(int)ch], 0, Down.xArray[(int)ch].Length);
                        Array.Clear(Down.yArray[(int)ch], 0, Down.yArray[(int)ch].Length);
                    }
                }
            }
        }
    }

}