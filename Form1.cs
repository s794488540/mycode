using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 鼠标连点
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Timers.Timer timer = new System.Timers.Timer();
        bool b = true;
        private void button1_Click(object sender, EventArgs e)
        {
            int everyTime = 1;
            int sleepTime = Convert.ToInt32(textBox1.Text);
            while (true)
            {
                #region
                MouseHelper.SetCursorPos(280, 1000);//自动功能
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(945, 715);//右键关闭屏幕信息
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(945, 715);//右键关闭屏幕信息
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(945, 715);//右键关闭屏幕信息
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1350, 65);//人物血条
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1350, 85);//人物蓝条
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1130, 65);//宠物血条
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1130, 85);//宠物蓝条
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1130, 125);//宠物忠诚
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);
                //Thread.Sleep(sleepTime * 500);

                #endregion
                #region
                MouseHelper.SetCursorPos(2500, 800);//右侧消息框
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1990, 65);//人物血条
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1990, 85);//人物蓝条
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1770, 65);//宠物血条
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1770, 85);//宠物蓝条
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1770, 125);//宠物忠诚
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(936, 987);//自动功能
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1600, 715);//右键关闭屏幕信息
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1600, 715);//右键关闭屏幕信息
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1600, 715);//右键关闭屏幕信息
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);
                Thread.Sleep(sleepTime * 1000);
                #endregion

            }
            //MessageBox.Show("响应事件");

            //timer.AutoReset = true;
            //timer.Enabled = true;
            //timer.Interval = 2 * 500;
            //timer.Elapsed += timer_Elapsed;
            //timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int everyTime = 1;
            int sleepTime = Convert.ToInt32(textBox1.Text);
            while (true)
            {
                #region 第1个号
                MouseHelper.SetCursorPos(250, 375);//点击中间接下一个鬼
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(719, 186);//点击自动寻路
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                Thread.Sleep(1 * 500);
                MouseHelper.SetCursorPos(700, 556);//点击右下方飞行旗快捷键
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(157, 568);//自动功能
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(458, 414);//右键关闭屏幕信息
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(458, 414);//右键关闭屏幕信息
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(458, 414);//右键关闭屏幕信息
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(769, 33);//人物血条
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(769, 44);//人物蓝条
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(645, 34);//宠物血条
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(645, 44);//宠物蓝条
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(645, 68);//宠物忠诚
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);
                #endregion

                #region 第2个号
                MouseHelper.SetCursorPos(1200, 90);//切换账号
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1330, 32);//人物血条
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1330, 44);//人物蓝条
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1212, 34);//宠物血条
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1212, 44);//宠物蓝条
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1212, 67);//宠物忠诚
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1090, 414);//右键关闭屏幕信息
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(721, 576);//自动功能
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);
                #endregion

                #region 第3个号
                MouseHelper.SetCursorPos(1217, 695);//切换账号
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1330, 143);//人物血条
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1330, 154);//人物蓝条
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1212, 145);//宠物血条
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1212, 155);//宠物蓝条
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1212, 178);//宠物忠诚
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(1090, 490);//右键关闭屏幕信息
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);

                MouseHelper.SetCursorPos(721, 681);//自动功能
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                Thread.Sleep(everyTime * 500);
                #endregion
                Thread.Sleep(25000);
            }
        }
    }

    class MouseHelper
    {
        [System.Runtime.InteropServices.DllImport("user32")]
        public static extern int mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        //移动鼠标 
        public const int MOUSEEVENTF_MOVE = 0x0001;
        //模拟鼠标左键按下 
        public const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        //模拟鼠标左键抬起 
        public const int MOUSEEVENTF_LEFTUP = 0x0004;
        //模拟鼠标右键按下 
        public const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        //模拟鼠标右键抬起 
        public const int MOUSEEVENTF_RIGHTUP = 0x0010;
        //模拟鼠标中键按下 
        public const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        //模拟鼠标中键抬起 
        public const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        //标示是否采用绝对坐标 
        public const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int X, int Y);
    }
}
