using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TestUSBBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MyLog.richTextBox1 = richTextBox1;
            MyLog.path = Program.GetStartupPath() + @"LogData\";
            MyLog.lines = 50;
            MyLog.start();

        }

        private void ComPortSend_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //            throw new NotImplementedException();
            Thread.Sleep(100);

            byte[] byteRead = new byte[SerialFun.ComPortSend.BytesToRead];
            SerialFun.ComPortSend.Read(byteRead, 0, byteRead.Length);

            string temp = "";
            for (int i = 0; i < byteRead.Length; i++)
            {
                temp += byteRead[i].ToString("x2");
            }
            Trace.WriteLine("串口收到:" + temp);

            this.textBox1.BeginInvoke(new Action(() => { textBox1.AppendText(temp + "\n"); }));

            Data.ReturnStr = temp;

            if (Data.ReturnStr.Length >= 22)
            {
                int pos = Data.ReturnStr.IndexOf("eb90000508");
                if (Data.ReturnStr.Substring(pos + 18, 4).ToUpper() == "09D7")
                {
                    String CmdStr = "1ACF0005F8" + Data.ReturnStr.Substring(pos + 10, 8) + "FC1D";//
                    SerialFun.SendToPort(SerialFun.ComPortSend, CmdStr.ToLower());

                    MyLog.Info("向串口发送:" + CmdStr.ToLower());

                }
            }

        }

        private void btn_SerialOpen_Click(object sender, EventArgs e)
        {
            if (btn_SerialOpen.Text == "打开端口")
            {
                SerialFun.ComPortSend = new SerialPort();
                SerialFun.ComPortSend.BaudRate = 115200;
                SerialFun.ComPortSend.PortName = comboBox_SerialPortNum.Text;
                SerialFun.ComPortSend.DataBits = 8;
                SerialFun.ComPortSend.StopBits = StopBits.One;
                SerialFun.ComPortSend.Parity = Parity.None;

                try
                {
                    SerialFun.ComPortSend.Open();
                    MyLog.Info("打开串口成功");

                    //事件注册
                    SerialFun.ComPortSend.DataReceived += ComPortSend_DataReceived;

                    btn_SerialOpen.Text = "关闭端口";
                }
                catch (Exception ex)
                {
                    MyLog.Error("打开串口失败：" + ex.Message);
                }
            }
            else
            {
                try
                {
                    btn_SerialOpen.Text = "打开端口";
                    SerialFun.ComPortSend.Close();
                    //事件注销
                    SerialFun.ComPortSend.DataReceived -= ComPortSend_DataReceived;
                    MyLog.Info("关闭串口成功");
                }
                catch (Exception ex)
                {
                    MyLog.Error("关闭串口失败：" + ex.Message);
                }
            }
        }

        private void comboBox_SerialPortNum_DropDown(object sender, EventArgs e)
        {
            string[] str = SerialPort.GetPortNames();
            if (str == null)
            {
                MyLog.Info("尝试选择串口,但是本机没有串口！");
            }
            comboBox_SerialPortNum.Items.AddRange(str);
            int count = comboBox_SerialPortNum.Items.Count;

            for (int i = 0; i < count; i++)
            {
                string str1 = comboBox_SerialPortNum.Items[i].ToString();
                for (int j = i + 1; j < count; j++)
                {
                    string str2 = comboBox_SerialPortNum.Items[j].ToString();
                    if (str1 == str2)
                    {
                        comboBox_SerialPortNum.Items.RemoveAt(j);
                        count--;
                        j--;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Data.ReturnStr.Length == 22)
            {
                if (Data.ReturnStr.Substring(0, 10).ToUpper() == "EB90000501" && Data.ReturnStr.Substring(18, 4).ToUpper() == "09D7")
                {
                    String CmdStr = "1ACF0005F1" + Data.ReturnStr.Substring(10, 8) + "FC1D";//
                    SerialFun.SendToPort(SerialFun.ComPortSend, CmdStr.ToLower());
                    textBox1.AppendText("向串口发送:" + CmdStr.ToLower() + "\n");
                }
            }

            //String CmdStr = "1ACF0005F1" + Data.ReturnStr.Substring(10, 8) + "FC1D";//
            //SerialFun.SendToPort(SerialFun.ComPortSend, CmdStr.ToLower());
            //textBox1.AppendText("向串口发送:" + CmdStr.ToLower() + "\n");
            //MyLog.Info("向串口发送:" + CmdStr.ToLower());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String CmdStr = "1ACF0005F5CDCDCDCDFC1D".ToLower();//
            SerialFun.SendToPort(SerialFun.ComPortSend, CmdStr);
            textBox1.AppendText("向串口发送:" + CmdStr + "\n");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Data.ReturnStr.Length >= 22)
            {
                int pos = Data.ReturnStr.IndexOf("eb90000508");
                if (Data.ReturnStr.Substring(pos + 18, 4).ToUpper() == "09D7")
                {
                    String CmdStr = "1ACF0005F8" + Data.ReturnStr.Substring(pos + 10, 8) + "FC1D";//
                    SerialFun.SendToPort(SerialFun.ComPortSend, CmdStr.ToLower());
                    textBox1.AppendText("向串口发送:" + CmdStr.ToLower() + "\n");
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
