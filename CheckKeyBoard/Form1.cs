using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CheckKeyBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);
        private static long GetLastInputTime()
        {
            LASTINPUTINFO vLastInputInfo = new LASTINPUTINFO();
            vLastInputInfo.cbSize = Marshal.SizeOf(vLastInputInfo);
            // 捕获时间  
            if (!GetLastInputInfo(ref vLastInputInfo))
                return 0;
            else
                return (Environment.TickCount - (long)vLastInputInfo.dwTime)/ 1000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new System.Threading.Timer(c =>
            {
                CalcTime();
            }, null, 0, 1000);
        
        }

        void CalcTime()
        {
            SetNowTime();
            var noSenond = GetLastInputTime();
            SetNoTime(noSenond);
            SetLastTime(DateTime.Now.AddSeconds(-noSenond));
            SetTip(noSenond == 0 ? "操作中" : string.Concat(noSenond, "秒无操作"));
        }

        void SetNowTime()
        {
            if (lblNowTime.InvokeRequired)
            {
                lblNowTime.Invoke(new Action(SetNowTime));
            }
            else
            {
                lblNowTime.Text = DateTime.Now.ToString("yyyy:MM:dd HH:mm:ss");
            }
        }

        void SetLastTime(DateTime dateTime)
        {
            if (lblLastTime.InvokeRequired)
            {
                lblLastTime.Invoke(new Action<DateTime>(SetLastTime), dateTime);
            }
            else
            {
                lblLastTime.Text = dateTime.ToString("yyyy:MM:dd HH:mm:ss");
            }
        }

        void SetNoTime(long noSencod)
        {
            if (lblNoTime.InvokeRequired)
            {
                lblNoTime.Invoke(new Action<long>(SetNoTime), noSencod);
            }
            else
            {
                lblNoTime.Text = string.Concat(noSencod, " S");
            }
        }

        void SetTip(string tip)
        {
            if (lblNoTime.InvokeRequired)
            {
                lblTip.Invoke(new Action<string>(SetTip),tip);
            }
            else
            {
                lblTip.Text = tip;
            }
            
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    struct LASTINPUTINFO
    {
        // 设置结构体块容量  
        [MarshalAs(UnmanagedType.U4)]
        public int cbSize;
        // 捕获的时间  
        [MarshalAs(UnmanagedType.U4)]
        public uint dwTime;
    }
}
