using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * @brief XY,FRA,Scope 네임스페이스
 * @author LeejeongHoon
 * @date 2022-02-16
 * @version 1.4.0
 */
namespace ControlFlots
{

    
    static public class Graphstyle
    {
        /// <summary>
        /// @brief XY,FRA,Scope의 그래프 스타일
        /// </summary>

        /// <summary>
        /// @brief Nomal Format 
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        static public string NullFormat(double y)
        {
            return Convert.ToString(y);
        }

        /// <summary>
        /// @brief Log Format
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        static public string LogFormat(double y)
        {
            if (y == Convert.ToInt32(y))
            {
                return Math.Pow(10, y).ToString("");
            }
            else
            {
                return "";
            }

        }
        /// <summary>
        /// @brief Time Scale
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        static public string TimeFormat(double y)
        {
            if (y == Convert.ToInt32(y))
            {
                return y.ToString("");
            }
            else
            {
                return "";
            }
        }


    }

    /// <summary>
    /// 단일 트리거, 반복 트리거 모드 선택
    /// </summary>
    public enum TriggerMode
    {
        NotTrigger,
        Nomal,
        Repeat
    }
    /// <summary>
    /// @brief 채널을 나타냅니다.
    /// @note 채널은 총 6개 있습니다.
    /// </summary>
    public enum CH
    {
        ch1 = 0,
        ch2 = 1,
        ch3 = 2,
        ch4 = 3,
        ch5 = 4,
        ch6 = 5
    }

    /// <summary>
    /// @brief 영역을 나타냅니다.
    /// @note Current 영역과 Reference영역을 가지고 있습니다.
    /// </summary>
    public enum Source
    {
        Current = 0,
        Reference = 1
    }
    /// <summary>
    /// @brief 선과 축을 선택합니다.
    /// @note 선은 데이터를 나타냅니다.
    /// </summary>
    public enum Section
    {
        Axis = 0,
        Line = 1
    }
    /// <summary>
    /// @brief 방향을 선택합니다.
    /// @note Scope에서 사용하는 열거형입니다.
    /// </summary>
    public enum Direction
    {
        Upward,
        Downward,
        Left,
        Right
    }

    public enum GraphMode
    {
        Roll = 0, //
        Nomal = 1, //
        NomalParallel = 2

    }
    public enum UpDown
    {
        Up =0,
        Down =1,
    }

    /// <summary>
    /// @brief 배율을 선택합니다.
    /// @note Scope에서 사용하는 열거형입니다.
    ///  확대와 관련되어 있습니다.
    /// </summary>
    public enum Magnification
    {
        x1 = 1,
        x2 = 2,
        x4 = 4,
        x8 = 8,
        x16 = 16,
        x32 = 32,
        x64 = 64
    }

    /// <summary>
    /// @brief 송/수신 결과
    /// @note 데이터 입출력시 상태를 알려줍니다.
    /// </summary>
    public enum Result
    {
        ACK = 0,
        NACK = 1
    }

    /// <summary>
    /// @breif 크기와 위상
    /// @note FRA에서 사용하는 열거형입니다.
    /// </summary>
    public enum DataType
    {
        Magnitude = 0,
        Phase = 1
    }
    public enum InputMode
    {
        Normal,
        Roll
    }

    static public class TimeScale
    {


        readonly public static double InitAxisMag = 10000;

        /// <summary>
        /// @brief 기본 통신 속도에 대한 열거형 클래스입니다.
        /// @note Scope에서 사용하는 열거형입니다.
        /// </summary>

        /// <summary>
        /// @brief Scope chart의 시간축 그리드를 설정합니다.
        /// @note 기본단위가 ms 단위임을 조심해야합니다.
        /// </summary>
        public enum GridInv
        {
            _1ms = 1,
            _2ms = 2,
            _5ms = 5,
            _10ms = 10,
            _20ms = 20,
            _50ms = 50,
            _100ms = 100,
            _200ms = 200,
            _500ms = 500,
            _1000ms = 1000
        }

        public enum CodeDivision
        {
            _1ms = 10,
            _2ms = 20,
            _5ms = 50,
            _10ms = 100,
            _20ms = 200,
            _50ms = 500,
            _100ms = 1000,
            _200ms = 2000,
            _500ms = 5000,
            _1000ms = 10000
        }


        /// <summary>
        /// @brief 통신속도에 대한 열거형입니다.
        /// @note 토마호크의 통신모드는 총 4개 존재합니다.
        /// </summary>
        public enum Mode
        {
            Mode1 = 24000,
            Mode2 = 12000,
            Mode4 = 10000,
            Mode6 = 5000
        }
    }


    static public class InitValue
    {
        /// <summary>
        /// @brief 초기에 차트의 내부 배열을 설정하기 위한 클래스입니다.
        /// </summary>
        public static int VOLUME = 240000;
    }
}
