using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace TestUSBBox
{
    class SerialFun
    {
        public static SerialPort ComPortSend;
        public static string SendToPort(SerialPort ComPort, string CmdStr)
        {
            byte[] SendToPort = Function.StrToHexByte(CmdStr);
            try
            {
                ComPort.Write(SendToPort, 0, SendToPort.Length);
            }
            catch (Exception ex)
            {
                MyLog.Error(ex.Message + "  串口发送失败");
                return "Error";
            }

            String str = null;
            for (int i = 0; i < SendToPort.Length; i++)
            {
                str += SendToPort[i].ToString("x2");
            }
            return str;

        }



    }
}
