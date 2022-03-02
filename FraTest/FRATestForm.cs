using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlFlots.fFRA
{
    public partial class Form1 : Form
    {
        CFRAPlot fraPlot;
        double[] fre;
        double[] mag;
        double[] pha;

        public Form1()
        {
            InitializeComponent();
            fraPlot = new CFRAPlot(formsPlot1);

            #region  데이터 처리 선작업 
            fre = txtdata(Data.frequnecy);
            mag = txtdata(Data.Magnitude);
            pha = txtdata(Data.phase);
            #endregion

            //차트의 보여줄 영역을 정해줍니다.
            fraPlot.Display.Screen(fre[0], fre[fre.Length - 1], -80, 40, -360, 180);
         
            //차트에 보여줄 (영역,데이터타입)을 설정합니다. 
            chk_MagMain.Checked = true;
            chk_PhaMain.Checked = true;

         
            fraPlot.UpdatePlot();

        }

        #region Text파일에서 데이터를 가져오기 위한 선작업
        double[] txtdata(Data data)
        {
            string path = @".\frequency.txt";
            string freRaw = System.IO.File.ReadAllText(path);

            string[] fre = freRaw.Split(' ', '\n', '\r', '\t');
            double[][] dataDouble = new double[3][];

            fre = fre.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            dataDouble[0] = Array.ConvertAll(fre, s => double.Parse(s));


            path = @".\Magnitude.txt";
            string Magnitude_raw = System.IO.File.ReadAllText(path);

            string[] Magnitude = Magnitude_raw.Split(' ', '\n', '\r', '\t');
            Magnitude = Magnitude.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            dataDouble[1] = Array.ConvertAll(Magnitude, s => double.Parse(s));


            path = @".\phase.txt";
            string phase_raw = System.IO.File.ReadAllText(path);

            string[] phase = phase_raw.Split(' ', '\n', '\r', '\t');
            phase = phase.Where(x => !string.IsNullOrEmpty(x)).ToArray();

            dataDouble[2] = Array.ConvertAll(phase, s => double.Parse(s));



            return dataDouble[(int)data];


        }
        public enum Data
        {
            frequnecy = 0,
            phase = 2,
            Magnitude = 1
        }
        #endregion




        private void Click_DataProcess(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Name)
            {
                // 폴더 내에 저장되어 있는 주파수,크기,위상 데이터를 받아서 데이터를 입력하는 프로세스입니다.
                case "btn_input":
                    Input_Click();
                    break;
                // 저장된 데이터를 지웁니다.
                case "btn_Clear":
                    Clear_Click();
                    break;
                // Current 영역에 있는 데이터를 Reference영역에 저장시킵니다.
                case "btn_SaveInReference":
                    TempSave_Click();
                    break;
                default:
                    break;

            }
        }

        private void Input_Click()
        {
            //이전 Currnet영역의 데이터를 지웁니다.
            fraPlot.Data.Clear(Source.Current);
            
            //텍스트파일에서 추출한 데이터를 넣어줍니다. 데이터의 최대 입력 갯수는 2000개 입니다. 2000개 이상의 데이터를 입력시
            //에러가 발생합니다. 
            for (int i = 0; i < fre.Length; i++)
            {
                fraPlot.Data.Input(fre[i], mag[i], pha[i]);
                fraPlot.UpdatePlot();
            }
        }
        private void Clear_Click()
        {
            fraPlot.Data.Clear(Source.Current);
            
            //모든 Plot 라이브러리는 차트의 변화를 알고싶으면 변화후 Update를 호출해주어야합니다.
            fraPlot.UpdatePlot();
        }
        private void TempSave_Click()
        {
            //Tool.SaveInReference는 임시저장을 담당합니다.
            fraPlot.Tool.SaveInReference();

            //모든 Plot 라이브러리는 차트의 변화를 알고싶으면 변화후 Update를 호출해주어야합니다.
            fraPlot.UpdatePlot();
        }



        private void chk_DottedLine_CheckedChanged(object sender, EventArgs e)
        {
            //점선을 사용시 true 미사용시 false가 됩니다. 사용 후 마우스가 form 내부에 들어가면 DottedLine이 활성화 됩니다.
            fraPlot.Tool.Mouse.DottedLine(chk_DottedLine.Checked);
        }

        private void Check_Visible(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;

            switch (chk.Name)
            {
                    // 각 영역을 보여줄때 Line 함수를 사용합니다.
                case "chk_MagMain":
                    fraPlot.Display.Line(DataType.Magnitude, Source.Current, null, chk.Checked);
                    break;
                case "chk_PhaMain":

                    fraPlot.Display.Line(DataType.Phase, Source.Current, null, chk.Checked);
                    break;
                case "chk_MagBack":

                    fraPlot.Display.Line(DataType.Magnitude, Source.Reference, null, chk.Checked);
                    break;
                case "chk_PhaBack":

                    fraPlot.Display.Line(DataType.Phase, Source.Reference, null, chk.Checked);
                    break;
                default:
                    break;
            }
        }

     



    }
}
