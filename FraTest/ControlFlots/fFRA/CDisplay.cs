using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ControlFlots.fFRA
{
    public partial class CFRAPlot
    {
        /// <summary>
        /// 디스플레이 처리를 위한 기능을 모은 클래스 입니다.
        /// </summary>
        public class CDisplay
        {
            CFRAPlot FRAPlot;
            public CDisplay(CFRAPlot FRAPlot)
            {
                this.FRAPlot = FRAPlot;
            }

            /// <summary>
            /// 보여주는 화면을 특정 좌표구간으로 보이도록 합니다. 
            /// fra모드에서는 초기에 설정해주면 됩니다.
            /// </summary>
            /// <param name="xmin"></param>
            /// <param name="xmax"></param>
            /// <param name="mMin"></param>
            /// <param name="mMax"></param>
            /// <param name="pMin"></param>
            /// <param name="pMax"></param>
            public void Screen(double xmin, double xmax, double mMin, double mMax, double pMin, double pMax)
            {
                FRAPlot.formsPlot.Plot.SetAxisLimits(Math.Log10(xmin), Math.Log10(xmax), mMin, mMax, 0, 2);     //
                FRAPlot.formsPlot.Plot.SetAxisLimits(Math.Log10(xmin), Math.Log10(xmax), pMin, pMax, 0, 3);
                Match(Source.Current);
            }

            /// <summary>
            // 특정 영역으로 축을 맞추어 줍니다.
            /// </summary>
            /// <param name="standardSource"></param>
            private void Match(Source standardSource = Source.Current)
            {
                if (standardSource == Source.Current)
                {
                    FRAPlot.formsPlot.Plot.SetAxisLimits(FRAPlot.formsPlot.Plot.GetAxisLimits(0, 2), 0, 4);
                    FRAPlot.formsPlot.Plot.SetAxisLimits(FRAPlot.formsPlot.Plot.GetAxisLimits(0, 3), 0, 5);
                }
                else
                {
                    FRAPlot.formsPlot.Plot.SetAxisLimits(FRAPlot.formsPlot.Plot.GetAxisLimits(0, 4), 0, 2);
                    FRAPlot.formsPlot.Plot.SetAxisLimits(FRAPlot.formsPlot.Plot.GetAxisLimits(0, 5), 0, 3);
                }
            }

            /// <summary>
            /// 특정 Line의 색과 보임여부를 설정합니다.
            /// </summary>
            /// <param name="select"></param>
            /// <param name="source"></param>
            /// <param name="color"></param>
            /// <param name="isvisible"></param>
            public void Line(DataType select, Source source, Color? color, bool? isvisible)
            {
                if (color != null)
                {
                    if (source == Source.Current)
                    {
                        FRAPlot.Current.LineColor(select, (Color)color);
                    }
                    else
                    {
                        FRAPlot.Reference.LineColor(select, (Color)color);
                    }

                }

                if (isvisible != null)
                {
                    if (source == Source.Current)
                    {
                        FRAPlot.Current.LineDisplay(select, (bool)isvisible);
                    }
                    else
                    {
                        FRAPlot.Reference.LineDisplay(select, (bool)isvisible);
                    }
                }
                FRAPlot.UpdatePlot();

            }
            /// <summary>
            /// 특정 축의 색과 보임여부를 설정합니다.
            /// </summary>
            /// <param name="select"></param>
            /// <param name="source"></param>
            /// <param name="color"></param>
            /// <param name="isvisible"></param>
            public void Axis(DataType select, Source source, Color? color, bool? isvisible)
            {
                if (color != null)
                {
                    if (source == Source.Current)
                    {
                        FRAPlot.Current.AxisColor(select, (Color)color);
                    }
                    else
                    {
                        FRAPlot.Reference.AxisColor(select, (Color)color);
                    }

                }

                if (isvisible != null)
                {
                    if (source == Source.Current)
                    {
                        FRAPlot.Current.AxisDisplay(select, (bool)isvisible);
                    }
                    else
                    {
                        FRAPlot.Reference.AxisDisplay(select, (bool)isvisible);
                    }
                }
                FRAPlot.UpdatePlot();
            }
        }
    }

}
